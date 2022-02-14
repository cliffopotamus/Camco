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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoCustomers5.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.camcoCustomers5.Customers);


        }

        public static List<Customer> RetrieveListAccountID(string accID)
        {
            using (var db = new CamcoEntities())
            {
                List<Customer> cust = db.Customers.Where(x => x.AccountNo == accID).ToList();
                return cust;
            }
        }

        public class CustomerModel
        {
            public string name;
            public string account;
            public string billingAddress;
            public string billingCity;
            public string billingZip;
            public string billingState;
            public string shippingAddress;
            public string shippingCity;
            public string shippingState;
            public string shippingZip;
        }

        public void deleteDB(CustomerModel Cust)
        {
            using (var DB = new CamcoEntities())
            {
                var accIDList = RetrieveListAccountID(Cust.account);
                DB.Customers.RemoveRange(accIDList);
                DB.SaveChanges();
                this.customersTableAdapter.Fill(this.camcoCustomers5.Customers);
            }
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm newForm = new NewCustomerForm();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var newForm = new DeleteCustomer();
            newForm.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomerForm newForm = new EditCustomerForm();
            newForm.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            var newForm = new VendorForm();
            newForm.Show();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            var newForm = new InvoiceForm();
            newForm.Show();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            var newForm = new PurchaseForm();
            newForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
