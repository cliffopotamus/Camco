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
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
        {
            InitializeComponent();
            /* PopulateCombos(); */
            PopulateCombo();
        }

        public class CustBox
        {
            public int ID;
            public string DisplayName;

            public CustBox (int pID, string pName)
            {
                ID = pID;
                DisplayName = pName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private void PopulateCombo()
        {
            CustBox c1 = new CustBox(3, "Air Cold Supply");
            CustBox c2 = new CustBox(4, "Allied Refrigeration Inc");
            CustBox c3 = new CustBox(6, "American Refrigeration Supplies");

            comboCustomerName.Items.Add(c1);
            comboCustomerName.Items.Add(c2);
            comboCustomerName.Items.Add(c3);

              
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
            public int customerID;

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
            Cust.customerID = Convert.ToInt32(textCustomerID.Text);
            return Cust;
        }

        public void editDB(CustomerModel Cust)
        {
            using (var DB = new CamcoEntities())
            {
                Customer result = DB.Customers.SingleOrDefault(x => x.CustomerID == Cust.customerID);

                if (result != null)
                {
                    result.CustomerName = Cust.name;
                    result.AccountNo = Cust.account;
                    result.CustomerShipAddress = Cust.shippingAddress;
                    result.CustomerShipCity = Cust.shippingCity;
                    result.CustomerShipState = Cust.shippingState;
                    result.CustomerShipZipCode = Cust.shippingZip;
                    result.CustomerBillAddress = Cust.billingAddress;
                    result.CustomerBillCity = Cust.billingCity;
                    result.CustomerBillState = Cust.billingState;
                    result.CustomerBillZipCode = Cust.billingZip;
                    result.CustomerID = Cust.customerID;
                    DB.SaveChanges();
                }
            }       
        }

        /*public void updateDB(CustomerModel Cust)
        {
            using (var DB = new CamcoEntities())
            {
                Customer convertedCustomer = new Customer();
                convertedCustomer = convertToDB(Cust);
                DB.Customers.Add(convertedCustomer);
                DB.SaveChanges();
            }
        }
        */

        public Customer convertToDB(CustomerModel placeholder)
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


        public static Customer RetrieveCustomerID(int custID)
        {
            using (var db = new CamcoEntities())
            {
                var cust = db.Customers.SingleOrDefault(x => x.CustomerID == custID);
                return cust;
            }
        }

        public CustomerModel fillEditForm(Customer placeholder)
        {
            CustomerModel cust = new CustomerModel();
            textCustomerName.Text = placeholder.CustomerName;
            textCustomerShippingAddress.Text = placeholder.CustomerShipAddress;
            textCustomerShippingCity.Text = placeholder.CustomerShipCity;
            textCustomerShippingZip.Text = placeholder.CustomerShipZipCode;
            textCustomerShippingState.Text = placeholder.CustomerShipState;
            textCustomerBillingAddress.Text = placeholder.CustomerShipAddress;
            textCustomerBillingCity.Text = placeholder.CustomerBillCity;
            textCustomerBillingState.Text = placeholder.CustomerBillState;
            textCustomerBillingZipCode.Text = placeholder.CustomerBillZipCode;
            textAccount.Text = placeholder.AccountNo;
            textCustomerID.Text = placeholder.CustomerID.ToString();
            return cust;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet5.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.camcoDataSet5.Customers);
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


            string messageCustomer = "Do you want to edit this customer?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageCustomer, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                if ((nameFailure == false) && (accountFailure == false) && (billingAddressFailure == false) && (billingCityFailure == false) && (billingZipFailure == false) && (billingStateFailure == false) && (shippingAddressFailure == false) && (shippingCityFailure == false) && (shippingZipFailure == false) && (shippingStateFailure == false))
                {
                    CustomerModel placeholderValues = GetAllValuesFromForm();
                    editDB(placeholderValues);



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

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustBox cb = (CustBox)comboCustomerName.SelectedItem;
            var ID = cb.ID;
            var name = cb.DisplayName;

            using (var DB = new CamcoEntities())
            {
               Customer fullCustomer = RetrieveCustomerID(ID);
                fillEditForm(fullCustomer);
            }
        }
    }
}
