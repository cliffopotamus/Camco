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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoVendors.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.camcoVendors.Vendors);

        }

        private void BtnNewVendor_Click(object sender, EventArgs e)
        {
            var newForm = new NewVendorForm();
            newForm.Show();
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            var newForm = new VendorForm();
            newForm.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            
        }
    }
}
