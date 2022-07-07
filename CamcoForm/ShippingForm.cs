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
        }

        private void ShippingForm_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;

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
                  dataGridView1.Rows.Add(result[i].ShipID, result[i].InvoiceSO, result[i].InvoicePO, result[i].Quantity, result[i].ProductName, result[i].ProductDescription, result[i].QuantityPicked, result[i].QuantityRemaining, result[i].DateScheduled);
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

        public void editInvoiceTotal()
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textInvoiceSO.Text);

                if (result != null)
                {
                    textInvoiceTotal.Text = result.InvoiceTotal.ToString();
                }
            }
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
    }
}
