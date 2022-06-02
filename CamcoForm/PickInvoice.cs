using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamcoForm
{
    public partial class PickInvoice : Form
    {
        public PickInvoice()
        {
            InitializeComponent();
        }

        private const int ColQuantPick = 4;
        private const int ColQuantRemain = 5;

        public class PickingModel
        {
            public int InvoiceSO;
            public int quantity;
            public string productName;
            public int quantityPicked;
            public int quantityRemaining;
            public bool commit;
            public string InvoicePO;
        }

        public class ShippingModel
        {
            public int InvoiceSO;
            public int quantity;
            public string productName;
            public int quantityPicked;
            public int quantityRemaining;
            public bool packingList;
            public string InvoicePO;
            public string dateScheduled;
        }

        private bool editQuantity(int quantity)
        {
            return true;
        }

        public bool ValidateCell(DataGridViewCellValidatingEventArgs e)
        {
            bool result = true;

            switch (e.ColumnIndex)
            {
                case ColQuantPick:
                    int pickValue = convertToInt(e.FormattedValue.ToString());
                    result = editQuantity(pickValue);
                    break;
                case ColQuantRemain:
                    int remainValue = convertToInt(e.FormattedValue.ToString());
                    result = editQuantity(remainValue);
                    break;
            }
            return result;

        }

        private void PickInvoice_Load(object sender, EventArgs e)
        {

        }


        public Shipping convertPickToShipping(Picking placeholder)
        {
            Shipping ship = new Shipping();
            ship.InvoiceSO = placeholder.InvoiceSO;
            ship.Quantity = placeholder.Quantity;
            ship.InvoicePO = placeholder.InvoicePO;
            ship.QuantityPicked = placeholder.QuantityPicked;
            ship.QuantityRemaining = placeholder.QuantityRemaining;
            ship.DateScheduled = placeholder.DateScheduled;
            ship.ProductName = placeholder.ProductName;
            return ship;
        }

        public void setRemainingDGV(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    string stringRemaining = result[i].QuantityRemaining.ToString();
                    if (string.IsNullOrEmpty(stringRemaining))
                    {
                        dataGridView1.Rows[i].Cells[5].Value = result[i].Quantity;
                    }

                    else
                    {
                        dataGridView1.Rows[i].Cells[5].Value = result[i].QuantityRemaining;
                    }
                }
            }
        }

        public void setDetails(string invoiceSO)
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == invoiceSO);
                textPONumber.Text = result.InvoicePO;
                textSONumber.Text = result.InvoiceSO;
            }
        }

        public void updateShipDB(Shipping placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                /* check shipping in DB, cant access here */
                DB.Shippings.Add(placeholder);
                DB.SaveChanges();
            }
        }

        public Picking convertNullPickToDB(int i)
        {
            Picking placeholder = new Picking();
            placeholder.InvoiceSO = convertToInt(textSONumber.Text);
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.InvoicePO = textPONumber.Text;
            return placeholder;
        }

        public Picking convertPickToDB(int i)
        {
            Picking placeholder = new Picking();
            placeholder.InvoiceSO = convertToInt(textSONumber.Text);
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.QuantityPicked = convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());
           /* dataGridView1.Rows[i].Cells[5].Value = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString()); */
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.Commit = Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value);
            placeholder.InvoicePO = textPONumber.Text;
            placeholder.DateScheduled = DateTime.Today.ToString("MM/dd/yyyy");

            if (placeholder.Commit == true)
            {
                placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());
                
            }

            return placeholder;
        }

        public void updateInventory(Picking placeholder)
        {
            if (placeholder.Commit == true)
            {
                int subtractFromInventory = (int)placeholder.QuantityPicked;

                using (var DB = new CamcoEntities())
                {

                    Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == placeholder.ProductName);

                    if (result != null)
                    {
                        int currentAmount = result.ProductQuantity.Value;
                        if (currentAmount >= subtractFromInventory)
                        {
                            result.ProductQuantity = result.ProductQuantity - subtractFromInventory;
                            DB.SaveChanges();
                        }

                        else
                        {
                            string errorMsg = "Error: Pick quantity exceeds inventory amount.";
                            MessageBox.Show(errorMsg);
                        }
                        /* method to add each result to the shipping model, then set placeholder.commit = false*/
                    }
                }
            }

            else
            {

            }
        }

        public void updatePickDB(Picking placeholder)
        {
            /* error here */
            using (var db = new CamcoEntities())
            {
                db.Pickings.Add(placeholder);
                db.SaveChanges();
            }
        }

        public void removePickDB()
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        DB.Pickings.Remove(result[i]);
                        DB.SaveChanges();
                    }
                }
            }
        }

        public string getPO()
        {
            return textPONumber.Text;
        }

        public void setPO(string placeholder)
        {
            textPONumber.Text = placeholder;
        }

        

        public string getSO()
        {
            return textSONumber.Text;
        }

        public void setSO(string placeholder)
        {
            textSONumber.Text = placeholder;
        }

        public class SalesItem
        {
            public int quantity;
            public string DisplayName;

            public SalesItem(int quant, string sDisplayName)
            {
                quantity = quant;
                DisplayName = sDisplayName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        public SalesItem createSalesItem(int quant, string name)
        {
            SalesItem addedItem = new SalesItem(quant, name);
            return addedItem;
        }

        public void AddRow(SalesItem salesRow)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == salesRow.DisplayName);

                if (result != null)
                {
                    dataGridView1.Rows.Add(textSONumber.Text, textPONumber.Text, salesRow.quantity, salesRow.DisplayName);
                }
            }
        }

        public bool invalidQuantity(int i)
        {
            bool invalidQuantity = true;
            if (convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString()) > convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()))
            {
                string error = "Error: Quantity picked exceeds remaining amount in order.";
                MessageBox.Show(error);
                return invalidQuantity;
            }

            else
            {
                invalidQuantity = false;
            }
            return invalidQuantity;
        }


        public int convertToInt(string placeholder)
        {
            int number;
            bool success = int.TryParse(placeholder, out number);

            if (success)
            {
                return number;
            }

            else
            {
                return 0;
            }
        }

        public decimal convertToDecimal(string placeholder)
        {
            decimal number;
            bool success = decimal.TryParse(placeholder, out number);

            if (success)
            {
                return number;
            }

            else
            {
                return 0;
            }
        }

        public bool checkCommit(int i)
        {
            bool isChecked = false;

            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true)
            {
                isChecked = true;
            }

            else
            {
                isChecked = false;
            }

            return isChecked;

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Today.ToString("MM/dd/yyyy");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value == null)
                {
                    var placeholder = convertNullPickToDB(i);
                    updatePickDB(placeholder);
                }

                else
                {
                    if (invalidQuantity(i) == false)
                    {
                        var placeholder = convertPickToDB(i);

                        if (placeholder.Commit == true)
                        {
                            removePickDB();
                            updatePickDB(placeholder);
                            updateInventory(placeholder);
                            var convertedShip = convertPickToShipping(placeholder);
                            updateShipDB(convertedShip);
                        }

                        else
                        {
                            removePickDB();
                            updatePickDB(placeholder);
                        }

                    }

                    else
                    {
                        string msg = "p20";
                        MessageBox.Show(msg);
                    }
                }
            }
            
        }
    
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var result = ValidateCell(e);
            var eValue = e.FormattedValue.ToString();
            

            if (true)
            {
                if (String.IsNullOrEmpty(eValue))
                {
                    string errorMes = "No value entered";
                    MessageBox.Show(errorMes);
                }

                

                else
                {
                  
                }
            }

            else
            {
                string message = "Validation failed.";
                MessageBox.Show(message);
            }
        }
    }
}
