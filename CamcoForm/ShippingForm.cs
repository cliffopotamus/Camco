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
            // TODO: This line of code loads data into the 'camcoDataSet10.Shipping' table. You can move, or remove it, as needed.
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
                  dataGridView1.Rows.Add(result[i].ShipID, result[i].InvoiceSO, result[i].InvoicePO, result[i].Quantity, result[i].ProductName, result[i].QuantityPicked, result[i].QuantityRemaining);
                }
            }
        }
    }
}
