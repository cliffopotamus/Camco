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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
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

      /* public static List<Customer> RetrieveListAccountID(string accID)
        {
            using (var db = new CamcoEntities())
            {
                List<Customer> custList = db.Customers.Where(x => x.AccountNo == accID).ToList();
                return custList;
            }
        }
        */

        public void deleteDB(CustomerModel Cust)
        {
           /* List<Customer> accIDList = RetrieveListAccountID(Cust.account);*/
            using (var DB = new CamcoEntities())
            {
                /*List<Customer> accIDList = RetrieveListAccountID(Cust.account);
                 Customer delConvertedCustomer = delConvertToDB(accIDList); */
                List<Customer> custList = DB.Customers.Where(x => x.AccountNo == Cust.account).ToList();
                DB.Customers.RemoveRange(custList);
                DB.SaveChanges();
            }
        }

        public CustomerModel getAccIDFromForm()
        {
            CustomerModel cust = new CustomerModel();
            cust.account = textDeleteCustomer.Text;
            return cust;
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string messageCustomer= "Do you want to delete this customer?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageCustomer, title, closeButtons);
           
                if (result == DialogResult.Yes)
                {
                    CustomerModel userAccID = getAccIDFromForm();
                    deleteDB(userAccID);
                }

                if (result == DialogResult.No)
                {
                    this.Close();
                }
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
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

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
