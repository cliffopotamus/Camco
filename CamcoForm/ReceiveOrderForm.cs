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
    public partial class ReceiveOrderForm : Form
    {
        public ReceiveOrderForm()
        {
            InitializeComponent();
        }

        public class ReceivingModel
        {
            public int ReceiveID;
            public string PurchaseSO;
            public string PurchasePO;
            public int VendorID;
            public int Quantity;
            public int QuantityReceived;
            public int QuantityRemaining;
            public DateTime DateScheduled;
            public bool Finished;
        }

        private const int ColQuantReceive = 4;
        private const int ColQuantRemain = 5;

        private bool editQuantity(int quantity)
        {
            return true;
        }

        public bool ValidateCell(DataGridViewCellValidatingEventArgs e)
        {
            bool result = true;

            switch (e.ColumnIndex)
            {
                case ColQuantReceive:
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

        public void setRemainingDGV(int i)
        {
            using (var DB = new CamcoEntities())
            {
                List<Receiving> result = DB.Receivings.Where(x => x.PurchaseSO == textSO.Text).ToList();

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

        public void setDetails(string purchaseSO)
        {
            using (var DB = new CamcoEntities())
            {
                PurchaseOrder result = DB.PurchaseOrders.SingleOrDefault(x => x.PurchaseSO == purchaseSO);
                textPO.Text = result.PurchasePO;
                textSO.Text = result.PurchaseSO;
            }
        }

        public string getPO()
        {
            return textPO.Text;
        }

        public void setPO(string placeholder)
        {
            textPO.Text = placeholder;
        }



        public string getSO()
        {
            return textSO.Text;
        }

        public void setSO(string placeholder)
        {
            textSO.Text = placeholder;
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
                    dataGridView1.Rows.Add(textSO.Text, textPO.Text, salesRow.quantity, salesRow.DisplayName);
                }
            }
        }

        public Receiving convertReceivingToDB(int i)
        {
            Receiving placeholder = new Receiving();
            placeholder.PurchaseSO = textSO.Text;
            placeholder.PurchasePO = textPO.Text;
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.QuantityReceived = convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.Finished = Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value);
            placeholder.DateScheduled = DateTime.Today;

            if (placeholder.Finished == true)
            {
                placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());

            }
            return placeholder;
        }

        public Receiving convertNullReceivingToDB(int i)
        {
            Receiving placeholder = new Receiving();
            placeholder.PurchaseSO = textSO.Text;
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.PurchasePO = textPO.Text;
            placeholder.DateScheduled = DateTime.Today;
            return placeholder;
        }

        public void updateInventory(Receiving placeholder)
        {
            if (placeholder.Finished == true)
            {
                int addToInventory = (int)placeholder.QuantityReceived;

                using (var DB = new CamcoEntities())
                {

                    Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == placeholder.ProductName);

                    if (result != null)
                    {
                        result.ProductQuantity = result.ProductQuantity + addToInventory;
                        DB.SaveChanges();
                    }
                }
            }

            else
            {

            }
        }

        public void updateReceivingDB(Receiving placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                DB.Receivings.Add(placeholder);
                DB.SaveChanges();
            }
        }

        public void removeReceivingDB()
        {
            using (var DB = new CamcoEntities())
            {
                List<Receiving> result = DB.Receivings.Where(x => x.PurchaseSO == textSO.Text).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        DB.Receivings.Remove(result[i]);
                        DB.SaveChanges();
                    }
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

        private void ReceiveOrderForm_Load(object sender, EventArgs e)
        {

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

        private void btnCommit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value == null)
                {
                    var placeholder = convertNullReceivingToDB(i);
                    updateReceivingDB(placeholder);
                }

                else
                {
                    var placeholder = convertReceivingToDB(i);

                    if (placeholder.Finished == true)
                    {
                        removeReceivingDB();
                        updateReceivingDB(placeholder);
                        updateInventory(placeholder);
                    }

                    else
                    {
                        removeReceivingDB();
                        updateReceivingDB(placeholder);
                    }

                }
            }
        }
    }
}
