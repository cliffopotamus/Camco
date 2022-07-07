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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void buttonNewPurchaseOrder_Click(object sender, EventArgs e)
        {
            var newForm = new NewPurchaseForm();
            newForm.Show();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet12.PurchaseOrder' table. You can move, or remove it, as needed.
            this.purchaseOrderTableAdapter.Fill(this.camcoDataSet12.PurchaseOrder);

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

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            ReceiveOrderForm newForm = new ReceiveOrderForm();
            newForm.setDetails(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.setPO(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            

            using (var DB = new CamcoEntities())
            {
                string textSO = newForm.getSO();
                List<Receiving> result = DB.Receivings.Where(x => x.PurchaseSO == textSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        var addToDGV = newForm.createSalesItem((int)result[i].Quantity, result[i].ProductName);
                        newForm.AddRow(addToDGV);
                        newForm.setRemainingDGV(i);
                        newForm.setProductReceivedID(i);
                        newForm.setProductDescription(i);
                    }
                }
            }
            newForm.Show();
        }

        private void btnOpenPurchaseOrder_Click(object sender, EventArgs e)
        {
            NewPurchaseForm newForm = new NewPurchaseForm();
            newForm.setPurchaseSO(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.editModeBool();

            using (var DB = new CamcoEntities())
            {

                string textSO = newForm.getPurchaseSO();
                List<Receiving> result = DB.Receivings.Where(x => x.PurchaseSO == textSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        var addToDGV = newForm.createSalesItem((int)result[i].Quantity, result[i].ProductName);
                        newForm.AddRow(addToDGV);
                    }
                    newForm.Show();
                }
                
                else
                {
                    string error = "No SO available.";
                    MessageBox.Show(error);
                       
                }
            }
                
        }

        private void btnReceivedOrder_Click(object sender, EventArgs e)
        {
            ReceivedForm newForm = new ReceivedForm();
            newForm.setSO(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.setPO(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            newForm.setCustomerID();
            newForm.editPurchaseTotal();

            using (var DB = new CamcoEntities())
            {
                string textBoxSO = newForm.getSO();
                List<Received> result = DB.Receiveds.Where(x => x.PurchaseSO == textBoxSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        newForm.AddRow(i);
                    }
                }
            }
            newForm.Show();
        }

        private void btnDeletePO_Click(object sender, EventArgs e)
        {
            using (var DB = new CamcoEntities())
            {
                string stringSO = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                PurchaseOrder purchaseResult = DB.PurchaseOrders.SingleOrDefault(x => x.PurchaseSO == stringSO);

                if (purchaseResult != null)
                {
                    DB.PurchaseOrders.Remove(purchaseResult);
                    DB.SaveChanges();
                }

                int textSO = convertToInt(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                List<PurchaseOrderLineItem> purchaseLineItemsResult = DB.PurchaseOrderLineItems.Where(x => x.PurchaseSO == stringSO).ToList();

                if (purchaseLineItemsResult != null)
                {
                    for (int i = 0; i < purchaseLineItemsResult.Count; i++)
                    {
                        DB.PurchaseOrderLineItems.Remove(purchaseLineItemsResult[i]);
                    }
                }

                List<Receiving> receivingResult = DB.Receivings.Where(x => x.PurchaseSO == stringSO).ToList();

                if (receivingResult != null)
                {
                    for (int i = 0; i < receivingResult.Count; i++)
                    {
                        DB.Receivings.Remove(receivingResult[i]);
                        DB.SaveChanges();
                    }
                }

                List<Received> receivedResult = DB.Receiveds.Where(x => x.PurchaseSO == stringSO).ToList();

                if (receivedResult != null)
                {
                    for (int i = 0; i < receivedResult.Count; i++)
                    {
                        DB.Receiveds.Remove(receivedResult[i]);
                        DB.SaveChanges();
                    }
                }
            }
        }
    }
}
