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
            PopulateCombo();
        }

        private void NewInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet7.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter1.Fill(this.camcoDataSet7.Inventory);
            // TODO: This line of code loads data into the 'realInventory.Inventory' table. You can move, or remove it, as needed.


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
            InventoryBox c1 = new InventoryBox(1, "FW316-1");
            InventoryBox c2 = new InventoryBox(2, "SAEFW10");
            InventoryBox c3 = new InventoryBox(3, "PBit2");
            InventoryBox c4 = new InventoryBox(4, "1box");
            InventoryBox c5 = new InventoryBox(5, "FW12");
            InventoryBox c6 = new InventoryBox(6, "HFN12");
            InventoryBox c7 = new InventoryBox(7, "NLN12");
            InventoryBox c8 = new InventoryBox(8, "SLW12");
            InventoryBox c9 = new InventoryBox(9, "USSFW12");
            InventoryBox c10 = new InventoryBox(10, "FW12-112");
            InventoryBox c11 = new InventoryBox(11, "TB12-112");
            InventoryBox c12 = new InventoryBox(12, "TB12-1");
            InventoryBox c13 = new InventoryBox(13, "MK12-2L");
            InventoryBox c14 = new InventoryBox(14, "TB12-2");
            InventoryBox c15 = new InventoryBox(15, "TB12-34");
            InventoryBox c16 = new InventoryBox(16, "MDrill12");
            InventoryBox c17 = new InventoryBox(17, "Drop-in 14");
            InventoryBox c18 = new InventoryBox(18, "MS14-112");
            InventoryBox c19 = new InventoryBox(19, "MS14-114");
            InventoryBox c20 = new InventoryBox(20, "MS14-1");
            InventoryBox c21 = new InventoryBox(21, "MS14-12");
            InventoryBox c22 = new InventoryBox(22, "MS14-2");
            InventoryBox c23 = new InventoryBox(23, "MS14-34");
            InventoryBox c24 = new InventoryBox(24, "GF1428-45");
            InventoryBox c25 = new InventoryBox(25, "EYELAG14");
            InventoryBox c26 = new InventoryBox(26, "Lags14-3");
            InventoryBox c27 = new InventoryBox(27, "HFN14");
            InventoryBox c28 = new InventoryBox(28, "KLN14");
            InventoryBox c29 = new InventoryBox(29, "Mdrill14");
            InventoryBox c30 = new InventoryBox(30, "SAEFW14");
            InventoryBox c31 = new InventoryBox(31, "SLW14");
            InventoryBox c32 = new InventoryBox(32, "USSFW14");
            InventoryBox c33 = new InventoryBox(33, "RANChor14-1");
            InventoryBox c34 = new InventoryBox(34, "TB14-112");
            InventoryBox c35 = new InventoryBox(35, "MK14-112L");
            InventoryBox c36 = new InventoryBox(36, "BAnchor141");
            InventoryBox c37 = new InventoryBox(37, "FW14-1");
            InventoryBox c38 = new InventoryBox(38, "TB14-1");
            InventoryBox c39 = new InventoryBox(39, "TB14-12");
            InventoryBox c40 = new InventoryBox(40, "TB14-2");
            InventoryBox c41 = new InventoryBox(41, "ToB14-3");
            InventoryBox c42 = new InventoryBox(42, "TB14-34");
            InventoryBox c43 = new InventoryBox(43, "SS5-1420-12");
            InventoryBox c44 = new InventoryBox(44, "SS5-1420-14");
            InventoryBox c45 = new InventoryBox(45, "SS5-1420-34");
            InventoryBox c46 = new InventoryBox(46, "SS5-1420-38");
            InventoryBox c47 = new InventoryBox(47, "GF1428-90");
            InventoryBox c48 = new InventoryBox(48, "SS5-1428-12");
            InventoryBox c49 = new InventoryBox(49, "SS5-1428-14");
            InventoryBox c50 = new InventoryBox(50, "SS5-1428-34");
            InventoryBox c51 = new InventoryBox(51, "SS5-1428-38");
            InventoryBox c52 = new InventoryBox(52, "GF1428ST");
            InventoryBox c53 = new InventoryBox(53, "GF-45");
            InventoryBox c54 = new InventoryBox(54, "GF-90");
            InventoryBox c55 = new InventoryBox(55, "GF-64-01 ST");
            InventoryBox c56 = new InventoryBox(56, "MK-18-112L");
            InventoryBox c57 = new InventoryBox(57, "ZIP10-112");
            InventoryBox c58 = new InventoryBox(58, "Tek10-112");
            InventoryBox c59 = new InventoryBox(59, "ZIP10-114");
            InventoryBox c60 = new InventoryBox(60, "Tek10-114");
            InventoryBox c61 = new InventoryBox(61, "Cpan10-1F");
            InventoryBox c62 = new InventoryBox(62, "Cpan10-1T");
            InventoryBox c63 = new InventoryBox(63, "Tek10-1");
            InventoryBox c64 = new InventoryBox(64, "Zip10-1");
            InventoryBox c65 = new InventoryBox(65, "Pan10-1");
            InventoryBox c66 = new InventoryBox(66, "ZIP10-12");
            InventoryBox c67 = new InventoryBox(67, "PAN1012");
            InventoryBox c68 = new InventoryBox(68, "Tek1012");
            InventoryBox c69 = new InventoryBox(69, "PAN10212");
            InventoryBox c70 = new InventoryBox(70, "ZIP102");
            InventoryBox c71 = new InventoryBox(71, "PAN102");
            InventoryBox c72 = new InventoryBox(72, "ZIP1034");
            InventoryBox c73 = new InventoryBox(73, "PAN1034");
            InventoryBox c74 = new InventoryBox(74, "TEK1034");
            InventoryBox c75 = new InventoryBox(75, "TEK1058");
            InventoryBox c76 = new InventoryBox(76, "TWB100-14");
            InventoryBox c77 = new InventoryBox(77, "TWB100-18");
            InventoryBox c78 = new InventoryBox(78, "TWY100-18");
            InventoryBox c79 = new InventoryBox(79, "TWY100-14");
            InventoryBox c80 = new InventoryBox(80, "1024MSN");
            InventoryBox c81 = new InventoryBox(81, "1024KN");
            InventoryBox c82 = new InventoryBox(82, "1024NC12");
            InventoryBox c83 = new InventoryBox(83, "1024NC14");
            InventoryBox c84 = new InventoryBox(84, "1024NC38");
            InventoryBox c85 = new InventoryBox(85, "1024SAE");
            InventoryBox c86 = new InventoryBox(86, "1024112MS");
            InventoryBox c87 = new InventoryBox(87, "test");
            comboInventory.Items.Add(c1);
            comboInventory.Items.Add(c2);
            comboInventory.Items.Add(c3);
            comboInventory.Items.Add(c4);
            comboInventory.Items.Add(c5);
            comboInventory.Items.Add(c6);
            comboInventory.Items.Add(c7);
            comboInventory.Items.Add(c8);
            comboInventory.Items.Add(c9);
            comboInventory.Items.Add(c10);
            comboInventory.Items.Add(c11);
            comboInventory.Items.Add(c12);
            comboInventory.Items.Add(c13);
            comboInventory.Items.Add(c14);
            comboInventory.Items.Add(c15);
            comboInventory.Items.Add(c16);
            comboInventory.Items.Add(c17);
            comboInventory.Items.Add(c18);
            comboInventory.Items.Add(c19);
            comboInventory.Items.Add(c20);
            comboInventory.Items.Add(c21);
            comboInventory.Items.Add(c22);
            comboInventory.Items.Add(c23);
            comboInventory.Items.Add(c24);
            comboInventory.Items.Add(c25);
            comboInventory.Items.Add(c26);
            comboInventory.Items.Add(c27);
            comboInventory.Items.Add(c28);
            comboInventory.Items.Add(c29);
            comboInventory.Items.Add(c30);
            comboInventory.Items.Add(c31);
            comboInventory.Items.Add(c32);
            comboInventory.Items.Add(c33);
            comboInventory.Items.Add(c34);
            comboInventory.Items.Add(c35);
            comboInventory.Items.Add(c36);
            comboInventory.Items.Add(c37);
            comboInventory.Items.Add(c38);
            comboInventory.Items.Add(c39);
            comboInventory.Items.Add(c40);
            comboInventory.Items.Add(c41);
            comboInventory.Items.Add(c42);
            comboInventory.Items.Add(c43);
            comboInventory.Items.Add(c44);
            comboInventory.Items.Add(c45);
            comboInventory.Items.Add(c46);
            comboInventory.Items.Add(c47);
            comboInventory.Items.Add(c48);
            comboInventory.Items.Add(c49);
            comboInventory.Items.Add(c50);
            comboInventory.Items.Add(c51);
            comboInventory.Items.Add(c52);
            comboInventory.Items.Add(c53);
            comboInventory.Items.Add(c54);
            comboInventory.Items.Add(c55);
            comboInventory.Items.Add(c56);
            comboInventory.Items.Add(c57);
            comboInventory.Items.Add(c58);
            comboInventory.Items.Add(c59);
            comboInventory.Items.Add(c60);
            comboInventory.Items.Add(c61);
            comboInventory.Items.Add(c62);
            comboInventory.Items.Add(c63);
            comboInventory.Items.Add(c64);
            comboInventory.Items.Add(c65);
            comboInventory.Items.Add(c66);
            comboInventory.Items.Add(c67);
            comboInventory.Items.Add(c68);
            comboInventory.Items.Add(c69);
            comboInventory.Items.Add(c70);
            comboInventory.Items.Add(c71);
            comboInventory.Items.Add(c72);
            comboInventory.Items.Add(c73);
            comboInventory.Items.Add(c74);
            comboInventory.Items.Add(c75);
            comboInventory.Items.Add(c76);
            comboInventory.Items.Add(c77);
            comboInventory.Items.Add(c78);
            comboInventory.Items.Add(c79);
            comboInventory.Items.Add(c80);
            comboInventory.Items.Add(c81);
            comboInventory.Items.Add(c82);
            comboInventory.Items.Add(c83);
            comboInventory.Items.Add(c84);
            comboInventory.Items.Add(c85);
            comboInventory.Items.Add(c86);
            comboInventory.Items.Add(c87);
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var newForm = new DeleteProductForm();
            newForm.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var newForm = new EditProductForm();
            newForm.Show();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void inventoryBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
