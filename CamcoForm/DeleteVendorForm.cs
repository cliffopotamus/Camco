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
            PopulateCombo();
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
            VendorBox c1 = new VendorBox(4, "Testing");
            VendorBox c2 = new VendorBox(5, "test2");
            comboDeleteVendor.Items.Add(c1);
            comboDeleteVendor.Items.Add(c2);
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

        public static Vendor retrieveVendorID(int vendorID)
        {
            using (var DB = new CamcoEntities())
            {
                var vendors = DB.Vendors.SingleOrDefault(x => x.VendorID == vendorID);
                return vendors;
            }
        }

        public VendorModel fillVendorID(Vendor placeholder)
        {
            VendorModel vend = new VendorModel();
            textVendorID.Text = placeholder.VendorID.ToString();
            return vend;
        }

        public VendorModel setVendorID()
        {
            VendorModel vend = new VendorModel();
            vend.vendorID = Convert.ToInt32(textVendorID.Text);
            return vend;
        }

        public void deleteDB(VendorModel placeholderVendors)
        {
            using (var DB = new CamcoEntities())
            {
                List<Vendor> vendorList = DB.Vendors.Where(x => x.VendorID == placeholderVendors.vendorID).ToList();
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
                VendorModel newVendorID = setVendorID();
                deleteDB(newVendorID);
                this.Close();
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DeleteVendorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoVendors.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.camcoVendors.Vendors);

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

        private void comboDeleteVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VendorBox vb = (VendorBox)comboDeleteVendor.SelectedItem;
            var ID = vb.ID;
            var name = vb.DisplayName;
            textVendorID.Text = ID.ToString();
        }
    }
}
