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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }

        public int convertToInt(string placeholder)
        {
            int number;
            bool success = int.TryParse(placeholder, out number);

            if (success)
            {
                return number;
            }

            else
            {
                return 0;
            }
        }

        public decimal convertToDecimal(string placeholder)
        {
            decimal number;
            bool success = decimal.TryParse(placeholder, out number);

            if (success)
            {
                return number;
            }

            else
            {
                return 0;
            }
        }

        public class KitModel
        {
            public string name;
            public int quantity;
            public decimal salesPrice;
            public int kitID;
            public decimal unitCost;

        }

        public class InventoryModel
        {
            public string name;
            public string description;
            public int quantity;
            public decimal unitCost;
            public decimal totalCost;
            public int productID;
            public decimal salesPrice;
        }

        public InventoryModel GetAllValuesFromForm()
        {
            var prod = new InventoryModel();
            var decimalUnitCost = convertToDecimal(textUnitCost.Text);
            var decimalQuantity = convertToInt(textQuantity.Text);
            prod.name = textProductName.Text;
            prod.description = textProductDescription.Text;
            prod.quantity = convertToInt(textQuantity.Text);
            prod.unitCost = convertToDecimal(textUnitCost.Text);
            prod.totalCost = decimalUnitCost * decimalQuantity;
            prod.salesPrice = convertToDecimal(textSalesPrice.Text);
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
            inputToDB.SalesPrice = placeholder.salesPrice;
            return inputToDB;
        }

        public void updateDB(InventoryModel inven)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory convertedInventory = new Inventory();
                convertedInventory = convertToDB(inven);
                DB.Inventories.Add(convertedInventory);
                DB.SaveChanges();
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

        public void incrementProductID()
        {
            int intID = convertToInt(textProductID.Text);
            intID = intID + 1;
            textProductID.Text = intID.ToString();
        }

        NewInvoiceForm invoiceForm = new NewInvoiceForm();
        NewInventoryForm inventoryForm = new NewInventoryForm();


        private void btnFinish_Click(object sender, EventArgs e)
        {
            var nameFailure = CheckRequired(textProductName.Text);
            var descriptionFailure = CheckRequired(textProductDescription.Text);
            var quantityFailure = CheckRequired(textQuantity.Text);
            var unitCostFailure = CheckRequired(textUnitCost.Text);
            var totalCostFailure = CheckRequired(textTotalCost.Text);
            var salesPriceFailure = CheckRequired(textSalesPrice.Text);

            if ((nameFailure == false) && (descriptionFailure == false) && (quantityFailure == false) && (unitCostFailure == false) && (salesPriceFailure == false))
            {
                textTotalCost.Text = (convertToDecimal(textUnitCost.Text) * convertToInt(textQuantity.Text)).ToString();
                var placeholderValues = GetAllValuesFromForm();
                updateDB(placeholderValues);
                string successBox = "Success";
                MessageBox.Show(successBox);          
                this.Close();
            }

            else
            {
                string errorName = "Error";
                MessageBox.Show(errorName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
