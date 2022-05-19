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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            bool editMode = false;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet9.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter1.Fill(this.camcoDataSet9.Invoices);
            // TODO: This line of code loads data into the 'camcoInvoices.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.camcoInvoices.Invoices);

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newForm = new NewInvoiceForm();
            newForm.Show();
        }

        private void btnRefreshInvoice_Click(object sender, EventArgs e)
        {
          dataGridView1.Refresh();
        }

        private void btnEnterSO_Click(object sender, EventArgs e)
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textEnterSO.Text);

                if (result != null)
                {
                    NewInvoiceForm frm = new NewInvoiceForm();
                    
                    frm.setAddress(result.CustomerID);
                    frm.setDetails(result.InvoiceSO);
                    frm.editModeBool();
                    /* need to add datagridview rows */
                    using (var DB2 = new CamcoEntities())
                    {
                        int textBoxSO = frm.convertToInt(frm.getSO());
                        /* access InvoiceLineItems DB to add rows to DGV in NewInvoiceForm */
                        List<InvoiceLineItem> result2 = DB.InvoiceLineItems.Where(c => c.InvoiceSO == textBoxSO).ToList();

                        if (result != null)
                        {
                            /* where i used frm.removelinedb */
                            for (int i = 0; i < result2.Count; i++)
                            {
                                var addToDGV = frm.createSalesItem(result2[i].ProductQuantity, result2[i].ProductName);
                                frm.AddRow(addToDGV);
                            }
                        }
                        var newForm = new NewInvoiceForm();
                        frm.Show();
                    }
                }
                else
                {
                    string message = "The SO you have entered is invalid or does not exist.";
                    MessageBox.Show(message);
                }
            }
        }

        private void btnPickInvoice_Click(object sender, EventArgs e)
        {
            PickInvoice newForm = new PickInvoice();
            newForm.setDetails(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.setPO(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            using (var db = new CamcoEntities())
            {
                int textBoxSO = newForm.convertToInt(newForm.getSO());
                List<Picking> result = db.Pickings.Where(x => x.InvoiceSO == textBoxSO).ToList();

                if (result != null)
                {
                    
                    for (int i = 0; i < result.Count; i++)
                    {   
                        var addToDGV = newForm.createSalesItem(result[i].Quantity, result[i].ProductName);
                        newForm.AddRow(addToDGV);
                        newForm.setRemainingDGV(i);
                    }
                }
            }
            newForm.Show();
        }

        private void btnShipInvoice_Click(object sender, EventArgs e)
        {
            ShippingForm newForm = new ShippingForm();
            newForm.setSO(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.setPO(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            using (var DB = new CamcoEntities())
            {
                int textBoxSO = newForm.convertToInt(newForm.getSO());
                List<Shipping> result = DB.Shippings.Where(x => x.InvoiceSO == textBoxSO).ToList();

                if (result != null)
                {
                    for (int i =0; i < result.Count; i++)
                    {
                        newForm.AddRow(i);
                    }
                }
            }
            newForm.Show();
        }
    }
}
