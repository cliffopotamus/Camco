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

            if ((nameFailure == false) && (addressFailure == false) && (zipCodeFailure == false) && (cityFailure == false) && (stateFailure == false))
            {
                VendorModel placeholderValues = GetAllValuesFromForm();

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
    }
}
