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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void buttonNewPurchaseOrder_Click(object sender, EventArgs e)
        {
            var newForm = new NewPurchaseForm();
            newForm.Show();
        }
    }
}
