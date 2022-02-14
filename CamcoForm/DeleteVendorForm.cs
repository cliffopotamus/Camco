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
    public partial class DeleteVendorForm : Form
    {
        public DeleteVendorForm()
        {
            InitializeComponent();
        }

        public class VendorModel
        {
            public string name;
            public string phoneNumber;
            public string faxNumber;
            public string address;
            public string zipCode;
            public string city;
            public string state;
            public string accountNo;
        }

        public VendorModel getAccIDFromForm()
        {
            VendorModel Vendors = new VendorModel();
            Vendors.accountNo = textDeleteVendor.Text;
            return Vendors;
        }

        public void deleteDB(VendorModel placeholderVendors)
        {
            using (var DB = new CamcoEntities())
            {
                List<Vendor> vendorList = DB.Vendors.Where(x => x.VendorAccountNo == placeholderVendors.accountNo).ToList();
                DB.Vendors.RemoveRange(vendorList);
                DB.SaveChanges();
            }
        }

        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            string messageCustomer = "Do you want to delete this customer?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageCustomer, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                VendorModel userAccID = getAccIDFromForm();
                deleteDB(userAccID);
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DeleteVendorForm_Load(object sender, EventArgs e)
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
    }
}
