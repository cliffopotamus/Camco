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
            KitBox k3 = new KitBox(3, "DWS-8 Drywall Screw");
            KitBox k4 = new KitBox(4, "EZ-2 Plastic anchors");
            KitBox k5 = new KitBox(5, "EZ-5 Metal anchor");
            KitBox k6 = new KitBox(6, "EZT8218W E-Z Toggle Anchors Metal");
            KitBox k7 = new KitBox(7, "F-400 Flanged");
            KitBox k8 = new KitBox(8, "F-400HWH Flanged");
            KitBox k9 = new KitBox(9, "FA-316 Flanged");
            KitBox k10 = new KitBox(10, "FA-316FH PH-6");
            KitBox k11 = new KitBox(11, "FA-316FHPH");
            KitBox k12 = new KitBox(12, "FA316-6 Flanged");
            KitBox k13 = new KitBox(13, "FA-1420 Flanged");
            KitBox k14 = new KitBox(14, "FA-1420 HW \"Big Red\" Flanged");
            KitBox k15 = new KitBox(15, "FA-5016 Flanged");
            KitBox k16 = new KitBox(16, "FA-5016 HWH Flanged");
            KitBox k17 = new KitBox(17, "GF-1816");
            KitBox k18 = new KitBox(18, "H-78 Hex Washer Slotted");
            KitBox k19 = new KitBox(19, "HC-14");
            KitBox k20 = new KitBox(20, "LS-30");
            KitBox k21 = new KitBox(21, "MK-1812");
            KitBox k22 = new KitBox(22, "NW-12");
            KitBox k23 = new KitBox(23, "NW-832-1032");
            KitBox k24 = new KitBox(24, "NY-80");
            KitBox k25 = new KitBox(25, "SB-316");
            KitBox k26 = new KitBox(26, "SB-632");
            KitBox k27 = new KitBox(27, "SB-832");
            KitBox k28 = new KitBox(28, "SB-1032");
            KitBox k29 = new KitBox(29, "SB-1420");
            KitBox k30 = new KitBox(30, "SBH-1420");
            KitBox k31 = new KitBox(31, "SBH-3816");
            KitBox k32 = new KitBox(32, "SBH-5018");
            KitBox k33 = new KitBox(33, "SLW-358");
            KitBox k34 = new KitBox(34, "SS-500");
            KitBox k35 = new KitBox(35, "TB-12");
            KitBox k36 = new KitBox(36, "TK-8");
            KitBox k37 = new KitBox(37, "TK-10");
            KitBox k38 = new KitBox(38, "TK-10-5834");
            KitBox k39 = new KitBox(39, "TK-12");
            KitBox k40 = new KitBox(40, "TK-14");
            KitBox k41 = new KitBox(41, "Tk-141");
            KitBox k42 = new KitBox(42, "TSHZ-1010");
            KitBox k43 = new KitBox(43, "W-100 Plated washers");
            KitBox k44 = new KitBox(44, "WE-383");
            KitBox k45 = new KitBox(45, "DWS-6L Long Drywall");

            comboKit.Items.Add(k1);
            comboKit.Items.Add(k2);
            comboKit.Items.Add(k3);
            comboKit.Items.Add(k4);
            comboKit.Items.Add(k5);
            comboKit.Items.Add(k6);
            comboKit.Items.Add(k7);
            comboKit.Items.Add(k8);
            comboKit.Items.Add(k9);
            comboKit.Items.Add(k10);
            comboKit.Items.Add(k11);
            comboKit.Items.Add(k12);
            comboKit.Items.Add(k13);
            comboKit.Items.Add(k14);
            comboKit.Items.Add(k15);
            comboKit.Items.Add(k16);
            comboKit.Items.Add(k17);
            comboKit.Items.Add(k18);
            comboKit.Items.Add(k19);
            comboKit.Items.Add(k20);
            comboKit.Items.Add(k21);
            comboKit.Items.Add(k22);
            comboKit.Items.Add(k23);
            comboKit.Items.Add(k24);
            comboKit.Items.Add(k25);
            comboKit.Items.Add(k26);
            comboKit.Items.Add(k27);
            comboKit.Items.Add(k28);
            comboKit.Items.Add(k29);
            comboKit.Items.Add(k30);
            comboKit.Items.Add(k31);
            comboKit.Items.Add(k32);
            comboKit.Items.Add(k33);
            comboKit.Items.Add(k34);
            comboKit.Items.Add(k35);
            comboKit.Items.Add(k36);
            comboKit.Items.Add(k37);
            comboKit.Items.Add(k38);
            comboKit.Items.Add(k39);
            comboKit.Items.Add(k40);
            comboKit.Items.Add(k41);
            comboKit.Items.Add(k42);
            comboKit.Items.Add(k43);
            comboKit.Items.Add(k44);
            comboKit.Items.Add(k45);
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
                        String[] DWS6Kit = new string[5];
                        DWS6Kit[0] = "2box";
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

                    case "DWS-8 Drywall Screw":
                        String[] DWS8Kit = new string[5];
                        DWS8Kit[0] = "2box";
                        DWS8Kit[1] = "DWS8-212";
                        DWS8Kit[2] = "DWS8-3";
                        DWS8Kit[3] = "PBit2";
                        DWS8Kit[4] = "Mbholder";

                        for (int i = 0; i < 5; i++)
                        {
                            var temp = DWS8Kit[i];

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

                    case "EZ-5 Plastic anchors":
                        String[] EZ5Kit = new string[3];
                        EZ5Kit[0] = "1box";
                        EZ5Kit[1] = "Manchor";
                        EZ5Kit[2] = "Cpan8-114";


                        for (int i = 0; i < 3; i++)
                        {
                            var temp = EZ5Kit[i];

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

                    case "EZ-2 Plastic anchors":
                        String[] EZ2Kit = new string[3];
                        EZ2Kit[0] = "2box";
                        EZ2Kit[1] = "Panchor-white";
                        EZ2Kit[2] = "pflat634";


                        for (int i = 0; i < 3; i++)
                        {
                            var temp = EZ2Kit[i];

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

                    case "F-400HWH Flanged":
                        String[] F400HWHKit = new string[4];
                        F400HWHKit[0] = "2box";
                        F400HWHKit[1] = "BAnchor141";
                        F400HWHKit[2] = "Zip10-1";
                        F400HWHKit[3] = "Mdrill14";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = F400HWHKit[i];

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

                    case "F-400H Flanged":
                        String[] F400Kit = new string[4];
                        F400Kit[0] = "2box";
                        F400Kit[1] = "BAnchor141";
                        F400Kit[2] = "Cpan10-1T";
                        F400Kit[3] = "Mdrill14";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = F400Kit[i];

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

                    case "FA-316 Flanged":
                        String[] FA316Kit = new string[4];
                        FA316Kit[0] = "2box";
                        FA316Kit[1] = "Panc316-78R";
                        FA316Kit[2] = "ZCpan8-1";
                        FA316Kit[3] = "Mdrill1316";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA316Kit[i];

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

                    case "FA-316FH PH-6":
                        String[] FA316FHKit = new string[4];
                        FA316FHKit[0] = "2box";
                        FA316FHKit[1] = "pflat634";
                        FA316FHKit[2] = "Panc316-78R";
                        FA316FHKit[3] = "Mdrill316";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA316FHKit[i];

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

                    case "FA-316FHPH":
                        String[] FA316FHPHKit = new string[4];
                        FA316FHPHKit[0] = "2box";
                        FA316FHPHKit[1] = "pflat8-1";
                        FA316FHPHKit[2] = "Panc316-78R";
                        FA316FHPHKit[3] = "Mdrill316";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA316FHPHKit[i];

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

                    case "FA-316-6 Flanged":
                        String[] FA3166Kit = new string[4];
                        FA3166Kit[0] = "2box";
                        FA3166Kit[1] = "Panc316-78R";
                        FA3166Kit[2] = "Cpan634";
                        FA3166Kit[3] = "Mdrill316";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA3166Kit[i];

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

                    case "FA-1420 Flanged":
                        String[] FA1420Kit = new string[4];
                        FA1420Kit[0] = "2box";
                        FA1420Kit[1] = "Cpan10-1T";
                        FA1420Kit[2] = "RANChor14-1";
                        FA1420Kit[3] = "Mdrill14";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA1420Kit[i];

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

                    case "FA-1420 HWH \"Big Red\" Flanged":
                        String[] FA1420HWHKit = new string[4];
                        FA1420HWHKit[0] = "2box";
                        FA1420HWHKit[1] = "Zip10-1";
                        FA1420HWHKit[2] = "RANChor14-1";
                        FA1420HWHKit[3] = "Mdrill14";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA1420HWHKit[i];

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

                    case "FA-5016 Flanged":
                        String[] FA5016Kit = new string[4];
                        FA5016Kit[0] = "2box";
                        FA5016Kit[1] = "Panch-516-114B";
                        FA5016Kit[2] = "Cpan-12-114";
                        FA5016Kit[3] = "Mdrill516";

                        for (int i = 0; i < 4; i++)
                        {
                            var temp = FA5016Kit[i];

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

                    case "GF-1816":
                        String[] GF1816Kit = new string[9];
                        GF1816Kit[0] = "2box";
                        GF1816Kit[1] = "GF-64-01 ST";
                        GF1816Kit[2] = "GF-90";
                        GF1816Kit[3] = "GF-45";
                        GF1816Kit[4] = "GF1428-45";
                        GF1816Kit[5] = "GF1428-90";
                        GF1816Kit[6] = "GF1428ST";
                        GF1816Kit[7] = "316-str64-12";
                        GF1816Kit[8] = "GF-516-64-13";

                        for (int i = 0; i < 9; i++)
                        {
                            var temp = GF1816Kit[i];

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

                    case "H-78 Hex Washer Slotted":
                        String[] H78Kit = new string[7];
                        H78Kit[0] = "6box";
                        H78Kit[1] = "Zip8-12";
                        H78Kit[2] = "Zip8-34";
                        H78Kit[3] = "Zip8-1";
                        H78Kit[4] = "Zip8-114";
                        H78Kit[5] = "Zip8-112";
                        H78Kit[6] = "JC-2";

                        for (int i = 0; i < 7; i++)
                        {
                            var temp = H78Kit[i];

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

                    case "HC-14":
                        String[] HC14Kit = new string[8];
                        HC14Kit[0] = "2box";
                        HC14Kit[1] = "HC-300-004";
                        HC14Kit[2] = "HC-300-006";
                        HC14Kit[3] = "HC-300-008";
                        HC14Kit[4] = "HC-300-012";
                        HC14Kit[5] = "HC-600-016";
                        HC14Kit[6] = "HC-600-020";
                        HC14Kit[7] = "HC-600-028";

                        for (int i = 0; i < 8; i++)
                        {
                            var temp = HC14Kit[i];

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

                    case "LS-30":
                        String[] LS30Kit = new string[6];
                        LS30Kit[0] = "2box";
                        LS30Kit[1] = "LAGS-38-1";
                        LS30Kit[2] = "LAGS-38-112";
                        LS30Kit[3] = "LAGS-38-2";
                        LS30Kit[4] = "LAGS-38-212";
                        LS30Kit[5] = "LAGS-38-3";

                        for (int i = 0; i < 6; i++)
                        {
                            var temp = LS30Kit[i];

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

                    case "MK-1812":
                        String[] MK1812Kit = new string[7];
                        MK1812Kit[0] = "6box";
                        MK1812Kit[1] = "MK-18-112L";
                        MK1812Kit[2] = "MK-316-112L";
                        MK1812Kit[3] = "MK14-112L";
                        MK1812Kit[4] = "MK-516-112";
                        MK1812Kit[5] = "MK-38-112L";
                        MK1812Kit[6] = "MK12-2L";

                        for (int i = 0; i < 5; i++)
                        {
                            var temp = MK1812Kit[i];

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

                  /*  case "NW-12":
                        String[] NW12Kit = new string[12];
                        



                        for (int i = 0; i < 11; i++)
                        {
                            var temp = NW12Kit[i];

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

                        break; */

                    case "NW-832-1032":
                        String[] NW8321032Kit = new string[28];
                        NW8321032Kit[0] = "2box";
                        NW8321032Kit[1] = "632MSN";
                        NW8321032Kit[2] = "632KLN";
                        NW8321032Kit[3] = "632NYN";
                        NW8321032Kit[4] = "SAEF632-6";
                        NW8321032Kit[5] = "632SLW6";
                        NW8321032Kit[6] = "Cnut6-32";
                        NW8321032Kit[7] = "632-112MS";
                        NW8321032Kit[8] = "832MSN";
                        NW8321032Kit[9] = "832KLN";
                        NW8321032Kit[10] = "832NYN";
                        NW8321032Kit[11] = "832SFN";
                        NW8321032Kit[12] = "Cnut8-32";
                        NW8321032Kit[13] = "832WN";
                        NW8321032Kit[14] = "SAEF832-8";
                        NW8321032Kit[15] = "832SLW8";
                        NW8321032Kit[16] = "832-12MS";
                        NW8321032Kit[17] = "832-34MS";
                        NW8321032Kit[18] = "832-114MS";
                        NW8321032Kit[19] = "1032HN";
                        NW8321032Kit[20] = "1032KLN";
                        NW8321032Kit[21] = "1032NLN";
                        NW8321032Kit[22] = "1032SFN";
                        NW8321032Kit[23] = "1032CN";
                        NW8321032Kit[24] = "1032WN";
                        NW8321032Kit[25] = "1032SLW10";
                        NW8321032Kit[26] = "SAEFW10";
                        NW8321032Kit[27] = "1032114MS";


                        for (int i = 0; i < 28; i++)
                        {
                            var temp = NW8321032Kit[i];

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

                    case "NY-80":
                        String[] NY80Kit = new string[5];
                        NY80Kit[0] = "2box";
                        NY80Kit[1] = "NLIstop-14";
                        NY80Kit[2] = "NLIstop-516";
                        NY80Kit[3] = "NLIstop-38";
                        NY80Kit[4] = "MNLIstop-12";

                        for (int i = 0; i < 5; i++)
                        {
                            var temp = NY80Kit[i];

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

                    case "SB-316":
                        String[] SB316Kit = new string[10];
                        SB316Kit[0] = "2box";
                        SB316Kit[1] = "102438MS";
                        SB316Kit[2] = "102412MS";
                        SB316Kit[3] = "102434MS";
                        SB316Kit[4] = "10241MS";
                        SB316Kit[5] = "1024114MS";
                        SB316Kit[6] = "1024112MS";
                        SB316Kit[7] = "10242MS";
                        SB316Kit[8] = "1024MSN";
                        SB316Kit[9] = "SAEFW10";


                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SB316Kit[i];

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

                    case "SB-632":
                        String[] SB632Kit = new string[10];
                        SB632Kit[0] = "2box";
                        SB632Kit[1] = "632-38MS";
                        SB632Kit[2] = "632-12MS";
                        SB632Kit[3] = "632-34MS";
                        SB632Kit[4] = "632-1MS";
                        SB632Kit[5] = "632-112MS";
                        SB632Kit[6] = "632-114MS";
                        SB632Kit[7] = "632-2MS";
                        SB632Kit[8] = "632MSN";
                        SB632Kit[9] = "SAEF632-6";

                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SB632Kit[i];

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

                    case "SB-832":
                        String[] SB832Kit = new string[10];
                        SB832Kit[0] = "2box";
                        SB832Kit[1] = "832-38MS";
                        SB832Kit[2] = "832-12MS";
                        SB832Kit[3] = "832-34MS";
                        SB832Kit[4] = "832-1MS";
                        SB832Kit[5] = "832-114MS";
                        SB832Kit[6] = "832-112MS";
                        SB832Kit[7] = "832-2MS";
                        SB832Kit[8] = "832MSN";
                        SB832Kit[9] = "SAEF832-8";

                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SB832Kit[i];

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

                    case "SB-1032":
                        String[] SB1032Kit = new string[10];
                        SB1032Kit[0] = "2box";
                        SB1032Kit[1] = "103238MS";
                        SB1032Kit[2] = "103212MS";
                        SB1032Kit[3] = "103234MS";
                        SB1032Kit[4] = "10321MS";
                        SB1032Kit[5] = "1032114MS";
                        SB1032Kit[6] = "1032112MS";
                        SB1032Kit[7] = "10322MS";
                        SB1032Kit[8] = "1032SLW10";
                        SB1032Kit[9] = "SAEFW10";

                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SB1032Kit[i];

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

                    case "SB-1420":
                        String[] SB1420Kit = new string[9];
                        SB1420Kit[0] = "2box";
                        SB1420Kit[1] = "MS14-12";
                        SB1420Kit[2] = "MS14-34";
                        SB1420Kit[3] = "MS14-1";
                        SB1420Kit[4] = "MS14-114";
                        SB1420Kit[5] = "MS14-112";
                        SB1420Kit[6] = "MS14-2";
                        SB1420Kit[7] = "HFN14";
                        SB1420Kit[8] = "SAEFW14";

                        for (int i = 0; i < 9; i++)
                        {
                            var temp = SB1420Kit[i];

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

                    case "SB-3816":
                        String[] SB3816Kit = new string[10];
                        SB3816Kit[0] = "USSFW38";
                        SB3816Kit[1] = "2box";
                        SB3816Kit[2] = "TB38-34";
                        SB3816Kit[3] = "TB38-1";
                        SB3816Kit[4] = "TB38-112";
                        SB3816Kit[5] = "TB38-2";
                        SB3816Kit[6] = "HFN38";
                        SB3816Kit[7] = "KLN38";
                        SB3816Kit[8] = "SLW38";
                        SB3816Kit[9] = "FW38-112";

                        for (int i = 0; i <10; i++)
                        {
                            var temp = SB3816Kit[i];

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

                    case "SBH-5018":
                        String[] SBH5018Kit = new string[10];
                        SBH5018Kit[0] = "2box";
                        SBH5018Kit[1] = "TB516-34";
                        SBH5018Kit[2] = "TB516-1";
                        SBH5018Kit[3] = "TB516-112";
                        SBH5018Kit[4] = "TB516-2";
                        SBH5018Kit[5] = "USSFW516";
                        SBH5018Kit[6] = "HFN516";
                        SBH5018Kit[7] = "KLN516";
                        SBH5018Kit[8] = "SLW516";
                        SBH5018Kit[9] = "FW516-114";



                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SBH5018Kit[i];

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

                    case "SLW-358":
                        String[] SLW358Kit = new string[6];
                        SLW358Kit[0] = "6box";
                        SLW358Kit[1] = "SAEFW10";
                        SLW358Kit[2] = "SLW14";
                        SLW358Kit[3] = "SLW516";
                        SLW358Kit[4] = "SLW38";
                        SLW358Kit[5] = "SLW58";



                        for (int i = 0; i < 6; i++)
                        {
                            var temp = SLW358Kit[i];

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

                    case "SS-500":
                        String[] SS500Kit = new string[23];
                        SS500Kit[0] = "516-18NC14";
                        SS500Kit[1] = "516-18NC38";
                        SS500Kit[2] = "516-18NC12";
                        SS500Kit[3] = "516-18NC34";
                        SS500Kit[4] = "SS5-1420-14";
                        SS500Kit[5] = "SS5-1420-38";
                        SS500Kit[6] = "SS5-1420-12";
                        SS500Kit[7] = "SS5-1428-34";
                        SS500Kit[8] = "1024NC14";
                        SS500Kit[9] = "1024NC38";
                        SS500Kit[10] = "1024NC12";
                        SS500Kit[11] = "516-24NF14";
                        SS500Kit[12] = "516-24NF38";
                        SS500Kit[13] = "516-24NF12";
                        SS500Kit[14] = "516-24NF34";
                        SS500Kit[15] = "SS5-1428-14";
                        SS500Kit[16] = "SS5-1428-38";
                        SS500Kit[17] = "SS5-1428-12";
                        SS500Kit[18] = "SS5-1428-34";
                        SS500Kit[19] = "1032NF14";
                        SS500Kit[20] = "1032NF38";
                        SS500Kit[21] = "1032NF12";
                        SS500Kit[22] = "6box";


                        for (int i = 0; i < 10; i++)
                        {
                            var temp = SS500Kit[i];

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

                    case "TK-8":
                        String[] TK8Kit = new string[7];
                        TK8Kit[0] = "6box";
                        TK8Kit[1] = "TEK8-12";
                        TK8Kit[2] = "TEK8-34";
                        TK8Kit[3] = "TEK8-1";
                        TK8Kit[4] = "TEK8-114";
                        TK8Kit[5] = "TEK78-112";
                        TK8Kit[6] = "JC-2";




                        for (int i = 0; i < 7; i++)
                        {
                            var temp = TK8Kit[i];

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

                    case "TK-10":
                        String[] TK10Kit = new string[7];
                        TK10Kit[0] = "6box";
                        TK10Kit[1] = "Tek1012";
                        TK10Kit[2] = "TEK1034";
                        TK10Kit[3] = "Tek10-1";
                        TK10Kit[4] = "Tek10-114";
                        TK10Kit[5] = "Tek10-112";
                        TK10Kit[6] = "JC-15";
 
                        for (int i = 0; i < 7; i++)
                        {
                            var temp = TK10Kit[i];

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

                    case "TK-12":
                        String[] TK12Kit = new string[7];
                        TK12Kit[0] = "6box";
                        TK12Kit[1] = "Tek12-34";
                        TK12Kit[2] = "Tek12-1";
                        TK12Kit[3] = "Tek12-114";
                        TK12Kit[4] = "Tek12-112";
                        TK12Kit[5] = "Tek12-2";
                        TK12Kit[6] = "JC-15";


                        for (int i = 0; i < 7; i++)
                        {
                            var temp = TK12Kit[i];

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

                    case "TK-10-5834":
                        String[] TK105834Kit = new string[4];
                        TK105834Kit[0] = "2box";
                        TK105834Kit[1] = "JC-15";
                        TK105834Kit[2] = "TEK1058";
                        TK105834Kit[3] = "TEK1034";



                        for (int i = 0; i < 4; i++)
                        {
                            var temp = TK105834Kit[i];

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

                    case "TK-14":
                        String[] TK14Kit = new string[7];
                        TK14Kit[0] = "6box";
                        TK14Kit[1] = "Tek14-34";
                        TK14Kit[2] = "Tek14-1";
                        TK14Kit[3] = "Tek14-114";
                        TK14Kit[4] = "Tek14-112";
                        TK14Kit[5] = "Tek14-2";
                        TK14Kit[6] = "JC-30";




                        for (int i = 0; i < 7; i++)
                        {
                            var temp = TK14Kit[i];

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

                    case "TK-141":
                        String[] TK141Kit = new string[3];
                        TK141Kit[0] = "6box";
                        TK141Kit[1] = "Tek14-1";
                        TK141Kit[2] = "JC-30";


                        for (int i = 0; i < 3; i++)
                        {
                            var temp = TK141Kit[i];

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

                    case "TSHZ-1010":
                        String[] TSHZ1010Kit = new string[7];
                        TSHZ1010Kit[0] = "ZIP10-12";
                        TSHZ1010Kit[1] = "ZIP1034";
                        TSHZ1010Kit[2] = "Zip10-1";
                        TSHZ1010Kit[3] = "ZIP10-114";
                        TSHZ1010Kit[4] = "ZIP10-112";
                        TSHZ1010Kit[5] = "ZIP102";
                        TSHZ1010Kit[6] = "6box";




                        for (int i = 0; i < 7; i++)
                        {
                            var temp = TSHZ1010Kit[i];

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

                    case "W-100 Plated washers":
                        String[] W100Kit = new string[16];
                        W100Kit[0] = "1box";
                        W100Kit[1] = "SAEF632-6";
                        W100Kit[2] = "SAEF832-8";
                        W100Kit[3] = "SAEFW10";
                        W100Kit[4] = "SAEFW14";
                        W100Kit[5] = "SAEFW516";
                        W100Kit[6] = "SAEFW38";
                        W100Kit[7] = "USSFW14";
                        W100Kit[8] = "USSFW516";
                        W100Kit[9] = "FW14-1";
                        W100Kit[10] = "FW316-1";
                        W100Kit[11] = "FW38-112";
                        W100Kit[12] = "FW12-112";
                        W100Kit[13] = "FW516-114";
                        W100Kit[14] = "USSFW12";
                        W100Kit[15] = "USSFW38";



                        for (int i = 0; i < 16; i++)
                        {
                            var temp = W100Kit[i];

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

                    case "WE-383":
                        String[] WE383Kit = new string[5];
                        WE383Kit[0] = "2box";
                        WE383Kit[1] = "HFN38";
                        WE383Kit[2] = "SAEFW38";
                        WE383Kit[3] = "WedgeAnc-38-3";
                        WE383Kit[4] = "Mdrill38";


                        for (int i = 0; i < 5; i++)
                        {
                            var temp = WE383Kit[i];

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
