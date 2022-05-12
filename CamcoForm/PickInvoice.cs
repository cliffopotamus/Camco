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

        private const int ColQuantPick = 3;
        private const int ColQuantRemain = 4;

        public class PickingModel
        {
            public int InvoiceSO;
            public int quantity;
            public string productName;
            public int quantityPicked;
            public int quantityRemaining;
            public bool commit;
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

        public void updateRemainingQuantity(int i)
        {
            dataGridView1.Rows[i].Cells[4].Value = convertToInt(dataGridView1.Rows[i].Cells[1].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[3].Value.ToString());
        }
        

        public Picking convertToDB(int i)
        {
            Picking placeholder = new Picking();
            placeholder.InvoiceSO = convertToInt(textSONumber.Text);
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[1].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[2].Value.ToString();
            placeholder.QuantityPicked = convertToInt(dataGridView1.Rows[i].Cells[3].Value.ToString());
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());
            placeholder.Commit = Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value);
            return placeholder;
        }

        public void updateInventory(Picking placeholder)
        {
            if (placeholder.Commit == true)
            {
                int subtractFromInventory = placeholder.QuantityPicked;

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

        public void setDetails(string invoiceSO)
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == invoiceSO);
                textPONumber.Text = result.InvoicePO;
                textSONumber.Text = result.InvoiceSO;
            }
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
                    dataGridView1.Rows.Add(textSONumber.Text,salesRow.quantity, salesRow.DisplayName);
                }
            }
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                updateRemainingQuantity(i);
                updatePickDB(convertToDB(i));

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
