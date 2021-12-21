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
    public partial class NewInvoiceForm : Form
    {
        public NewInvoiceForm()
        {
            InitializeComponent();
        }

        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboBoxItems.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.comboBoxItems.Inventory);
            // TODO: This line of code loads data into the 'customerNameList.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerNameList.Customers);

        }
    }
}
