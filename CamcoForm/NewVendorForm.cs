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

        private void labelFinish_Click(object sender, EventArgs e)
        {
            string message = "Customer has been added to the database.";


            MessageBox.Show(message);
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
