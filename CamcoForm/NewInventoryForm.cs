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
    public partial class NewInventoryForm : Form
    {
        public NewInventoryForm()
        {
            InitializeComponent();
        }

        private void NewInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboBoxItems.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.comboBoxItems.Inventory);

        }

        private void btnBillOfMaterials_Click(object sender, EventArgs e)
        {
            var newForm = new BillOfMaterialsForm();
            newForm.Show();
        }

        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            var newForm = new WorkOrderForm();
            newForm.Show();
        }
    }
}
