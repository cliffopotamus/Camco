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
                        richTextBoxKits.Text = "hello";
                        break;

                    case "DWS-6 Drywall Screw":
                        richTextBoxKits.Text = "goodbye";
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
