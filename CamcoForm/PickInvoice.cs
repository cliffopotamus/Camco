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
    public partial class PickInvoice : Form
    {
        public PickInvoice()
        {
            InitializeComponent();
        }

        private const int ColQuantPick = 4;
        private const int ColQuantRemain = 5;

        public class PickingModel
        {
            public int InvoiceSO;
            public int quantity;
            public string productName;
            public int quantityPicked;
            public int quantityRemaining;
            public bool commit;
            public string InvoicePO;
        }

        public class ShippingModel
        {
            public int InvoiceSO;
            public int quantity;
            public string productName;
            public int quantityPicked;
            public int quantityRemaining;
            public bool packingList;
            public string InvoicePO;
            public string dateScheduled;
            public string productDescription;
        }

        private bool editQuantity(int quantity)
        {
            return true;
        }

        public bool ValidateCell(DataGridViewCellValidatingEventArgs e)
        {
            bool result = true;

            switch (e.ColumnIndex)
            {
                case ColQuantPick:
                    int pickValue = convertToInt(e.FormattedValue.ToString());
                    result = editQuantity(pickValue);
                    break;
                case ColQuantRemain:
                    int remainValue = convertToInt(e.FormattedValue.ToString());
                    result = editQuantity(remainValue);
                    break;
            }
            return result;

        }

        private void PickInvoice_Load(object sender, EventArgs e)
        {

        }

        public Shipping convertPickToShipping(Picking placeholder)
        {
            Shipping ship = new Shipping();
            ship.InvoiceSO = placeholder.InvoiceSO;
            ship.Quantity = placeholder.Quantity;
            ship.InvoicePO = placeholder.InvoicePO;
            ship.QuantityPicked = placeholder.QuantityPicked;
            ship.QuantityRemaining = placeholder.QuantityRemaining;
            ship.DateScheduled = placeholder.DateScheduled;
            ship.ProductName = placeholder.ProductName;
            ship.ProductDescription = placeholder.ProductDescription;
            return ship;
        }

        public void setRemainingDGV(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    string stringRemaining = result[i].QuantityRemaining.ToString();
                    if (string.IsNullOrEmpty(stringRemaining))
                    {
                        dataGridView1.Rows[i].Cells[5].Value = result[i].Quantity;
                    }

                    else
                    {
                        dataGridView1.Rows[i].Cells[5].Value = result[i].QuantityRemaining;
                    }
                }
            }
        }

        public void setProductDescription(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    dataGridView1.Rows[i].Cells[7].Value = result[i].ProductDescription;
                }
            }
        }

        public void setProductPickID(int i)
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    dataGridView1.Rows[i].Cells[8].Value = result[i].PickID;
                }
            }
        }

        public void setDetails(string invoiceSO)
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == invoiceSO);
                textPONumber.Text = result.InvoicePO;
                textSONumber.Text = result.InvoiceSO;
            }
        }

        public void updateShipDB(Shipping placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                /* check shipping in DB, cant access here */
                DB.Shippings.Add(placeholder);
                DB.SaveChanges();
            }
        }

        public Picking convertNullPickToDB(int i)
        {
            Picking placeholder = new Picking();
            placeholder.InvoiceSO = convertToInt(textSONumber.Text);
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.InvoicePO = textPONumber.Text;
            placeholder.ProductDescription = dataGridView1.Rows[i].Cells[7].Value.ToString();
            return placeholder;
        }

        public Picking convertPickToDB(int i)
        {
            Picking placeholder = new Picking();
            placeholder.InvoiceSO = convertToInt(textSONumber.Text);
            placeholder.Quantity = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString());
            placeholder.ProductName = dataGridView1.Rows[i].Cells[3].Value.ToString();
            placeholder.QuantityPicked = convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());
            /* dataGridView1.Rows[i].Cells[5].Value = convertToInt(dataGridView1.Rows[i].Cells[2].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString()); */
            placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString());
            placeholder.Commit = Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value);
            placeholder.InvoicePO = textPONumber.Text;
            placeholder.DateScheduled = DateTime.Today.ToString("MM/dd/yyyy");
            placeholder.ProductDescription = dataGridView1.Rows[i].Cells[7].Value.ToString();

            if (placeholder.Commit == true)
            {
                placeholder.QuantityRemaining = convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()) - convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString());

            }

            return placeholder;
        }

        public void updateInventory(Picking placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                        if (placeholder.Commit == true)
                        {
                            int subtractFromInventory = (int)placeholder.QuantityPicked;
                            Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == placeholder.ProductName);

                            if (result != null)
                            {
                                int currentAmount = result.ProductQuantity.Value;

                                if (currentAmount >= subtractFromInventory)
                                {
                                    result.ProductQuantity = result.ProductQuantity - subtractFromInventory;
                                    DB.SaveChanges();
                                }

                                else
                                {
                                    string errorMsg = "Error: Pick quantity exceeds inventory amount.";
                                    MessageBox.Show(errorMsg);
                                }
                            }
                        }
            }
        }

        public void UpdateKitInventory(Picking placeholder, int currentRow)
        {
            using (var DB = new CamcoEntities())
            {
                    if (placeholder.ProductDescription == "KIT")
                    {
                        int pickAmount = (int)(placeholder.QuantityPicked);
                        switch (placeholder.ProductName)
                        {
                            case "DI-38 Drop-in Anchors":
                                if ((CheckProductKitInventory("1box", pickAmount)) && (CheckProductKitInventory("Drop-in 38", pickAmount * 12)) && (CheckProductKitInventory("Mdrill12", pickAmount)) && (CheckProductKitInventory("38Stool", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("1box", pickAmount);
                                    SubtractKitComponentFromInventory("Drop-in 38", pickAmount * 12);
                                    SubtractKitComponentFromInventory("Mdrill12", pickAmount);
                                    SubtractKitComponentFromInventory("38Stool", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in DI-38.";
                                    MessageBox.Show(message);
                                }
                                break;

                            case "DWS-6 Drywall Screw":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("DWS61", pickAmount * 100)) && (CheckProductKitInventory("DWS6158", pickAmount * 100)) && (CheckProductKitInventory("PBit2", pickAmount)) && (CheckProductKitInventory("Mbholder", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("DWS61", pickAmount * 100);
                                    SubtractKitComponentFromInventory("DWS6158", pickAmount * 100);
                                    SubtractKitComponentFromInventory("PBit2", pickAmount);
                                    SubtractKitComponentFromInventory("Mbholder", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in DWS-6 Drywall Screw.";
                                    MessageBox.Show(message);
                                }
                                break;

                            case "DWS-8 Drywall Screw":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("DWS8-212", pickAmount * 50)) && (CheckProductKitInventory("DWS8-3", pickAmount * 50)) && (CheckProductKitInventory("PBit2", pickAmount)) && (CheckProductKitInventory("Mbholder", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("DWS8-212", pickAmount * 50);
                                    SubtractKitComponentFromInventory("DWS8-3", pickAmount * 50);
                                    SubtractKitComponentFromInventory("PBit2", pickAmount);
                                    SubtractKitComponentFromInventory("Mbholder", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in DWS-8 Drywall Screw.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "EZ-2 Plastic anchors":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panchor-white", pickAmount * 60)) && (CheckProductKitInventory("pflat634", pickAmount * 60)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Panchor-white", pickAmount * 60);
                                    SubtractKitComponentFromInventory("pflat634", pickAmount * 60);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in EZ-2 Plastic anchors.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "EZ-5 Metal anchor":
                                if ((CheckProductKitInventory("1box", pickAmount)) && (CheckProductKitInventory("Manchor", pickAmount * 50)) && (CheckProductKitInventory("Cpan8-114", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("1box", pickAmount);
                                    SubtractKitComponentFromInventory("Manchor", pickAmount * 50);
                                    SubtractKitComponentFromInventory("Cpan8-114", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in EZ-5 Metal anchor.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "F-400 Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("BAnchor141", pickAmount * 100)) && (CheckProductKitInventory("Cpan 10-1T", pickAmount * 100)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("BAnchor141", pickAmount * 100);
                                    SubtractKitComponentFromInventory("Cpan 10-1T", pickAmount * 100);
                                    SubtractKitComponentFromInventory("Mdrill14", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in F-400 Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "F-400HWH Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("BAnchor141", pickAmount * 100)) && (CheckProductKitInventory("Zip10-1", pickAmount * 100)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("BAnchor141", pickAmount * 100);
                                    SubtractKitComponentFromInventory("Zip10-1", pickAmount * 100);
                                    SubtractKitComponentFromInventory("Mdrill14", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in F-400HWH Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-316 Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Cpan8-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Panc316-78R", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Cpan8-1", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill316", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-316 Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-316FH PH-6":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("pflat634", pickAmount * 101)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("pflat634", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Panc316-78R", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill316", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-316FH PH-6.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-316FHPH":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("pflat8-1", pickAmount * 101)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("pflat8-1", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Panc316-78R", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill316", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-316FHPH.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-316-6 Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Cpan 634", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Panc316-78R", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Cpan 634", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill316", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-316-6 Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-1420 Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Cpan 10-1T", pickAmount * 101)) && (CheckProductKitInventory("RANChor14-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Cpan 10-1T", pickAmount * 101);
                                    SubtractKitComponentFromInventory("RANChor14-1", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill14", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-1420 Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-1420 HWH \"Big Red\" Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Zip10-1", pickAmount * 101)) && (CheckProductKitInventory("RANChor14-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Zip10-1", pickAmount * 101);
                                    SubtractKitComponentFromInventory("RANChor14-1", pickAmount * 101);
                                    SubtractKitComponentFromInventory("Mdrill14", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-1420 HWH \"Big Red\" Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-5016 Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panch-516-114B", pickAmount * 52)) && (CheckProductKitInventory("Cpan-12-114", pickAmount * 52)) && (CheckProductKitInventory("Mdrill516", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Panch-516-114B", pickAmount * 52);
                                    SubtractKitComponentFromInventory("Cpan-12-114", pickAmount * 52);
                                    SubtractKitComponentFromInventory("Mdrill516", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-5016 Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "FA-5016 HWH Flanged":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panch-516-114B", pickAmount * 52)) && (CheckProductKitInventory("Zip12-114", pickAmount * 52)) && (CheckProductKitInventory("Mdrill516", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Panc-516-1148", pickAmount * 52);
                                    SubtractKitComponentFromInventory("Zip12-114", pickAmount * 52);
                                    SubtractKitComponentFromInventory("Mdrill516", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in FA-5016 HWH Flanged.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "GF-1816":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("GF-64-01 ST", pickAmount * 3)) && (CheckProductKitInventory("GF-90", pickAmount * 2)) && (CheckProductKitInventory("GF-45", pickAmount * 2)) && (CheckProductKitInventory("GF1428-45", pickAmount)) && (CheckProductKitInventory("GF1428-90", pickAmount)) && (CheckProductKitInventory("GF1428st", pickAmount * 3)) && (CheckProductKitInventory("316-str64-12", pickAmount * 6)) && (CheckProductKitInventory("GF-516-64-13", pickAmount * 5)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("GF-64-01 ST", pickAmount * 3);
                                    SubtractKitComponentFromInventory("GF-90", pickAmount * 2);
                                    SubtractKitComponentFromInventory("GF-45", pickAmount * 2);
                                    SubtractKitComponentFromInventory("GF1428-45", pickAmount * 1);
                                    SubtractKitComponentFromInventory("GF1428-90", pickAmount * 1);
                                    SubtractKitComponentFromInventory("GF1428st", pickAmount * 3);
                                    SubtractKitComponentFromInventory("316-str64-12", pickAmount * 6);
                                    SubtractKitComponentFromInventory("GF-516-64-13", pickAmount * 5);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in GF-1816.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "H-78 Hex Washer Slotted":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Zip8-12", pickAmount * 100)) && (CheckProductKitInventory("Zip8-34", pickAmount * 75)) && (CheckProductKitInventory("Zip8-1", pickAmount * 50)) && (CheckProductKitInventory("Zip8-114", pickAmount * 30)) && (CheckProductKitInventory("Zip8-112", pickAmount * 20)) && (CheckProductKitInventory("JC-2", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("Zip8-12", pickAmount * 100);
                                    SubtractKitComponentFromInventory("Zip8-34", pickAmount * 75);
                                    SubtractKitComponentFromInventory("Zip8-1", pickAmount * 50);
                                    SubtractKitComponentFromInventory("Zip8-114", pickAmount * 30);
                                    SubtractKitComponentFromInventory("Zip8-112", pickAmount * 20);
                                    SubtractKitComponentFromInventory("JC-2", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in H-78 Hex Washer Slotted.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "HC-14":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("HC-300-004", pickAmount * 2)) && (CheckProductKitInventory("HC-300-006", pickAmount * 2)) && (CheckProductKitInventory("HC-300-008", pickAmount * 2)) && (CheckProductKitInventory("HC-300-012", pickAmount * 2)) && (CheckProductKitInventory("HC-600-016", pickAmount * 2)) && (CheckProductKitInventory("HC-600-020", pickAmount * 2)) && (CheckProductKitInventory("HC-600-028", pickAmount * 2)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("HC-300-004", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-300-006", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-300-008", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-300-012", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-600-016", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-600-020", pickAmount * 2);
                                    SubtractKitComponentFromInventory("HC-600-028", pickAmount * 2);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in HC-14.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "LS-30":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("LAGS-38-1", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-112", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-2", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-212", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-3", pickAmount * 6)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("LAGS-38-1", pickAmount * 6);
                                    SubtractKitComponentFromInventory("LAGS-38-112", pickAmount * 6);
                                    SubtractKitComponentFromInventory("LAGS-38-2", pickAmount * 6);
                                    SubtractKitComponentFromInventory("LAGS-38-212", pickAmount * 6);
                                    SubtractKitComponentFromInventory("LAGS-38-3", pickAmount * 6);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in LS-30.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "MK-1812":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("MK-18-112L", pickAmount * 4)) && (CheckProductKitInventory("MK-316-112L", pickAmount * 3)) && (CheckProductKitInventory("MK14-112L", pickAmount * 3)) && (CheckProductKitInventory("MK-516-112", pickAmount * 2)) && (CheckProductKitInventory("MK-38-112L", pickAmount)) && (CheckProductKitInventory("MK12-2L", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("MK-18-112L", pickAmount * 4);
                                    SubtractKitComponentFromInventory("MK-316-112L", pickAmount * 3);
                                    SubtractKitComponentFromInventory("MK14-112L", pickAmount * 3);
                                    SubtractKitComponentFromInventory("MK-516-112", pickAmount * 2);
                                    SubtractKitComponentFromInventory("MK-38-112L", pickAmount);
                                    SubtractKitComponentFromInventory("MK12-2L", pickAmount);

                                }

                                else
                                {
                                    string message = "Please check quantity of items in MK-1812.";
                                    MessageBox.Show(message);
                                }
                                break;

                            case "NW-12":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("632KLN", pickAmount * 6) && (CheckProductKitInventory("632SLW6", pickAmount * 6)) && (CheckProductKitInventory("632MSN", pickAmount * 10)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 10)) && (CheckProductKitInventory("832KLN", pickAmount * 6)) && (CheckProductKitInventory("832SLW8", pickAmount * 6)) && (CheckProductKitInventory("832MSN", pickAmount * 10)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 10)) && (CheckProductKitInventory("1032KLN", pickAmount * 6)) && (CheckProductKitInventory("1032SLW10", pickAmount * 6)) && (CheckProductKitInventory("1032HN", pickAmount * 10)) && (CheckProductKitInventory("SAEFW10", pickAmount * 20)) && (CheckProductKitInventory("1032SLW10", pickAmount * 6)) && (CheckProductKitInventory("1024KN", pickAmount * 6)) && (CheckProductKitInventory("DWS61", pickAmount * 10)) && (CheckProductKitInventory("SAEFW14", pickAmount * 6)) && (CheckProductKitInventory("SLW14", pickAmount * 6)) && (CheckProductKitInventory("KLN14", pickAmount * 6)) && (CheckProductKitInventory("HFN14", pickAmount * 6)) && (CheckProductKitInventory("HFN516", pickAmount *6)) && (CheckProductKitInventory("KLN516", pickAmount * 6)) && (CheckProductKitInventory("SAEFW516", pickAmount * 6)) && (CheckProductKitInventory("SLW516", pickAmount * 6)) && (CheckProductKitInventory("HFN38", pickAmount * 6)) && (CheckProductKitInventory("SLW38", pickAmount * 6)) && (CheckProductKitInventory("SAEFW38", pickAmount * 6)) && (CheckProductKitInventory("KLN38", pickAmount * 6)))
                                {
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("632KLN", pickAmount * 6);
                                    SubtractKitComponentFromInventory("632SLW6", pickAmount * 6);
                                    SubtractKitComponentFromInventory("632MSN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEF632-6", pickAmount * 10);
                                    SubtractKitComponentFromInventory("832KLN", pickAmount * 6);
                                    SubtractKitComponentFromInventory("832SLW8", pickAmount * 6);
                                    SubtractKitComponentFromInventory("832MSN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEF832-8", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032KLN", pickAmount * 6);
                                    SubtractKitComponentFromInventory("1032SLW10", pickAmount * 6);
                                    SubtractKitComponentFromInventory("1032HN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 20);
                                    SubtractKitComponentFromInventory("1032SLW10", pickAmount * 6);
                                    SubtractKitComponentFromInventory("1024KN", pickAmount * 6);
                                    SubtractKitComponentFromInventory("DWS61", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEFW14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SLW14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("KLN14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("HFN14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("HFN516", pickAmount * 6);
                                    SubtractKitComponentFromInventory("KLN516", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SAEFW516", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SLW516", pickAmount * 6);
                                    SubtractKitComponentFromInventory("HFN38", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SLW38", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SAEFW38", pickAmount * 6);
                                    SubtractKitComponentFromInventory("KLN38", pickAmount * 6);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in NW-12.";
                                    MessageBox.Show(message);
                                }
                                break;

                            case "NW-832-1032":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("632MSN", pickAmount * 10)) && (CheckProductKitInventory("632KLN", pickAmount * 8)) && (CheckProductKitInventory("632NYN", pickAmount * 8)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 20)) && (CheckProductKitInventory("632SLW6", pickAmount * 8)) && (CheckProductKitInventory("Cnut6-32", pickAmount * 6)) && (CheckProductKitInventory("632-112MS", pickAmount)) && (CheckProductKitInventory("832MSN", pickAmount * 30)) && (CheckProductKitInventory("832KLN", pickAmount * 20)) && (CheckProductKitInventory("832NYN", pickAmount * 20)) && (CheckProductKitInventory("832SFN", pickAmount * 20)) && (CheckProductKitInventory("Cnut8-32", pickAmount * 5)) && (CheckProductKitInventory("832WN", pickAmount * 5)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 50)) && (CheckProductKitInventory("832SLW8", pickAmount * 20)) && (CheckProductKitInventory("832-12MS", pickAmount * 12)) && (CheckProductKitInventory("832-34MS", pickAmount * 12)) && (CheckProductKitInventory("832-114MS", pickAmount)) && (CheckProductKitInventory("1032HN", pickAmount * 15)) && (CheckProductKitInventory("1032KLN", pickAmount * 10)) && (CheckProductKitInventory("1032NLN", pickAmount * 10)) && (CheckProductKitInventory("1032SFN", pickAmount * 10)) && (CheckProductKitInventory("1032CN", pickAmount * 5)) && (CheckProductKitInventory("1032WN", pickAmount * 5)) && (CheckProductKitInventory("1032SLW10", pickAmount * 20)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)) && (CheckProductKitInventory("1032114MS", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("632MSN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("632KLN", pickAmount * 8);
                                    SubtractKitComponentFromInventory("632NYN", pickAmount * 8);
                                    SubtractKitComponentFromInventory("SAEF632-6", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632SLW6", pickAmount * 8);
                                    SubtractKitComponentFromInventory("Cnut6-32", pickAmount * 6);
                                    SubtractKitComponentFromInventory("632-112MS", pickAmount);
                                    SubtractKitComponentFromInventory("832MSN", pickAmount * 30);
                                    SubtractKitComponentFromInventory("832KLN", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832NYN", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832SFN", pickAmount * 20);
                                    SubtractKitComponentFromInventory("Cnut8-32", pickAmount * 5);
                                    SubtractKitComponentFromInventory("832WN", pickAmount * 5);
                                    SubtractKitComponentFromInventory("SAEF832-8", pickAmount * 50);
                                    SubtractKitComponentFromInventory("832SLW8", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832-12MS", pickAmount * 12);
                                    SubtractKitComponentFromInventory("832-34MS", pickAmount * 12);
                                    SubtractKitComponentFromInventory("832-114MS", pickAmount);
                                    SubtractKitComponentFromInventory("1032HN", pickAmount * 15);
                                    SubtractKitComponentFromInventory("1032KLN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032NLN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032SFN", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032CN", pickAmount * 5);
                                    SubtractKitComponentFromInventory("1032WN", pickAmount * 5);
                                    SubtractKitComponentFromInventory("1032SLW10", pickAmount * 20);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 50);
                                    SubtractKitComponentFromInventory("1032114MS", pickAmount);



                                }

                                else
                                {
                                    string message = "Please check quantity of items in NW-832-1032.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "NY-80":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("NLIstop-14", pickAmount * 30)) && (CheckProductKitInventory("NLIstop-516", pickAmount * 6)) && (CheckProductKitInventory("NLIstop-38", pickAmount * 20)) && (CheckProductKitInventory("NLIstop-12", pickAmount * 24)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("NLIstop-14", pickAmount * 30);
                                    SubtractKitComponentFromInventory("NLIstop-516", pickAmount * 6);
                                    SubtractKitComponentFromInventory("NLIstop-38", pickAmount * 20);
                                    SubtractKitComponentFromInventory("NLIstop-12", pickAmount * 24);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in NY-80.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SB-316":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("102438MS", pickAmount * 20)) && (CheckProductKitInventory("102412MS", pickAmount * 20)) && (CheckProductKitInventory("102434MS", pickAmount * 15)) && (CheckProductKitInventory("10241MS", pickAmount * 15)) && (CheckProductKitInventory("1024114MS", pickAmount * 10)) && (CheckProductKitInventory("1024112MS", pickAmount * 10)) && (CheckProductKitInventory("10242MS", pickAmount * 10)) && (CheckProductKitInventory("1024MSN", pickAmount * 100)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("102438MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("102412MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("102434MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("10241MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("1024114MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1024112MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("10242MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1024MSN", pickAmount * 100);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SB-316.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SB-632":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("632-38MS", pickAmount * 25)) && (CheckProductKitInventory("632-12MS", pickAmount * 25)) && (CheckProductKitInventory("632-34MS", pickAmount * 20)) && (CheckProductKitInventory("632-1MS", pickAmount * 20)) && (CheckProductKitInventory("632-112MS", pickAmount * 20)) && (CheckProductKitInventory("632-114MS", pickAmount * 20)) && (CheckProductKitInventory("632-2MS", pickAmount * 20)) && (CheckProductKitInventory("632MSN", pickAmount * 150)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("632-38MS", pickAmount * 25);
                                    SubtractKitComponentFromInventory("632-12MS", pickAmount * 25);
                                    SubtractKitComponentFromInventory("632-34MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632-1MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632-112MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632-114MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632-2MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("632MSN", pickAmount * 150);
                                    SubtractKitComponentFromInventory("SAEF632-6", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SB-632.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SB-832":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("832-38MS", pickAmount * 20)) && (CheckProductKitInventory("832-12MS", pickAmount * 20)) && (CheckProductKitInventory("832-34MS", pickAmount * 20)) && (CheckProductKitInventory("832-1MS", pickAmount * 20)) && (CheckProductKitInventory("832-114MS", pickAmount * 15)) && (CheckProductKitInventory("832-112MS", pickAmount * 15)) && (CheckProductKitInventory("832-2MS", pickAmount * 15)) && (CheckProductKitInventory("832MSN", pickAmount * 125)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("832-38MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832-12MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832-34MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832-1MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("832-114MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("832-112MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("832-2MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("832MSN", pickAmount * 125);
                                    SubtractKitComponentFromInventory("SAEF832-8", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SB-832.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SB-1032":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("103238MS", pickAmount * 20)) && (CheckProductKitInventory("103212MS", pickAmount * 20)) && (CheckProductKitInventory("103234MS", pickAmount * 15)) && (CheckProductKitInventory("10321MS", pickAmount * 15)) && (CheckProductKitInventory("1032114MS", pickAmount * 10)) && (CheckProductKitInventory("1032112MS", pickAmount * 10)) && (CheckProductKitInventory("10322MS", pickAmount * 10)) && (CheckProductKitInventory("1032SLW10", pickAmount * 100)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("103238MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("103212MS", pickAmount * 20);
                                    SubtractKitComponentFromInventory("103234MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("10321MS", pickAmount * 15);
                                    SubtractKitComponentFromInventory("1032114MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032112MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("10322MS", pickAmount * 10);
                                    SubtractKitComponentFromInventory("1032SLW10", pickAmount * 100);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SB-1032.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SB-1420":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("MS14-12", pickAmount * 30)) && (CheckProductKitInventory("MS14-34", pickAmount * 16)) && (CheckProductKitInventory("MS14-1", pickAmount * 10)) && (CheckProductKitInventory("MS14-114", pickAmount * 8)) && (CheckProductKitInventory("MS14-112", pickAmount * 8)) && (CheckProductKitInventory("MS14-2", pickAmount * 6)) && (CheckProductKitInventory("HFN14", pickAmount * 75)) && (CheckProductKitInventory("SAEFW14", pickAmount * 50)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("MS14-12", pickAmount * 30);
                                    SubtractKitComponentFromInventory("MS14-34", pickAmount * 16);
                                    SubtractKitComponentFromInventory("MS14-1", pickAmount * 10);
                                    SubtractKitComponentFromInventory("MS14-114", pickAmount * 8);
                                    SubtractKitComponentFromInventory("MS14-112", pickAmount * 8);
                                    SubtractKitComponentFromInventory("MS14-2", pickAmount * 6);
                                    SubtractKitComponentFromInventory("HFN14", pickAmount * 75);
                                    SubtractKitComponentFromInventory("SAEFW14", pickAmount * 50);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SB-1420.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SBH-1420":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("USSFW14", pickAmount * 40)) && (CheckProductKitInventory("HFN14", pickAmount * 40)) && (CheckProductKitInventory("KLN14", pickAmount * 20)) && (CheckProductKitInventory("SLW14", pickAmount * 20)) && (CheckProductKitInventory("FW14-1", pickAmount * 10)) && (CheckProductKitInventory("TB14-34", pickAmount * 20)) && (CheckProductKitInventory("TB14-1", pickAmount * 15)) && (CheckProductKitInventory("TB14-112", pickAmount * 10)) && (CheckProductKitInventory("TB14-2", pickAmount * 10)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("USSFW14", pickAmount * 40);
                                    SubtractKitComponentFromInventory("HFN14", pickAmount * 40);
                                    SubtractKitComponentFromInventory("KLN14", pickAmount * 20);
                                    SubtractKitComponentFromInventory("SLW14", pickAmount * 20);
                                    SubtractKitComponentFromInventory("FW14-1", pickAmount * 10);
                                    SubtractKitComponentFromInventory("TB14-34", pickAmount * 20);
                                    SubtractKitComponentFromInventory("TB14-1", pickAmount * 15);
                                    SubtractKitComponentFromInventory("TB14-112", pickAmount * 10);
                                    SubtractKitComponentFromInventory("TB14-2", pickAmount * 10);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SBH-1420.";
                                    MessageBox.Show(message);
                                }
                                break;

                            case "SBH-3816":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("TB38-34", pickAmount * 12)) && (CheckProductKitInventory("TB38-1", pickAmount * 8)) && (CheckProductKitInventory("TB38-112", pickAmount * 6)) && (CheckProductKitInventory("TB38-2", pickAmount * 4)) && (CheckProductKitInventory("USSFW38", pickAmount * 20)) && (CheckProductKitInventory("HFN38", pickAmount * 20)) && (CheckProductKitInventory("KLN38", pickAmount * 8)) && (CheckProductKitInventory("SLW38", pickAmount * 10)) && (CheckProductKitInventory("FW38-112", pickAmount * 6)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("TB38-34", pickAmount * 12);
                                    SubtractKitComponentFromInventory("TB38-1", pickAmount * 8);
                                    SubtractKitComponentFromInventory("TB38-112", pickAmount * 6);
                                    SubtractKitComponentFromInventory("TB38-2", pickAmount * 4);
                                    SubtractKitComponentFromInventory("USSFW38", pickAmount * 20);
                                    SubtractKitComponentFromInventory("HFN38", pickAmount * 20);
                                    SubtractKitComponentFromInventory("KLN38", pickAmount * 8);
                                    SubtractKitComponentFromInventory("SLW38", pickAmount * 10);
                                    SubtractKitComponentFromInventory("FW38-112", pickAmount * 6);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SBH-3816.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SBH-5018":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("TB516-34", pickAmount * 15)) && (CheckProductKitInventory("TB516-1", pickAmount * 10)) && (CheckProductKitInventory("TB516-112", pickAmount * 8)) && (CheckProductKitInventory("TB516-2", pickAmount * 6)) && (CheckProductKitInventory("USSFW516", pickAmount * 25)) && (CheckProductKitInventory("HFN516", pickAmount * 25)) && (CheckProductKitInventory("KLN516", pickAmount * 12)) && (CheckProductKitInventory("SLW516", pickAmount * 12)) && (CheckProductKitInventory("FW516-114", pickAmount * 8)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("TB516-34", pickAmount * 15);
                                    SubtractKitComponentFromInventory("TB516-1", pickAmount * 10);
                                    SubtractKitComponentFromInventory("TB516-112", pickAmount * 8);
                                    SubtractKitComponentFromInventory("TB516-2", pickAmount * 6);
                                    SubtractKitComponentFromInventory("USSFW516", pickAmount * 25);
                                    SubtractKitComponentFromInventory("HFN516", pickAmount * 25);
                                    SubtractKitComponentFromInventory("KLN516", pickAmount * 12);
                                    SubtractKitComponentFromInventory("SLW516", pickAmount * 12);
                                    SubtractKitComponentFromInventory("FW516-114", pickAmount * 8);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SBH-5018.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SLW-358":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)) && (CheckProductKitInventory("SLW14", pickAmount * 40)) && (CheckProductKitInventory("SLW516", pickAmount * 40)) && (CheckProductKitInventory("SLW38", pickAmount * 25)) && (CheckProductKitInventory("SLW12", pickAmount * 15)) && (CheckProductKitInventory("SLW58", pickAmount * 10)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 50);
                                    SubtractKitComponentFromInventory("SLW14", pickAmount * 40);
                                    SubtractKitComponentFromInventory("SLW516", pickAmount * 40);
                                    SubtractKitComponentFromInventory("SLW38", pickAmount * 25);
                                    SubtractKitComponentFromInventory("SLW12", pickAmount * 15);
                                    SubtractKitComponentFromInventory("SLW58", pickAmount * 10);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SLW-358.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "SS-500":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("516-18NC14", pickAmount * 6)) && (CheckProductKitInventory("516-18NC38", pickAmount * 4)) && (CheckProductKitInventory("516-18NC12", pickAmount * 4)) && (CheckProductKitInventory("516-18NC34", pickAmount * 2)) && (CheckProductKitInventory("SS5-1420-14", pickAmount * 6)) && (CheckProductKitInventory("SS5-1420-38", pickAmount * 4)) && (CheckProductKitInventory("SS5-1420-12", pickAmount * 4)) && (CheckProductKitInventory("SS5-1420-34", pickAmount * 2)) && (CheckProductKitInventory("1024NC14", pickAmount * 6)) && (CheckProductKitInventory("1024NC38", pickAmount * 4)) && (CheckProductKitInventory("1024NC12", pickAmount * 4)) && (CheckProductKitInventory("516-24NF14", pickAmount * 6)) && (CheckProductKitInventory("516-24NF38", pickAmount * 4)) && (CheckProductKitInventory("516-24NF12", pickAmount * 4)) && (CheckProductKitInventory("516-24NF34", pickAmount * 2)) && (CheckProductKitInventory("SS5-1428-14", pickAmount * 6)) && (CheckProductKitInventory("SS5-1428-38", pickAmount * 4)) && (CheckProductKitInventory("SS5-1428-12", pickAmount * 4)) && (CheckProductKitInventory("SS5-1428-34", pickAmount * 2)) && (CheckProductKitInventory("1032NF14", pickAmount * 6)) && (CheckProductKitInventory("1032NF38", pickAmount * 4)) && (CheckProductKitInventory("1032NF12", pickAmount * 4)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("516-18NC14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("516-18NC38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("516-18NC12", pickAmount * 4);
                                    SubtractKitComponentFromInventory("516-18NC34", pickAmount * 2);
                                    SubtractKitComponentFromInventory("SS5-1420-14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SS5-1420-38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("SS5-1420-12", pickAmount * 4);
                                    SubtractKitComponentFromInventory("SS5-1420-34", pickAmount * 2);
                                    SubtractKitComponentFromInventory("1024NC14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("1024NC38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("1024NC12", pickAmount * 4);
                                    SubtractKitComponentFromInventory("516-24NF14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("516-24NF38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("516-24NF12", pickAmount * 4);
                                    SubtractKitComponentFromInventory("516-24NF34", pickAmount * 2);
                                    SubtractKitComponentFromInventory("SS5-1428-14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("SS5-1428-38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("SS5-1428-12", pickAmount * 4);
                                    SubtractKitComponentFromInventory("SS5-1428-34", pickAmount * 2);
                                    SubtractKitComponentFromInventory("1032NF14", pickAmount * 6);
                                    SubtractKitComponentFromInventory("1032NF38", pickAmount * 4);
                                    SubtractKitComponentFromInventory("1032NF12", pickAmount * 4);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in SS-500.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-10":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek1012", pickAmount * 25)) && (CheckProductKitInventory("TEK1034", pickAmount * 25)) && (CheckProductKitInventory("Tek10-1", pickAmount * 20)) && (CheckProductKitInventory("Tek10-114", pickAmount * 15)) && (CheckProductKitInventory("Tek10-112", pickAmount * 15)) && (CheckProductKitInventory("jc-15", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("Tek1012", pickAmount * 25);
                                    SubtractKitComponentFromInventory("TEK1034", pickAmount * 25);
                                    SubtractKitComponentFromInventory("Tek10-1", pickAmount * 20);
                                    SubtractKitComponentFromInventory("Tek10-114", pickAmount * 15);
                                    SubtractKitComponentFromInventory("Tek10-112", pickAmount * 15);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-10.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-8":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("TEK8-12", pickAmount * 40)) && (CheckProductKitInventory("TEK8-34", pickAmount * 30)) && (CheckProductKitInventory("TEK8-1", pickAmount * 30)) && (CheckProductKitInventory("TEK8-114", pickAmount * 30)) && (CheckProductKitInventory("TEK8-112", pickAmount * 15)) && (CheckProductKitInventory("JC-2", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("TEK8-12", pickAmount * 40);
                                    SubtractKitComponentFromInventory("TEK8-34", pickAmount * 30);
                                    SubtractKitComponentFromInventory("TEK8-1", pickAmount * 30);
                                    SubtractKitComponentFromInventory("TEK8-114", pickAmount * 30);
                                    SubtractKitComponentFromInventory("TEK8-112", pickAmount * 15);
                                    SubtractKitComponentFromInventory("JC-2", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-8.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-10-5834":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("jc-15", pickAmount)) && (CheckProductKitInventory("TEK1058", pickAmount * 100)) && (CheckProductKitInventory("TEK1034", pickAmount * 100)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("JC-15", pickAmount);
                                    SubtractKitComponentFromInventory("TEK1058", pickAmount * 100);
                                    SubtractKitComponentFromInventory("TEK1034", pickAmount * 100);

                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-10-5834.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-12":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek12-34", pickAmount * 12)) && (CheckProductKitInventory("Tek12-1", pickAmount * 8)) && (CheckProductKitInventory("Tek12-114", pickAmount * 7)) && (CheckProductKitInventory("Tek12-112", pickAmount * 6)) && (CheckProductKitInventory("Tek12-2", pickAmount * 5)) && (CheckProductKitInventory("jc-15", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("Tek12-34", pickAmount * 12);
                                    SubtractKitComponentFromInventory("Tek12-1", pickAmount * 8);
                                    SubtractKitComponentFromInventory("Tek12-114", pickAmount * 7);
                                    SubtractKitComponentFromInventory("Tek12-112", pickAmount * 6);
                                    SubtractKitComponentFromInventory("Tek12-2", pickAmount * 5);
                                    SubtractKitComponentFromInventory("JC-15", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-12.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-14":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek14-34", pickAmount * 10)) && (CheckProductKitInventory("Tek14-1", pickAmount * 7)) && (CheckProductKitInventory("Tek14-114", pickAmount * 4)) && (CheckProductKitInventory("Tek14-112", pickAmount * 4)) && (CheckProductKitInventory("Tek14-2", pickAmount * 4)) && (CheckProductKitInventory("JC-30", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("6Box", pickAmount);
                                    SubtractKitComponentFromInventory("Tek14-34", pickAmount * 10);
                                    SubtractKitComponentFromInventory("Tek14-1", pickAmount * 7);
                                    SubtractKitComponentFromInventory("Tek14-114", pickAmount * 4);
                                    SubtractKitComponentFromInventory("Tek14-112", pickAmount * 4);
                                    SubtractKitComponentFromInventory("Tek14-2", pickAmount * 4);
                                    SubtractKitComponentFromInventory("JC-30", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-14.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TK-141":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Tek14-1", pickAmount * 75)) && (CheckProductKitInventory("JC-30", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("2Box", pickAmount);
                                    SubtractKitComponentFromInventory("Tek14-1", pickAmount * 75);
                                    SubtractKitComponentFromInventory("JC-30", pickAmount);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TK-141.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "TSHZ-1010":
                                if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("ZIP10-12", pickAmount * 70)) && (CheckProductKitInventory("ZIP1034", pickAmount * 50)) && (CheckProductKitInventory("Zip10-1", pickAmount * 35)) && (CheckProductKitInventory("ZIP10-114", pickAmount * 15)) && (CheckProductKitInventory("ZIP10-112", pickAmount * 15)) && (CheckProductKitInventory("ZIP102", pickAmount * 15)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                SubtractKitComponentFromInventory("6Box", pickAmount);
                                SubtractKitComponentFromInventory("ZIP10-12", pickAmount * 70);
                                SubtractKitComponentFromInventory("ZIP1034", pickAmount * 50);
                                SubtractKitComponentFromInventory("ZIP10-1", pickAmount * 35);
                                SubtractKitComponentFromInventory("ZIP10-114", pickAmount * 15);
                                SubtractKitComponentFromInventory("ZIP10-112", pickAmount * 15);
                                SubtractKitComponentFromInventory("ZIP102", pickAmount * 15);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in TSHZ-1010.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "W-100 Plated washers":
                                if ((CheckProductKitInventory("1Box", pickAmount)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 12)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 10)) && (CheckProductKitInventory("SAEFW10", pickAmount * 10)) && (CheckProductKitInventory("SAEFW14", pickAmount * 10)) && (CheckProductKitInventory("SAEFW516", pickAmount * 8)) && (CheckProductKitInventory("SAEFW38", pickAmount * 8)) && (CheckProductKitInventory("USSFW14", pickAmount * 10)) && (CheckProductKitInventory("USSFW516", pickAmount * 10)) && (CheckProductKitInventory("USSFW12", pickAmount * 6)) && (CheckProductKitInventory("USSFW38", pickAmount * 8)) && (CheckProductKitInventory("FW14-1", pickAmount * 10)) && (CheckProductKitInventory("FW316-1", pickAmount * 10)) && (CheckProductKitInventory("FW38-112", pickAmount * 6)) && (CheckProductKitInventory("FW12-112", pickAmount * 3)) && (CheckProductKitInventory("FW516-114", pickAmount * 5)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                    SubtractKitComponentFromInventory("1Box", pickAmount);
                                    SubtractKitComponentFromInventory("SAEF632-6", pickAmount * 12);
                                    SubtractKitComponentFromInventory("SAEF832-8", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEFW10", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEFW14", pickAmount * 10);
                                    SubtractKitComponentFromInventory("SAEFW516", pickAmount * 8);
                                    SubtractKitComponentFromInventory("SAEFW38", pickAmount * 8);
                                    SubtractKitComponentFromInventory("USSFW14", pickAmount * 10);
                                    SubtractKitComponentFromInventory("USSFW516", pickAmount * 10);
                                    SubtractKitComponentFromInventory("USSFW12", pickAmount * 6);
                                    SubtractKitComponentFromInventory("USSFW38", pickAmount * 8);
                                    SubtractKitComponentFromInventory("FW14-1", pickAmount * 10);
                                    SubtractKitComponentFromInventory("FW316-1", pickAmount * 10);
                                    SubtractKitComponentFromInventory("FW38-112", pickAmount * 6);
                                    SubtractKitComponentFromInventory("FW12-112", pickAmount * 3);
                                    SubtractKitComponentFromInventory("FW516-114", pickAmount * 5);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in W-100 Plated washers.";
                                    MessageBox.Show(message);
                                }
                                break;
                            case "WE-383":
                                if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("HFN38", pickAmount * 13)) && (CheckProductKitInventory("SAEFW38", pickAmount * 13)) && (CheckProductKitInventory("WedgeAnc-38-3", pickAmount * 12)) && (CheckProductKitInventory("Mdrill38", pickAmount)))
                                {
                                    removePickRow(placeholder.PickID);
                                    updatePickDB(placeholder);
                                SubtractKitComponentFromInventory("2Box", pickAmount);
                                SubtractKitComponentFromInventory("HFN38", pickAmount * 13);
                                SubtractKitComponentFromInventory("SAEFW38", pickAmount * 13);
                                SubtractKitComponentFromInventory("WedgeAnc-38-3", pickAmount * 12);
                                SubtractKitComponentFromInventory("Mdrill38", pickAmount * 1);
                                }

                                else
                                {
                                    string message = "Please check quantity of items in WE-383.";
                                    MessageBox.Show(message);
                                }
                                break;
                        }
                }
            }
        }

        public void ReturnKitComponentToInventory(string KitComponent, int amountPicked)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == KitComponent);

                if (result != null)
                {
                    result.ProductQuantity = result.ProductQuantity + amountPicked;
                    DB.SaveChanges();
                }
            }
        }

        public void SubtractKitComponentFromInventory(string KitComponent, int amountPicked)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == KitComponent);

                if (result != null)
                {
                    result.ProductQuantity = result.ProductQuantity - amountPicked;
                    DB.SaveChanges();
                }
            }
        }

        public bool CheckProductKitInventory(string KitComponent, int amountPicked)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == KitComponent);

                if (result != null)
                {
                   if (result.ProductQuantity >= amountPicked)
                    {
                        return true;
                    }

                   else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;
                }

                    
            }
        }

        public void UpdateKitItem(Picking placeholder)
        {
            using (var DB = new CamcoEntities())
            {
                var result = DB.Inventories.SingleOrDefault(x => x.ProductName == placeholder.ProductName);

                if (result != null)
                {
                    result.ProductQuantity = result.ProductQuantity - placeholder.QuantityPicked;
                    DB.SaveChanges();
                }
            }
        }

        public void updatePickDB(Picking placeholder)
        {
            /* error here */
            using (var db = new CamcoEntities())
            {
                db.Pickings.Add(placeholder);
                db.SaveChanges();
            }
        }

        public void setNewPickID(int pickID)
        {
           
        }

        public void removeOldLineDB()
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<InvoiceLineItem> result = DB.InvoiceLineItems.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        DB.InvoiceLineItems.Remove(result[i]);
                        DB.SaveChanges();
                    }
                }

                else
                {
                    string error = "removeOldLineDB method failed.";
                    MessageBox.Show(error);
                }
            }
        }

        public void removeOldInvoiceDB()
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textSONumber.Text);

                if (result != null)
                {
                    DB.Invoices.Remove(result);
                    DB.SaveChanges();
                }

                else
                {
                    string error = "removeOldInvoiceDB method failed.";
                    MessageBox.Show(error);
                }
            }
        }

        public void removePickDB()
        {
            using (var DB = new CamcoEntities())
            {
                int intSO = convertToInt(textSONumber.Text);
                List<Picking> result = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        DB.Pickings.Remove(result[i]);
                        DB.SaveChanges();
                    }
                }
            }
        }


        public void removePickRow(int pickID)
        {
            using (var DB = new CamcoEntities())
            {
                Picking result = DB.Pickings.SingleOrDefault(x => x.PickID == pickID);

                if (result != null)
                {
                    DB.Pickings.Remove(result);
                    DB.SaveChanges();
                }
            }
        }

        public void resetPickAndShip(int intSO)
        {
            using (var DB = new CamcoEntities())
            {
                List<Picking> resultPick = DB.Pickings.Where(x => x.InvoiceSO == intSO).ToList();
                List<Shipping> resultShip = DB.Shippings.Where(x => x.InvoiceSO == intSO).ToList();

                if (resultPick != null)
                {
                    for (int i = 0; i < resultPick.Count; i++)
                    {
                        resultPick[i].QuantityPicked = 0;
                        resultPick[i].QuantityRemaining = resultPick[i].Quantity;
                    }
                }

                if (resultShip != null)
                {
                    for (int k = 0; k < resultShip.Count; k++)
                    {
                        DB.Shippings.Remove(resultShip[k]);
                        DB.SaveChanges();
                    }
                }
            }
        }

        public void voidPick(int intSO)
        {
            /* check shipping DB for anything already picked with matching invoiceSO, remove, and readd to inventory*/
            using (var DB = new CamcoEntities())
            {
                List<Shipping> resultShip = DB.Shippings.Where(x => x.InvoiceSO == intSO).ToList();

                if (resultShip != null)
                {
                    for (int i = 0; i < resultShip.Count; i++)
                    {
                        string prodName = resultShip[i].ProductName;
                        Inventory resultInventory = DB.Inventories.SingleOrDefault(x => x.ProductName == prodName);

                        if (resultInventory != null)
                        {
                            if (resultShip[i].ProductDescription == "KIT")
                            {
                                int pickAmount = (int)(resultShip[i].QuantityPicked);
                                switch (resultShip[i].ProductName)
                                {
                                    case "DI-38 Drop-in Anchors":
                                        /* if ((CheckProductKitInventory("1box", pickAmount)) && (CheckProductKitInventory("Drop-in 38", pickAmount * 12)) && (CheckProductKitInventory("Mdrill12", pickAmount)) && (CheckProductKitInventory("38Stool", pickAmount))) 
                                        {
                                             need to readd all items inside kit to inventory
                                            ReturnKitComponentToInventory("1box", pickAmount);
                                        } */
                                        ReturnKitComponentToInventory("1box", pickAmount);
                                        ReturnKitComponentToInventory("Drop-in 38", pickAmount * 12);
                                        ReturnKitComponentToInventory("Mdrill12", pickAmount);
                                        ReturnKitComponentToInventory("38STool", pickAmount);

                                        break;   

                                   /* case "DWS-6 Drywall Screw":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("DWS61", pickAmount * 100)) && (CheckProductKitInventory("DWS6158", pickAmount * 100)) && (CheckProductKitInventory("PBit2", pickAmount)) && (CheckProductKitInventory("Mbholder", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in DWS-6 Drywall Screw.";
                                            MessageBox.Show(message);
                                        }
                                        break;

                                    case "DWS-8 Drywall Screw":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("DWS8-212", pickAmount * 50)) && (CheckProductKitInventory("DWS8-3", pickAmount * 50)) && (CheckProductKitInventory("PBit2", pickAmount)) && (CheckProductKitInventory("Mbholder", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in DWS-8 Drywall Screw.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "EZ-2 Plastic anchors":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panchor-white", pickAmount * 60)) && (CheckProductKitInventory("pflat634", pickAmount * 60)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in EZ-2 Plastic anchors.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "EZ-5 Metal anchor":
                                        if ((CheckProductKitInventory("1box", pickAmount)) && (CheckProductKitInventory("Manchor", pickAmount * 50)) && (CheckProductKitInventory("Cpan8-114", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in EZ-5 Metal anchor.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "F-400 Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("BAnchor141", pickAmount * 100)) && (CheckProductKitInventory("Cpan 10-1T", pickAmount * 100)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in F-400 Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "F-400HWH Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("BAnchor141", pickAmount * 100)) && (CheckProductKitInventory("Zip10-1", pickAmount * 100)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in F-400HWH Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-316 Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Cpan8-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-316 Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-316FH PH-6":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("pflat634", pickAmount * 101)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-316FH PH-6.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-316FHPH":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("pflat8-1", pickAmount * 101)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-316FHPH.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-316-6 Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panc316-78R", pickAmount * 101)) && (CheckProductKitInventory("Cpan 634", pickAmount * 101)) && (CheckProductKitInventory("Mdrill316", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-316-6 Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-1420 Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Cpan 10-1T", pickAmount * 101)) && (CheckProductKitInventory("RANChor14-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-1420 Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-1420 HWH \"Big Red\" Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Zip10-1", pickAmount * 101)) && (CheckProductKitInventory("RANChor14-1", pickAmount * 101)) && (CheckProductKitInventory("Mdrill14", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-1420 HWH \"Big Red\" Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-5016 Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panch-516-114B", pickAmount * 52)) && (CheckProductKitInventory("Cpan-12-114", pickAmount * 52)) && (CheckProductKitInventory("Mdrill516", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-5016 Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "FA-5016 HWH Flanged":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Panch-516-114B", pickAmount * 52)) && (CheckProductKitInventory("Zip12-114", pickAmount * 52)) && (CheckProductKitInventory("Mdrill516", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in FA-5016 HWH Flanged.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "GF-1816":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("GF-64-01 ST", pickAmount * 3)) && (CheckProductKitInventory("GF-90", pickAmount * 2)) && (CheckProductKitInventory("GF-45", pickAmount * 2)) && (CheckProductKitInventory("GF1428-45", pickAmount)) && (CheckProductKitInventory("GF1428-90", pickAmount)) && (CheckProductKitInventory("GF1428st", pickAmount * 3)) && (CheckProductKitInventory("316-str64-12", pickAmount * 6)) && (CheckProductKitInventory("GF-516-64-13", pickAmount * 5)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in GF-1816.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "H-78 Hex Washer Slotted":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Zip8-12", pickAmount * 100)) && (CheckProductKitInventory("Zip8-34", pickAmount * 75)) && (CheckProductKitInventory("Zip8-1", pickAmount * 50)) && (CheckProductKitInventory("Zip8-114", pickAmount * 30)) && (CheckProductKitInventory("Zip8-112", pickAmount * 20)) && (CheckProductKitInventory("JC-2", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in H-78 Hex Washer Slotted.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "HC-14":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("HC-300-004", pickAmount * 2)) && (CheckProductKitInventory("HC-300-006", pickAmount * 2)) && (CheckProductKitInventory("HC-300-008", pickAmount * 2)) && (CheckProductKitInventory("HC-300-012", pickAmount * 2)) && (CheckProductKitInventory("HC-600-016", pickAmount * 2)) && (CheckProductKitInventory("HC-600-020", pickAmount * 2)) && (CheckProductKitInventory("HC-600-028", pickAmount * 2)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in HC-14.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "LS-30":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("LAGS-38-1", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-112", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-2", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-212", pickAmount * 6)) && (CheckProductKitInventory("LAGS-38-3", pickAmount * 6)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in LS-30.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "MK-1812":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("MK-18-112L", pickAmount * 4)) && (CheckProductKitInventory("MK-316-112L", pickAmount * 3)) && (CheckProductKitInventory("MK14-112L", pickAmount * 3)) && (CheckProductKitInventory("MK-516-112", pickAmount * 2)) && (CheckProductKitInventory("MK-38-112L", pickAmount)) && (CheckProductKitInventory("MK12-2L", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in MK-1812.";
                                            MessageBox.Show(message);
                                        }
                                        break;

                                    case "NW-832-1032":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("632MSN", pickAmount * 10)) && (CheckProductKitInventory("632KLN", pickAmount * 8)) && (CheckProductKitInventory("632NYN", pickAmount * 8)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 20)) && (CheckProductKitInventory("632SLW6", pickAmount * 8)) && (CheckProductKitInventory("Cnut6-32", pickAmount * 6)) && (CheckProductKitInventory("632-112MS", pickAmount)) && (CheckProductKitInventory("832MSN", pickAmount * 30)) && (CheckProductKitInventory("832KLN", pickAmount * 20)) && (CheckProductKitInventory("832NYN", pickAmount * 20)) && (CheckProductKitInventory("832SFN", pickAmount * 20)) && (CheckProductKitInventory("Cnut8-32", pickAmount * 5)) && (CheckProductKitInventory("832WN", pickAmount * 5)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 50)) && (CheckProductKitInventory("832SLW8", pickAmount * 20)) && (CheckProductKitInventory("832-12MS", pickAmount * 12)) && (CheckProductKitInventory("832-34MS", pickAmount * 12)) && (CheckProductKitInventory("832-114MS", pickAmount)) && (CheckProductKitInventory("1032HN", pickAmount * 15)) && (CheckProductKitInventory("1032KLN", pickAmount * 10)) && (CheckProductKitInventory("1032NLN", pickAmount * 10)) && (CheckProductKitInventory("1032SFN", pickAmount * 10)) && (CheckProductKitInventory("1032CN", pickAmount * 5)) && (CheckProductKitInventory("1032WN", pickAmount * 5)) && (CheckProductKitInventory("1032SLW10", pickAmount * 20)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)) && (CheckProductKitInventory("1032114MS", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in NW-832-1032.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "NY-80":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("NLIstop-14", pickAmount * 30)) && (CheckProductKitInventory("NLIstop-516", pickAmount * 6)) && (CheckProductKitInventory("NLIstop-38", pickAmount * 20)) && (CheckProductKitInventory("NLIstop-12", pickAmount * 24)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in NY-80.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SB-316":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("102438MS", pickAmount * 20)) && (CheckProductKitInventory("102412MS", pickAmount * 20)) && (CheckProductKitInventory("102434MS", pickAmount * 15)) && (CheckProductKitInventory("10241MS", pickAmount * 15)) && (CheckProductKitInventory("1024114MS", pickAmount * 10)) && (CheckProductKitInventory("1024112MS", pickAmount * 10)) && (CheckProductKitInventory("10242MS", pickAmount * 10)) && (CheckProductKitInventory("1024MSN", pickAmount * 100)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SB-316.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SB-632":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("632-38MS", pickAmount * 25)) && (CheckProductKitInventory("632-12MS", pickAmount * 25)) && (CheckProductKitInventory("632-34MS", pickAmount * 20)) && (CheckProductKitInventory("632-1MS", pickAmount * 20)) && (CheckProductKitInventory("632-112MS", pickAmount * 20)) && (CheckProductKitInventory("632-114MS", pickAmount * 20)) && (CheckProductKitInventory("632-2MS", pickAmount * 20)) && (CheckProductKitInventory("632MSN", pickAmount * 150)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in kit.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SB-832":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("832-38MS", pickAmount * 20)) && (CheckProductKitInventory("832-12MS", pickAmount * 20)) && (CheckProductKitInventory("832-34MS", pickAmount * 20)) && (CheckProductKitInventory("832-1MS", pickAmount * 20)) && (CheckProductKitInventory("832-114MS", pickAmount * 15)) && (CheckProductKitInventory("832-112MS", pickAmount * 15)) && (CheckProductKitInventory("832-2MS", pickAmount * 15)) && (CheckProductKitInventory("832MSN", pickAmount * 125)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in kit.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SB-1032":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("103238MS", pickAmount * 20)) && (CheckProductKitInventory("103212MS", pickAmount * 20)) && (CheckProductKitInventory("103234MS", pickAmount * 15)) && (CheckProductKitInventory("10321MS", pickAmount * 15)) && (CheckProductKitInventory("1032114MS", pickAmount * 10)) && (CheckProductKitInventory("1032112MS", pickAmount * 10)) && (CheckProductKitInventory("10322MS", pickAmount * 10)) && (CheckProductKitInventory("1032SLW10", pickAmount * 100)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SB-1032.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SB-1420":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("MS14-12", pickAmount * 30)) && (CheckProductKitInventory("MS14-34", pickAmount * 16)) && (CheckProductKitInventory("MS14-1", pickAmount * 10)) && (CheckProductKitInventory("MS14-114", pickAmount * 8)) && (CheckProductKitInventory("MS14-112", pickAmount * 8)) && (CheckProductKitInventory("MS14-2", pickAmount * 6)) && (CheckProductKitInventory("HFN14", pickAmount * 75)) && (CheckProductKitInventory("SAEFW14", pickAmount * 50)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SB-1420.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SBH-1420":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("USSFW14", pickAmount * 40)) && (CheckProductKitInventory("HFN14", pickAmount * 40)) && (CheckProductKitInventory("KLN14", pickAmount * 20)) && (CheckProductKitInventory("SLW14", pickAmount * 20)) && (CheckProductKitInventory("FW14-1", pickAmount * 10)) && (CheckProductKitInventory("TB14-34", pickAmount * 20)) && (CheckProductKitInventory("TB14-1", pickAmount * 15)) && (CheckProductKitInventory("TB14-112", pickAmount * 10)) && (CheckProductKitInventory("TB14-2", pickAmount * 10)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SBH-1420.";
                                            MessageBox.Show(message);
                                        }
                                        break;

                                    case "SBH-3816":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("TB38-34", pickAmount * 12)) && (CheckProductKitInventory("TB38-1", pickAmount * 8)) && (CheckProductKitInventory("TB38-112", pickAmount * 6)) && (CheckProductKitInventory("TB38-2", pickAmount * 4)) && (CheckProductKitInventory("USSFW38", pickAmount * 20)) && (CheckProductKitInventory("HFN38", pickAmount * 20)) && (CheckProductKitInventory("KLN38", pickAmount * 8)) && (CheckProductKitInventory("SLW38", pickAmount * 10)) && (CheckProductKitInventory("FW38-112", pickAmount * 6)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SBH-3816.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SBH-5018":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("TB516-34", pickAmount * 15)) && (CheckProductKitInventory("TB516-1", pickAmount * 10)) && (CheckProductKitInventory("TB516-112", pickAmount * 8)) && (CheckProductKitInventory("TB516-2", pickAmount * 6)) && (CheckProductKitInventory("USSFW516", pickAmount * 25)) && (CheckProductKitInventory("HFN516", pickAmount * 25)) && (CheckProductKitInventory("KLN516", pickAmount * 12)) && (CheckProductKitInventory("SLW516", pickAmount * 12)) && (CheckProductKitInventory("FW516-114", pickAmount * 8)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SBH-5018.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SLW-358":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("SAEFW10", pickAmount * 50)) && (CheckProductKitInventory("SLW14", pickAmount * 40)) && (CheckProductKitInventory("SLW516", pickAmount * 40)) && (CheckProductKitInventory("SLW38", pickAmount * 25)) && (CheckProductKitInventory("SLW12", pickAmount * 15)) && (CheckProductKitInventory("SLW58", pickAmount * 10)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SLW-358.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "SS-500":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("516-18NC14", pickAmount * 6)) && (CheckProductKitInventory("516-18NC38", pickAmount * 4)) && (CheckProductKitInventory("516-18NC12", pickAmount * 4)) && (CheckProductKitInventory("516-18NC34", pickAmount * 2)) && (CheckProductKitInventory("SS5-1420-14", pickAmount * 6)) && (CheckProductKitInventory("SS5-1420-38", pickAmount * 4)) && (CheckProductKitInventory("SS5-1420-12", pickAmount * 4)) && (CheckProductKitInventory("SS5-1420-34", pickAmount * 2)) && (CheckProductKitInventory("1024NC14", pickAmount * 6)) && (CheckProductKitInventory("1024NC38", pickAmount * 4)) && (CheckProductKitInventory("1024NC12", pickAmount * 4)) && (CheckProductKitInventory("516-24NF14", pickAmount * 6)) && (CheckProductKitInventory("516-24NF38", pickAmount * 4)) && (CheckProductKitInventory("516-24NF12", pickAmount * 4)) && (CheckProductKitInventory("516-24NF34", pickAmount * 2)) && (CheckProductKitInventory("SS5-1428-14", pickAmount * 6)) && (CheckProductKitInventory("SS5-1428-38", pickAmount * 4)) && (CheckProductKitInventory("SS5-1428-12", pickAmount * 4)) && (CheckProductKitInventory("SS5-1428-34", pickAmount * 2)) && (CheckProductKitInventory("1032NF14", pickAmount * 6)) && (CheckProductKitInventory("1032NF38", pickAmount * 4)) && (CheckProductKitInventory("1032NF12", pickAmount * 4)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in SS-500.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-10":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek1012", pickAmount * 25)) && (CheckProductKitInventory("TEK1034", pickAmount * 25)) && (CheckProductKitInventory("Tek10-1", pickAmount * 20)) && (CheckProductKitInventory("Tek10-114", pickAmount * 15)) && (CheckProductKitInventory("Tek10-112", pickAmount * 15)) && (CheckProductKitInventory("jc-15", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-10.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-8":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("TEK8-12", pickAmount * 40)) && (CheckProductKitInventory("TEK8-34", pickAmount * 30)) && (CheckProductKitInventory("TEK8-1", pickAmount * 30)) && (CheckProductKitInventory("TEK8-114", pickAmount * 30)) && (CheckProductKitInventory("TEK8-112", pickAmount * 15)) && (CheckProductKitInventory("JC-2", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-8.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-10-5834":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("jc-15", pickAmount)) && (CheckProductKitInventory("TEK1058", pickAmount * 100)) && (CheckProductKitInventory("TEK1034", pickAmount * 100)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-10-5834.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-12":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek12-34", pickAmount * 12)) && (CheckProductKitInventory("Tek12-1", pickAmount * 8)) && (CheckProductKitInventory("Tek12-114", pickAmount * 7)) && (CheckProductKitInventory("Tek12-112", pickAmount * 6)) && (CheckProductKitInventory("Tek12-2", pickAmount * 5)) && (CheckProductKitInventory("jc-15", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-12.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-14":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("Tek14-34", pickAmount * 10)) && (CheckProductKitInventory("Tek14-1", pickAmount * 7)) && (CheckProductKitInventory("Tek14-114", pickAmount * 4)) && (CheckProductKitInventory("Tek14-112", pickAmount * 4)) && (CheckProductKitInventory("Tek14-2", pickAmount * 4)) && (CheckProductKitInventory("JC-30", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-14.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TK-141":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("Tek14-1", pickAmount * 75)) && (CheckProductKitInventory("JC-30", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TK-141.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "TSHZ-1010":
                                        if ((CheckProductKitInventory("6Box", pickAmount)) && (CheckProductKitInventory("ZIP10-12", pickAmount * 70)) && (CheckProductKitInventory("ZIP1034", pickAmount * 50)) && (CheckProductKitInventory("Zip10-1", pickAmount * 35)) && (CheckProductKitInventory("ZIP10-114", pickAmount * 15)) && (CheckProductKitInventory("ZIP10-112", pickAmount * 15)) && (CheckProductKitInventory("ZIP102", pickAmount * 15)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in TSHZ-1010.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "W-100 Plated washers":
                                        if ((CheckProductKitInventory("1Box", pickAmount)) && (CheckProductKitInventory("SAEF632-6", pickAmount * 12)) && (CheckProductKitInventory("SAEF832-8", pickAmount * 10)) && (CheckProductKitInventory("SAEFW10", pickAmount * 10)) && (CheckProductKitInventory("SAEFW14", pickAmount * 10)) && (CheckProductKitInventory("SAEFW516", pickAmount * 8)) && (CheckProductKitInventory("SAEFW38", pickAmount * 8)) && (CheckProductKitInventory("USSFW14", pickAmount * 10)) && (CheckProductKitInventory("USSFW516", pickAmount * 10)) && (CheckProductKitInventory("USSFW12", pickAmount * 6)) && (CheckProductKitInventory("USSFW38", pickAmount * 8)) && (CheckProductKitInventory("FW14-1", pickAmount * 10)) && (CheckProductKitInventory("FW316-1", pickAmount * 10)) && (CheckProductKitInventory("FW38-112", pickAmount * 6)) && (CheckProductKitInventory("FW12-112", pickAmount * 3)) && (CheckProductKitInventory("FW516-114", pickAmount * 5)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in W-100 Plated washers.";
                                            MessageBox.Show(message);
                                        }
                                        break;
                                    case "WE-383":
                                        if ((CheckProductKitInventory("2Box", pickAmount)) && (CheckProductKitInventory("HFN38", pickAmount * 13)) && (CheckProductKitInventory("SAEFW38", pickAmount * 13)) && (CheckProductKitInventory("WedgeAnc-38-3", pickAmount * 12)) && (CheckProductKitInventory("Mdrill38", pickAmount)))
                                        {
                                            removePickRow(placeholder.PickID);
                                            updatePickDB(placeholder);
                                            UpdateKitItem(placeholder);
                                        }

                                        else
                                        {
                                            string message = "Please check quantity of items in WE-383.";
                                            MessageBox.Show(message);
                                        }
                                        break;  */
                                }
                            }

                            else
                            {
                                resultInventory.ProductQuantity = resultInventory.ProductQuantity + resultShip[i].QuantityPicked;
                                DB.SaveChanges();
                            }
                        }
                    }

                }
            }
        }

        public string getPO()
        {
            return textPONumber.Text;
        }

        public void setPO(string placeholder)
        {
            textPONumber.Text = placeholder;
        }

        public string getSO()
        {
            return textSONumber.Text;
        }

        public void setSO(string placeholder)
        {
            textSONumber.Text = placeholder;
        }

        public class SalesItem
        {
            public int quantity;
            public string DisplayName;

            public SalesItem(int quant, string sDisplayName)
            {
                quantity = quant;
                DisplayName = sDisplayName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        public SalesItem createSalesItem(int quant, string name)
        {
            SalesItem addedItem = new SalesItem(quant, name);
            return addedItem;
        }

        public void AddRow(SalesItem salesRow)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == salesRow.DisplayName);

                if (result != null)
                {
                    dataGridView1.Rows.Add(textSONumber.Text, textPONumber.Text, salesRow.quantity, salesRow.DisplayName);
                }
            }
        }

        public bool invalidQuantity(int i)
        {
            bool invalidQuantity = true;
            if (dataGridView1.Rows[i].Cells[4].Value.ToString() != null)
            {
                if (convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString()) > convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    string error = "Error: Quantity picked exceeds remaining amount in order.";
                    MessageBox.Show(error);
                    return invalidQuantity;
                }

                else
                {
                    invalidQuantity = false;
                }
            }
            return invalidQuantity;
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

        public bool checkCommit(int i)
        {
            bool isChecked = false;

            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true)
            {
                isChecked = true;
            }

            else
            {
                isChecked = false;
            }

            return isChecked;

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Today.ToString("MM/dd/yyyy");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int pickID = convertToInt(dataGridView1.Rows[i].Cells[8].Value.ToString());

                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "KIT")
                {
                    if (dataGridView1.Rows[i].Cells[4].Value == null)
                    {
                        var placeholder = convertNullPickToDB(i);
                        removePickRow(pickID);
                        updatePickDB(placeholder);
                    }

                    else
                    {
                        if (convertToInt(dataGridView1.Rows[i].Cells[4].Value.ToString()) > convertToInt(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                        {
                            string error = "Error: quantity picked exceeds invoice quantity.";
                            MessageBox.Show(error);
                        }

                        else
                        {
                            var placeholder = convertPickToDB(i);

                            if (placeholder.Commit == true)
                            {
                                removePickRow(pickID);
                                updatePickDB(placeholder);
                                UpdateKitInventory(placeholder, i);
                                var convertedShip = convertPickToShipping(placeholder);
                                updateShipDB(convertedShip);
                            }

                            else
                            {
                               /* placeholder.QuantityPicked = 0;
                                removePickDB();
                                updatePickDB(placeholder); */
                            }
                        }
                    }
                }

                else
                {
                    if (dataGridView1.Rows[i].Cells[4].Value != null)
                    {
                        if (invalidQuantity(i) == false)
                        {
                            var placeholder = convertPickToDB(i);

                            if (placeholder.Commit == true)
                            {
                                removePickRow(pickID);
                                updatePickDB(placeholder);
                                updateInventory(placeholder);
                                var convertedShip = convertPickToShipping(placeholder);
                                updateShipDB(convertedShip);
                            }

                            else
                            {
                                /*placeholder.QuantityPicked = 0;
                                removePickDB();
                                updatePickDB(placeholder); */
                            }
                        }

                        else
                        {
                            string msg = "Invalid quantity entered.";
                            MessageBox.Show(msg);
                        }
                    }
                }       
            }
        }
    
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var result = ValidateCell(e);
            var eValue = e.FormattedValue.ToString();
            

            if (true)
            {
                if (String.IsNullOrEmpty(eValue))
                {
                    string errorMes = "No value entered";
                    MessageBox.Show(errorMes);
                }

                else
                {
                  
                }
            }

            else
            {
                string message = "Validation failed.";
                MessageBox.Show(message);
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
                //DO SOMETHING //
            }

        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (textSONumber.Text != null)
            {
                int integerSO = convertToInt(textSONumber.Text);
                voidPick(integerSO);
                resetPickAndShip(integerSO);
            }
        }
    }
}
