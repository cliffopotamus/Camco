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
    public partial class GenerateInvoiceForm : Form
    {
        public GenerateInvoiceForm()
        {
            InitializeComponent();
        }

        private void GenerateInvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generatedInvoiceDataset.GeneratedInvoice' table. You can move, or remove it, as needed.
            this.generatedInvoiceTableAdapter.Fill(this.generatedInvoiceDataset.GeneratedInvoice);

        }

        
    }
}
