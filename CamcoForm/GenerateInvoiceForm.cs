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
            editRichCamco();
            textInvoiceTotal.Text = "0";
        }

        private void GenerateInvoiceForm_Load(object sender, EventArgs e)
        {
            calculateInvoiceTotal();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        public string getInvoiceNumber()
        {
            return textInvoiceNumber.Text;
        }
        
        public void setInvoiceNumber(string placeholder)
        {
            textInvoiceNumber.Text = placeholder;
        }

        public void calculateInvoiceTotal()
        {
            decimal InvoiceTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                InvoiceTotal = InvoiceTotal + (convertToDecimal(dataGridView1.Rows[i].Cells["ProductExtension"].Value.ToString()));
            }
            textInvoiceTotal.Text = InvoiceTotal.ToString();
        }

        public void AddRow(int i)
        {
            using (var DB = new CamcoEntities())
            {
                string stringSO = textInvoiceSO.Text;
                List<ShipLineItem> result = DB.ShipLineItems.Where(x => x.InvoiceSO == stringSO).ToList();

                if (result != null)
                {
                    decimal totalPrice = result[i].QuantityPicked.GetValueOrDefault() * result[i].SalesPrice.GetValueOrDefault();
                    dataGridView1.Rows.Add(result[i].InvoiceID, result[i].InvoiceNumber,result[i].InvoiceSO, result[i].InvoicePO, result[i].Quantity, result[i].ProductName, result[i].ProductDescription, result[i].QuantityPicked, result[i].QuantityRemaining, result[i].SalesPrice, totalPrice, result[i].DateScheduled, result[i].invoice);
                }
            }
        }

        public void setCustomerName()
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textInvoiceSO.Text);

                if (result != null)
                {
                    textCustomerName.Text = result.CustomerName.ToString();
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

        public void editRichCamco()
        {
            richTextBox1.Text = "Camco Industries" + Environment.NewLine + "9928 Bell Ranch Dr." + Environment.NewLine + "Santa Fe Springs, CA 90801-2411";
        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics graphic = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height - 20, graphic);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, -45, 70, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
