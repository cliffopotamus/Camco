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
    public partial class ReceivedForm : Form
    {
        public ReceivedForm()
        {
            InitializeComponent();
        }

        private void ReceivedForm_Load(object sender, EventArgs e)
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

        public string getPO()
        {
            return textPurchasePO.Text;
        }

        public void setPO(string placeholder)
        {
            textPurchasePO.Text = placeholder;
        }

        public string getSO()
        {
            return textPurchaseSO.Text;
        }

        public void setSO(string placeholder)
        {
            textPurchaseSO.Text = placeholder;
        }

        public void editPurchaseTotal()
        {
            using (var DB = new CamcoEntities())
            {
                PurchaseOrder result = DB.PurchaseOrders.SingleOrDefault(x => x.PurchaseSO == textPurchaseSO.Text);

                if (result != null)
                {
                    textPurchaseTotal.Text = result.PurchaseTotal.ToString();
                }
            }
        }

        public void AddRow(int i)
        {
            using (var DB = new CamcoEntities())
            {
                string invoiceSO = textPurchasePO.Text;
                List<Received> result = DB.Receiveds.Where(x => x.PurchaseSO == invoiceSO).ToList();

                if (result != null)
                {
                    dataGridView1.Rows.Add(result[i].ReceivedID, result[i].PurchaseSO, result[i].PurchasePO, result[i].Quantity, result[i].ProductName, result[i].QuantityReceived, result[i].QuantityRemaining, result[i].DateScheduled);
                }
            }
        }

        public void setCustomerID()
        {
            using (var DB = new CamcoEntities())
            {
                PurchaseOrder result = DB.PurchaseOrders.SingleOrDefault(x => x.PurchaseSO == textPurchaseSO.Text);

                if (result != null)
                {
                    textCustomerID.Text = result.VendorID.ToString();
                }
            }
        }

        Bitmap bmp;

        private void btnPackingList_Click(object sender, EventArgs e)
        {
            Graphics graphic = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height - 20, graphic);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, -10 , 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, -30);
        }
    }
}
