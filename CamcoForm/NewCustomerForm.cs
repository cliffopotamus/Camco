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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void BtnCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelZipCode_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCustomerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        public bool CheckRequired(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonFinishCustomer_Click(object sender, EventArgs e)
        {

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


        public CustomerModel GetAllValuesFromForm()
        {
            var Cust = new CustomerModel();
            Cust.name = textCustomerName.Text;
            Cust.account = textAccount.Text;
            Cust.billingAddress = textCustomerBillingAddress.Text;
            Cust.billingCity = textCustomerBillingCity.Text;
            Cust.billingZip = textCustomerBillingZipCode.Text;
            Cust.billingState = textCustomerBillingState.Text;
            Cust.shippingAddress = textCustomerShippingAddress.Text;
            Cust.shippingCity = textCustomerShippingCity.Text;
            Cust.shippingZip = textCustomerShippingZip.Text;
            Cust.shippingState = textCustomerShippingState.Text;
            return Cust;
        }

        public void updateDB(CustomerModel Cust)
        {
            using (var DB = new CamcoEntities())
            {
                Customer convertedCustomer = new Customer();
                convertedCustomer = convertToDB(Cust);
                DB.Customers.Add(convertedCustomer);
                DB.SaveChanges();
            }
        }
        public static List<Customer> RetrieveListAccountID(string accID)
        {
            using (var db = new CamcoEntities())
            {
                List<Customer> cust = db.Customers.Where(x => x.AccountNo == accID).ToList();
                return cust;
            }
        }

        public void deleteDB(CustomerModel Cust )
        {
            using (var DB = new CamcoEntities())
            {
                var accIDList = RetrieveListAccountID(Cust.account);
                DB.Customers.RemoveRange(accIDList);
                DB.SaveChanges();
            }
        }

        public  Customer convertToDB(CustomerModel placeholder)
        {
            var inputToDB = new Customer();
            inputToDB.CustomerName = placeholder.name;
            inputToDB.CustomerBillAddress = placeholder.billingAddress;
            inputToDB.CustomerBillCity = placeholder.billingCity;
            inputToDB.CustomerBillZipCode = placeholder.billingZip;
            inputToDB.CustomerBillState = placeholder.billingState;
            inputToDB.CustomerShipAddress = placeholder.shippingAddress;
            inputToDB.CustomerShipCity = placeholder.shippingCity;
            inputToDB.CustomerShipZipCode = placeholder.shippingZip;
            inputToDB.CustomerShipState = placeholder.shippingState;
            inputToDB.AccountNo = placeholder.account;
            return inputToDB;
        }
        

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            var nameFailure = CheckRequired(textCustomerName.Text);
            var accountFailure = CheckRequired(textAccount.Text);
            var billingAddressFailure = CheckRequired(textCustomerBillingAddress.Text);
            var billingCityFailure = CheckRequired(textCustomerBillingCity.Text);
            var billingZipFailure = CheckRequired(textCustomerBillingZipCode.Text);
            var billingStateFailure = CheckRequired(textCustomerBillingState.Text);
            var shippingAddressFailure = CheckRequired(textCustomerShippingAddress.Text);
            var shippingCityFailure = CheckRequired(textShippingCity.Text);
            var shippingZipFailure = CheckRequired(textCustomerShippingZip.Text);
            var shippingStateFailure = CheckRequired(textCustomerShippingState.Text);


            if ((nameFailure == false) && (accountFailure == false) && (billingAddressFailure == false) && (billingCityFailure == false) && (billingZipFailure == false) && (billingStateFailure == false) && (shippingAddressFailure == false) && (shippingCityFailure == false) && (shippingZipFailure == false) && (shippingStateFailure == false))
            {
                var placeholderValues = GetAllValuesFromForm();
                updateDB(placeholderValues);
                string successBox = "Success";
                MessageBox.Show(successBox);
                this.Close();
            }

            else
            {
                string errorName = "Error";
                MessageBox.Show(errorName);
            }

          
    }


        }
    }




