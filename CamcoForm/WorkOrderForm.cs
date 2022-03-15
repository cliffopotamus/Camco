using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CamcoForm
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
            PopulateCombo();
        }

        private void PopulateCombo()
        {
            KitBox k1 = new KitBox(1, "DI-38 Drop-in Anchors");
            KitBox k2 = new KitBox(2, "DWS-6 Drywall Screw");

            comboKit.Items.Add(k1);
            comboKit.Items.Add(k2);
        }

        public class KitBox
        {
            public int ID;
            public string DisplayName;

            public KitBox(int pID, string pName)
            {
                ID = pID;
                DisplayName = pName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
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

        public void editRichTextBox(string kitName)
        {
            using (var DB = new CamcoEntities())
            {

                switch (kitName)
                {
                    case "DI-38 Drop-in Anchors":
                        String[] DI38Kit = new string[4];
                        DI38Kit[0] = "1box";
                        DI38Kit[1] = "Drop-in 38";
                        DI38Kit[2] = "Mdrill12";
                        DI38Kit[3] = "38Stool";
                        
                        for (int i = 0; i < 4; i++)
                        {
                            var temp = DI38Kit[i];

                            Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName.ToLower() == temp.ToLower());

                            if (result != null)
                            {
                                richTextBoxKits.AppendText("Product: " + result.ProductName + Environment.NewLine + "Quantity: " + result.ProductQuantity.ToString() + Environment.NewLine + "Unit Cost: " + result.UnitCost.ToString() + Environment.NewLine + "Sales Price: " + result.SalesPrice.ToString() + Environment.NewLine + Environment.NewLine);
                            }

                            else
                            {
                                richTextBoxKits.AppendText("Error");
                            }
                        }

                        break;

                    case "DWS-6 Drywall Screw":
                        String[] DWS6Kit = new string[4];
                        DWS6Kit[0] = "1box";
                        DWS6Kit[1] = "DWS61";
                        DWS6Kit[2] = "DWS6158";
                        DWS6Kit[3] = "PBit2";
                        DWS6Kit[4] = "Mbholder";
                        
                        for (int i = 0; i < 5; i++)
                        {
                            var temp = DWS6Kit[i];

                            Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName.ToLower() == temp.ToLower());

                            if (result != null)
                            {
                                richTextBoxKits.AppendText("Product: " + result.ProductName + Environment.NewLine + "Quantity: " + result.ProductQuantity.ToString() + Environment.NewLine + "Unit Cost: " + result.UnitCost.ToString() + Environment.NewLine + "Sales Price: " + result.SalesPrice.ToString() + Environment.NewLine + Environment.NewLine);
                            }

                            else
                            {
                                richTextBoxKits.AppendText("Error");
                            }
                        }

                        break;
                }

            }
        }

        public class KitModel
        {
            public string kitName;
            public int quantity;
            public int kitID;
            public decimal salesPrice;
            public decimal unitCost;
        }

        private void WorkOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void comboKit_SelectedIndexChanged(object sender, EventArgs e)
        {
            editRichTextBox(comboKit.Text);
        }
    }
}
