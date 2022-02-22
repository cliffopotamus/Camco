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
    public partial class NewVendorForm : Form
    {
        public NewVendorForm()
        {
            InitializeComponent();
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

        public VendorModel GetAllValuesFromForm()
        {
            VendorModel Vendor = new VendorModel();
            Vendor.name = textName.Text;
            Vendor.phoneNumber = textPhone.Text;
            Vendor.faxNumber = textFax.Text;
            Vendor.address = textAddress.Text;
            Vendor.city = textCity.Text;
            Vendor.state = textState.Text;
            return Vendor;
        }

        public Vendor convertToDB(VendorModel placeholder)
        {
            Vendor inputToDB = new Vendor();
            inputToDB.VendorName = placeholder.name;
            inputToDB.VendorAddress = placeholder.address;
            inputToDB.VendorCity = placeholder.city;
            inputToDB.VendorZip = placeholder.zipCode;
            inputToDB.VendorState = placeholder.state;
            inputToDB.VendorPhone = placeholder.phoneNumber;
           /* inputToDB.VendorFax = placeholder.faxNumber;*/
            return inputToDB;
        }

        public void updateDB(VendorModel Vendors)
        {
            using (var DB = new CamcoEntities())
            {
                Vendor convertedVendor = new Vendor();
                convertedVendor = convertToDB(Vendors);
                DB.Vendors.Add(convertedVendor);
                DB.SaveChanges();
            }
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
        }

        private void labelFinish_Click(object sender, EventArgs e)
        {
            var nameFailure = CheckRequired(textName.Text);
            var addressFailure = CheckRequired(textAddress.Text);
            var zipCodeFailure = CheckRequired(textZip.Text);
            var cityFailure = CheckRequired(textCity.Text);
            var stateFailure = CheckRequired(textState.Text);
            var accountNoFailure = CheckRequired(textAccountNo.Text);

            if ((nameFailure == false) && (addressFailure == false) && (zipCodeFailure == false) && (cityFailure == false) && (stateFailure == false) && (accountNoFailure == false))
            {
                VendorModel placeholderValues = GetAllValuesFromForm();
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

        private void labelCancel_Click(object sender, EventArgs e)
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
                //DO SOMETHING //
            }
            
        }

        private void NewVendorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoVendors.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.camcoVendors.Vendors);

        }
    }
}
