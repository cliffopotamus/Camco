using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CamcoForm
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
     );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            var newForm = new CustomerForm();
            newForm.Show();
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            var newForm = new VendorForm();
            newForm.Show();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            var newForm = new InvoiceForm();
            newForm.Show();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            var newForm = new PurchaseForm();
            newForm.Show();
        }

       /* public CustomerForm GetAllValuesFromForm()
        {
            var firstName = 
        }
    */
    }
}
