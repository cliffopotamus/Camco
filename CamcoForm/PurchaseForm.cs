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
    }
}
