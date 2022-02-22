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
            // TODO: This line of code loads data into the 'camcoInventory.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.camcoInventory.Inventory);
            // TODO: This line of code loads data into the 'camcoInventory.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.camcoInventory.Inventory);

        }

        public class InventoryBox
        {
            public int ID;
            public string DisplayName;

            public InventoryBox(int pID, string pName)
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
            InventoryBox c1 = new InventoryBox(4, "Testing");
            /*comboItem.Items.Add(c1);*/
        }

        public class InventoryModel
        {
            public string name;
            public string description;
            public int quantity;
            public float cost;
            public float totalCost;
            public int productID;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var newForm = new NewProductForm();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
