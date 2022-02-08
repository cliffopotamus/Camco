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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        EditCustomerForm newForm = new EditCustomerForm();

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

        public CustomerModel getCustomerIDFromForm()
        {
            CustomerModel cust = new CustomerModel();
            string stringCustomerID = textEditCustomerID.Text;
            int intCustomerID = int.Parse(stringCustomerID);
            cust.customerID = intCustomerID;
            return cust;
        }


        public static Customer RetrieveCustomerID(int custID)
        {
            using (var db = new CamcoEntities())
            {
                Customer cust = db.Customers.SingleOrDefault(x => x.CustomerID == custID);
                return cust;
            }
        }

        public void editDB(CustomerModel Cust)
        {
            using (var DB = new CamcoEntities())
            {
                Customer cust = DB.Customers.SingleOrDefault(x => x.CustomerID == Cust.customerID);
                
                
                
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string messageCustomer = "Do you want to edit this customer?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageCustomer, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                CustomerModel customerID = getCustomerIDFromForm();
                newForm.Show();


            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
    
}
