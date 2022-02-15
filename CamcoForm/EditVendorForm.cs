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
    public partial class EditVendorForm : Form
    {
        public EditVendorForm()
        {
            InitializeComponent();
            PopulateCombo();
        }

        private void EditVendorForm_Load(object sender, EventArgs e)
        {

        }

        public class VendorBox
        {
            public int ID;
            public string DisplayName;

            public VendorBox(int pID, string pName)
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
            VendorBox c1 = new VendorBox(1, "Test");
            comboVendor.Items.Add(c1);
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

        public class VendorModel
        {
            public string name;
            public string phoneNumber;
            public string faxNumber;
            public string address;
            public string zipCode;
            public string city;
            public string state;
            public int vendorID;
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
            Vendor.vendorID = Convert.ToInt32(textVendorID.Text);
            Vendor.zipCode = textZip.Text;
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
            inputToDB.VendorFax = placeholder.faxNumber;
            inputToDB.VendorID = placeholder.vendorID;
            return inputToDB;
        }

        public void editDB(VendorModel Vendors)
        {
            using (var DB = new CamcoEntities())
            {
                Vendor result = DB.Vendors.SingleOrDefault(x => x.VendorID == Vendors.vendorID);

                if (result != null)
                {
                    result.VendorName = Vendors.name;
                    result.VendorAddress = Vendors.address;
                    result.VendorCity = Vendors.city;
                    result.VendorZip = Vendors.zipCode;
                    result.VendorState = Vendors.state;
                    result.VendorPhone = Vendors.phoneNumber;
                    result.VendorFax = Vendors.faxNumber;
                    result.VendorID = Vendors.vendorID;
                    DB.SaveChanges();
                }

            }
        }

        public VendorModel fillEditForm(Vendor placeholder)
        {
            VendorModel Vendor = new VendorModel();
            textName.Text = placeholder.VendorName;
            textAddress.Text = placeholder.VendorAddress;
            textCity.Text = placeholder.VendorCity;
            textState.Text = placeholder.VendorState;
            textZip.Text = placeholder.VendorZip;
            textPhone.Text = placeholder.VendorPhone;
            textFax.Text = placeholder.VendorFax;
            textVendorID.Text = placeholder.VendorID.ToString();
            return Vendor;
        }

        public static Vendor retrieveVendorID(int vendorID)
        {
            using (var DB = new CamcoEntities())
            {
                var vend = DB.Vendors.SingleOrDefault(x => x.VendorID == vendorID);
                return vend;
            }
        }



        private void buttonFinish_Click(object sender, EventArgs e)
        {
            var nameFailure = CheckRequired(textName.Text);
            var addressFailure = CheckRequired(textAddress.Text);
            var zipCodeFailure = CheckRequired(textZip.Text);
            var cityFailure = CheckRequired(textCity.Text);
            var stateFailure = CheckRequired(textState.Text);

            if ((nameFailure == false) && (addressFailure == false) && (zipCodeFailure == false) && (cityFailure == false) && (stateFailure == false))
            {
                VendorModel placeholderValues = GetAllValuesFromForm();
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
                //DO SOMETHING //
            }
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VendorBox vb = (VendorBox)comboVendor.SelectedItem;
            var ID = vb.ID;
            var name = vb.DisplayName;

            using (var DB = new CamcoEntities())
            {
                Vendor fullVendor = retrieveVendorID(ID);
                fillEditForm(fullVendor);
            }
        }
    }
}
