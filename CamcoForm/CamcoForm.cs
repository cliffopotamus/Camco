using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CamcoForm
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
     );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            var newForm = new CustomerForm();
            newForm.Show();
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

        /* public NewCustomerForm GetAllValuesFromForm()
         {
             var custName = textCustomerName.Text;
             var custPhoneNumber = textPhone.Text;
             var custFaxNumber = textFax.Text;
             var custAccountNo = textAccount.Text;
             var custBillingAddress = textBillingAddress.Text;
             var custBillingZipCode = textBillingZipCode.Text;
             var custBillingState = textBillingState.Text;
             var custShippingAddress = textCustomerShippingAddress.Text;
             var custShippingZipCode = textCustomerShippingZip.Text;
             var custShippingState = textCustomerShippingState.Text;

             var cust = new Customer(custName, custPhoneNumber, custFaxNumber, custAccountNo, custBillingAddress, custBillingZipCode, custBillingState, custShippingAddress, custShippingZipCode, custShippingState);
             return cust;
         }

        */
        public void updateDB()
        {
            using (var DB = new CamcoEntities())
            {
                /* DB.Customers.Add() */
                var Cust = new Customer();

            }
        }




        public bool CheckRequired(string text)
        {
            bool success = true;
            if (string.IsNullOrWhiteSpace(text))
            {
                success = false;
                return success;
            }
            else
            {
                return success;
            }



        }

        public static Customer RetrieveCustomerID(int custID)
        {
            using (var db = new CamcoEntities())
            {
                var cust = db.Customers.SingleOrDefault(x => x.CustomerID == custID);
                return cust;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var testingButton = RetrieveListAccountID("C20");
            var testingButton2 = RetrieveListAccountID("C10");
        }

        public static List<Customer> RetrieveListAccountID(string accID)
        {
            using (var db = new CamcoEntities())
            {
                List<Customer> cust = db.Customers.Where(x => x.AccountNo == accID).ToList();
                return cust;
            }
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            var newForm = new NewInventoryForm();
            newForm.Show();
        }
    }
}
