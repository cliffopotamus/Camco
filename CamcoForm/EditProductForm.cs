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
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();
            PopulateCombos();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realInventory.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.realInventory.Inventory);

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

            comboProduct.Items.Add(c1);
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

        public InventoryModel GetAllValuesFromForm()
        {
            var prod = new InventoryModel();
            prod.name = textProductName.Text;
            prod.description = textProductDescription.Text;
            prod.quantity = Convert.ToInt32(textQuantity.Text);
            prod.unitCost = Convert.ToDecimal(textUnitCost.Text);
            prod.totalCost = Convert.ToDecimal((Convert.ToDecimal(textUnitCost.Text)) * (Convert.ToDecimal(textQuantity.Text)));
            return prod;
        }

        public Inventory convertToDB(InventoryModel placeholder)
        {
            var inputToDB = new Inventory();
            inputToDB.ProductName = placeholder.name;
            inputToDB.ProductDescription = placeholder.description;
            inputToDB.ProductQuantity = placeholder.quantity;
            inputToDB.UnitCost = placeholder.unitCost;
            inputToDB.TotalCost = placeholder.totalCost;
            return inputToDB;
        }

        public void editDB(InventoryModel Inven)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductNo == Inven.productID);

                if (result != null)
                {
                    result.ProductName = Inven.name;
                    result.ProductDescription = Inven.description;
                    result.ProductQuantity = Inven.quantity;
                    result.ProductNo = Inven.productID;
                    result.UnitCost = Inven.unitCost;
                    result.TotalCost = Inven.totalCost;
                    DB.SaveChanges();
                }
            }
        }

        public InventoryModel fillEditForm(Inventory placeholder)
        {
            InventoryModel inven = new InventoryModel();
            textProductName.Text = placeholder.ProductName;
            textProductDescription.Text = placeholder.ProductDescription;
            textQuantity.Text = placeholder.ProductQuantity.ToString();
            textUnitCost.Text = placeholder.UnitCost.ToString();
            textTotalCost.Text = placeholder.TotalCost.ToString();
            return inven;
        }

        public static Inventory RetrieveProductID(int productID)
        {
            using (var DB = new CamcoEntities())
            {
                var inven = DB.Inventories.SingleOrDefault(x => x.ProductNo == productID);
                return inven;
            }
        }

        public bool CheckRequired(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            var nameFailure = CheckRequired(textProductName.Text);
            var descriptionFailure = CheckRequired(textProductDescription.Text);
            var quantityFailure = CheckRequired(textQuantity.Text);
            var unitCostFailure = CheckRequired(textUnitCost.Text);

            string message = "Do you want to edit this product?";
            string title = "Close Window";
            MessageBoxButtons closeButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, closeButtons);

            if (result == DialogResult.Yes)
            {
                if ((nameFailure == false) && (descriptionFailure == false) && (quantityFailure == false) && (unitCostFailure == false))
                {
                    InventoryModel placeholderValues = GetAllValuesFromForm();
                    editDB(placeholderValues);
                    string successBox = textUnitCost.Text;
                    MessageBox.Show(successBox);
                    this.Close();
                }

                else
                {
                    string errorName = "Error";
                    MessageBox.Show(errorName);
                }
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryBox ib = (InventoryBox)comboProduct.SelectedItem;
            var ID = ib.ID;
            var name = ib.DisplayName;

            using (var DB = new CamcoEntities())
            {
                Inventory fullInventory = RetrieveProductID(ID);
                fillEditForm(fullInventory);
            }
        }
    }
    }

