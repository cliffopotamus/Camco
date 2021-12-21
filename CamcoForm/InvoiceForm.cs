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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoInvoices.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.camcoInvoices.Invoices);

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newForm = new NewInvoiceForm();
            newForm.Show();
        }
    }
}
