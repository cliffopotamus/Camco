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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoVendors.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.camcoVendors.Vendors);


        }

        private void BtnNewVendor_Click(object sender, EventArgs e)
        {
            var newForm = new NewVendorForm();
            newForm.Show();
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEditVendor_Click(object sender, EventArgs e)
        {
            var newForm = new EditVendorForm();
            newForm.Show();
        }

        private void BtnDeleteVendor_Click(object sender, EventArgs e)
        {
            var newForm = new DeleteVendorForm();
            newForm.Show();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            NewInventoryForm newform = new NewInventoryForm();
            newform.Show();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            PurchaseForm newForm = new PurchaseForm();
            newForm.Show();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            InvoiceForm newForm = new InvoiceForm();
            newForm.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            newForm.Show();
        }
    }
}
