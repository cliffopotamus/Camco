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
    public partial class ShippingForm : Form
    {
        public ShippingForm()
        {
            InitializeComponent();
            textInvoiceTotal.Text = "0";
        }

        private void ShippingForm_Load(object sender, EventArgs e)
        {
            calculateInvoiceTotal();
        }

        public class InvoiceModel
        {
            public int shipInvoiceID;
            public string invoiceNumber;
            public string invoiceSO;
            public string invoicePO;
            public string productName;
            public string productDescription;
            public int quantity;
            public decimal salesPrice;
            public decimal productExtension;
        }

        public class ShipLineItems
        {
            public int invoiceID;
            public string invoiceNumber;
            public string invoiceSO;
            public string invoicePO;
            public int quantity;
            public string productName;
            public string productDescription;
            public int quantityPicked;
            public int quantityRemaining;
            public decimal salesPrice;
            public decimal productExtension;
            public DateTime dateScheduled;
            public bool invoice;
            public string kit;
        }

        public ShipLineItem convertShipToShipLine(int i)
        {
            ShipLineItem shipLine = new ShipLineItem();
            shipLine.InvoiceNumber = textInvoiceNumber.Text;
            shipLine.InvoiceSO = textInvoiceSO.Text;
            shipLine.InvoicePO = textInvoicePO.Text;
            shipLine.ProductName = dataGridView1.Rows[i].Cells["ProductName"].Value.ToString();
            shipLine.ProductDescription = dataGridView1.Rows[i].Cells["ProductDescription"].Value.ToString();
            shipLine.Quantity = convertToInt(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
            shipLine.QuantityPicked = convertToInt(dataGridView1.Rows[i].Cells["QuantityPicked"].Value.ToString());
            shipLine.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells["QuantityRemaining"].Value.ToString());
            shipLine.SalesPrice = convertToDecimal(dataGridView1.Rows[i].Cells["ProductPrice"].Value.ToString());
            shipLine.ProductExtension = shipLine.SalesPrice * shipLine.QuantityPicked;
            shipLine.invoice = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Invoice"].Value);
            shipLine.DateScheduled = DateTime.Today;
            if (dataGridView1.Rows[i].Cells["Kit"].Value != null)
            {
                shipLine.Kit = dataGridView1.Rows[i].Cells["Kit"].Value.ToString();
            }
            return shipLine;
        }

        public ShipInvoice convertShipToInvoice(int i)
        {
            ShipInvoice newInvoice = new ShipInvoice();
            newInvoice.InvoiceNumber = convertToInt(textInvoiceNumber.Text);
            newInvoice.InvoiceSO = textInvoiceSO.Text;
            newInvoice.InvoicePO = textInvoicePO.Text;
            newInvoice.ProductDescription = dataGridView1.Rows[i].Cells["ProductDescription"].Value.ToString();
            newInvoice.ProductName = dataGridView1.Rows[i].Cells["ProductName"].Value.ToString();
            newInvoice.Quantity = convertToInt(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
            newInvoice.SalesPrice = convertToDecimal(dataGridView1.Rows[i].Cells["ProductPrice"].Value.ToString());
            newInvoice.ProductExtension = newInvoice.SalesPrice * newInvoice.Quantity;
            return newInvoice;
        }

        public void updateShipInvoiceToDB(ShipInvoice placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                DB.ShipInvoices.Add(placeholder);
                DB.SaveChanges();
            }
        }

        public void updateShipLineItemToDB(ShipLineItem placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                DB.ShipLineItems.Add(placeholder);
                DB.SaveChanges();
            }
        }

        public void removeShipLineItem()
        {
            using (var DB = new CamcoEntities())
            {
                List<ShipLineItem> lineResult = DB.ShipLineItems.Where(x => x.InvoiceNumber == textInvoiceNumber.Text).ToList();

                if (lineResult != null)
                {
                    for (int i = 0; i < lineResult.Count; i++)
                    {
                        DB.ShipLineItems.Remove(lineResult[i]);
                        DB.SaveChanges();
                    }
                }
            }
        }

        public bool validateDate(string placeholder)
        {
            DateTime date;
            bool success = DateTime.TryParse(placeholder, out date);

            if (success)
            {
                return true;
            }

            else
            {
                return false;
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

        public string getPO()
        {
            return textInvoicePO.Text;
        }

        public void setPO(string placeholder)
        {
            textInvoicePO.Text = placeholder;
        }

        public string getSO()
        {
            return textInvoiceSO.Text;
        }

        public void setSO(string placeholder)
        {
            textInvoiceSO.Text = placeholder;
        }

        public void AddRow(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int invoiceSO = convertToInt(textInvoiceSO.Text);
                List<Shipping> result = DB.Shippings.Where(x => x.InvoiceSO == invoiceSO).ToList();

                if (result != null)
                {
                  decimal totalPrice = result[i].QuantityPicked.GetValueOrDefault() * result[i].ProductPrice.GetValueOrDefault();
                  dataGridView1.Rows.Add(result[i].ShipID, result[i].InvoiceSO, result[i].InvoicePO, result[i].Quantity, result[i].ProductName, result[i].ProductDescription, result[i].QuantityPicked, result[i].QuantityRemaining, result[i].DateScheduled, result[i].ProductPrice, totalPrice);
                }
            }
        }

        public void setKitDescription(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textInvoiceSO.Text);
                List<Shipping> result = DB.Shippings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    dataGridView1.Rows[i].Cells["Kit"].Value = result[i].Kit;
                }
            }
        }

        public void setCustomerID()
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textInvoiceSO.Text);

                if (result != null)
                {
                    textCustomerID.Text = result.CustomerID.ToString();
                }
            }
        }

        public void editRichBill()
        {
            using (var DB = new CamcoEntities())
            {
                int custID = convertToInt(textCustomerID.Text);
                Customer result = DB.Customers.SingleOrDefault(x => x.CustomerID == custID);

                if (result != null)
                {
                    richTextBill.Text = result.CustomerBillAddress + Environment.NewLine + result.CustomerBillCity + ", " + result.CustomerBillState + result.CustomerBillZipCode;
                }
            }
        }

        public void editRichShip()
        {
            using (var DB = new CamcoEntities())
            {
                int custID = convertToInt(textCustomerID.Text);
                Customer result = DB.Customers.SingleOrDefault(x => x.CustomerID == custID);

                if (result != null)
                {
                    richTextShip.Text = result.CustomerShipAddress + Environment.NewLine + result.CustomerBillCity + ", " + result.CustomerBillState + result.CustomerBillZipCode;
                }
            }
        }

        public void calculateInvoiceTotal()
        {
            decimal InvoiceTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                InvoiceTotal = InvoiceTotal + (convertToDecimal(dataGridView1.Rows[i].Cells["TotalPrice"].Value.ToString()));
            }
            textInvoiceTotal.Text = InvoiceTotal.ToString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, -115);
        }

        Bitmap bmp;

        private void btnPackingList_Click(object sender, EventArgs e)
        {
            Graphics graphic = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height - 20, graphic);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, -45, 70, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void textInvoicePO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            GenerateInvoiceForm newForm = new GenerateInvoiceForm();
            bool openForm = false;
            newForm.setPO(textInvoicePO.Text);
            newForm.setSO(textInvoiceSO.Text);
            newForm.setInvoiceNumber(textInvoiceNumber.Text);
            newForm.setCustomerID();
            newForm.editRichBill();
            newForm.editRichShip();
            newForm.setCustomerName();

            /* 
             When generating invoice, only include shipped items. Older shipped items will not appear in the invoice even if they are in the same sales order.
             Possible solutions: Two different tables (ShipLineItems and ShipInvoice), add shipped items to both. When creating a new generated invoice, remove old entries from
             one table (ShipLineItems) but not the other (ShipInvoice). As new items are shipped, the older shipped items will be removed from the Shipping table. Regulate what 
             is being shipped using a checkbox.
             Confused on where to store the "records" of the invoice.
             
            CHECK IF OK TO NOT STORE SHIPLINEITEMS RECORDS AND ONLY KEEP SHIPINVOICE RECORDS
             
             */


            using (var DB = new CamcoEntities())
            {
                if ((textInvoiceNumber.Text != null) && (textInvoiceSO.Text != null) && (textInvoicePO.Text != null))
                {
                    removeShipLineItem();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        bool invoiceCheck = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Invoice"].Value);
                        if (invoiceCheck == true)
                        {
                            var convertedValue = convertShipToShipLine(i);
                            updateShipLineItemToDB(convertedValue);
                            var shipInvoiceValue = convertShipToInvoice(i);
                            updateShipInvoiceToDB(shipInvoiceValue);
                            newForm.AddRow(i);
                        }
                        openForm = true;
                    }
                }

                else
                {
                    string message = "Please fill all text boxes.";
                    MessageBox.Show(message);
                }
            }

            if (openForm == true)
            {
                newForm.Show();
            }
        }
    }
}
