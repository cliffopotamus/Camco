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
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet9.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter1.Fill(this.camcoDataSet9.Invoices);
            // TODO: This line of code loads data into the 'camcoInvoices.Invoices' table. You can move, or remove it, as needed.
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newForm = new NewInvoiceForm();
            newForm.Show();
        }

        private void btnRefreshInvoice_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEnterSO_Click(object sender, EventArgs e)
        {
            NewInvoiceForm newForm = new NewInvoiceForm();
            int textBoxSO = convertToInt(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            using (var DB = new CamcoEntities())
            {
                string stringSO = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Invoice invoiceResult = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == stringSO);

                if (invoiceResult != null)
                {
                    newForm.setAddress(invoiceResult.CustomerID);
                    newForm.setDetails(stringSO);
                    newForm.editModeBool();

                    List<InvoiceLineItem> lineResult = DB.InvoiceLineItems.Where(x => x.InvoiceSO == textBoxSO).ToList();

                    if (lineResult != null)
                    {
                        for (int i = 0; i < lineResult.Count; i++)
                        {
                            var addToDGV = newForm.createSalesItem(lineResult[i].ProductQuantity, lineResult[i].ProductName);
                            newForm.addExistingRow(addToDGV, i);
                        }
                    }
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
                        newForm.setProductDescription(i);
                        newForm.setProductPickID(i);
                        newForm.setProductPrice(i);
                        newForm.setKitDescription(i);
                    }
                }

                else
                {
                    string error = "Error: invalid invoice selected.";
                    MessageBox.Show(error);
                }
            }
            newForm.Show();
        }

        private void btnShipInvoice_Click(object sender, EventArgs e)
        {
            ShippingForm newForm = new ShippingForm();
            newForm.setSO(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            newForm.setPO(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            newForm.setCustomerID();
            newForm.editRichBill();
            newForm.editRichShip();
            

            using (var DB = new CamcoEntities())
            {
                int textBoxSO = newForm.convertToInt(newForm.getSO());
                List<Shipping> result = DB.Shippings.Where(x => x.InvoiceSO == textBoxSO).ToList();

                if (result != null)
                {
                    for (int i =0; i < result.Count; i++)
                    {
                        newForm.AddRow(i);
                        newForm.setKitDescription(i);
                    }
                }

                else
                {
                    string error = "Error: invalid invoice selected.";
                    MessageBox.Show(error);
                }
            }
            newForm.Show();
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

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string confirmation = "Are you sure you want to delete this invoice and all records?";
            string title = "Delete Invoice";
            MessageBoxButtons delete = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(confirmation, title, delete);

            if (dialog == DialogResult.Yes)
            {
                using (var DB = new CamcoEntities())
                {
                    string stringSO = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    Invoice invoiceResult = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == stringSO);

                    if (invoiceResult != null)
                    {
                        DB.Invoices.Remove(invoiceResult);
                        DB.SaveChanges();
                    }

                    int textSO = convertToInt(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    List<InvoiceLineItem> invoiceLineItemsResult = DB.InvoiceLineItems.Where(x => x.InvoiceSO == textSO).ToList();

                    if (invoiceLineItemsResult != null)
                    {
                        for (int i = 0; i < invoiceLineItemsResult.Count; i++)
                        {
                            DB.InvoiceLineItems.Remove(invoiceLineItemsResult[i]);
                        }
                    }

                    List<Picking> pickingResult = DB.Pickings.Where(x => x.InvoiceSO == textSO).ToList();

                    if (pickingResult != null)
                    {
                        for (int i = 0; i < pickingResult.Count; i++)
                        {
                            DB.Pickings.Remove(pickingResult[i]);
                            DB.SaveChanges();
                        }
                    }

                    List<Shipping> shippingResult = DB.Shippings.Where(x => x.InvoiceSO == textSO).ToList();

                    if (shippingResult != null)
                    {
                        for (int i = 0; i < shippingResult.Count; i++)
                        {
                            DB.Shippings.Remove(shippingResult[i]);
                            DB.SaveChanges();
                        }
                    }

                    List<ShipLineItem> shipLine = DB.ShipLineItems.Where(x => x.InvoiceSO == dataGridView1.CurrentRow.Cells[5].Value.ToString()).ToList();

                    if (shipLine != null)
                    {
                        for (int i = 0; i < shippingResult.Count; i++)
                        {
                            DB.ShipLineItems.Remove(shipLine[i]);
                            DB.SaveChanges();
                        }
                    }
                }
            }

            else
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpenInvoice_Click(object sender, EventArgs e)
        {
            NewInvoiceForm newForm = new NewInvoiceForm();
            int textBoxSO = convertToInt(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            using (var DB = new CamcoEntities())
            {
                string stringSO = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Invoice invoiceResult = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == stringSO);

                if (invoiceResult != null)
                {
                    newForm.setAddress(invoiceResult.CustomerID);
                    newForm.setDetails(stringSO);
                    newForm.editModeBool();

                    List<InvoiceLineItem> lineResult = DB.InvoiceLineItems.Where(x => x.InvoiceSO == textBoxSO).ToList();

                    if (lineResult != null)
                    {
                        for (int i = 0; i < lineResult.Count; i++)
                        {
                            var addToDGV = newForm.createSalesItem(lineResult[i].ProductQuantity, lineResult[i].ProductName);
                            newForm.addExistingRow(addToDGV, i);
                            newForm.setTotalPrice(i);
                        }
                    }
                }
            }
            newForm.Show();
        }

        private void btnShippedInvoice_Click(object sender, EventArgs e)
        {
            this.invoicesTableAdapter1.Fill(this.camcoDataSet9.Invoices);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            NewInventoryForm newForm = new NewInventoryForm();
            newForm.Show();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            PurchaseForm newform = new PurchaseForm();
            newform.Show();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            VendorForm newForm = new VendorForm();
            newForm.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            newForm.Show();
        }
    }
}
