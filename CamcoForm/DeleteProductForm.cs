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
    public partial class DeleteProductForm : Form
    {
        public DeleteProductForm()
        {
            InitializeComponent();
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

        private void PopulateCombos()
        {
            InventoryBox c1 = new InventoryBox(1, "FW316");

            comboDeleteProduct.Items.Add(c1);
        }

        public class InventoryModel
        {
            public string name;
            public string description;
            public int quantity;
            public decimal unitCost;
            public decimal totalCost;
            public int productID;
        }

        public InventoryModel setProductID()
        {
            InventoryModel inven = new InventoryModel();
            inven.productID = Convert.ToInt32(textProductID.Text);
            return inven;
        }

        public void deleteDB(InventoryModel placeholderProduct)
        {
            using (var DB = new CamcoEntities())
            {
                List<Inventory> productList = DB.Inventories.Where(x => x.ProductNo == placeholderProduct.productID).ToList();
                DB.Inventories.RemoveRange(productList);
                DB.SaveChanges();
            }
        }

        private void comboDeleteProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryBox ib = (InventoryBox)comboDeleteProduct.SelectedItem;
            var ID = ib.ID;
            var name = ib.DisplayName;
            textProductID.Text = ID.ToString();
        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string messageCustomer = "Do you want to delete this customer?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageCustomer, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                InventoryModel newProductID = setProductID();
                deleteDB(newProductID);
                this.Close();
            }

           if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
