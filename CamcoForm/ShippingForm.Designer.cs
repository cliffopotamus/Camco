﻿namespace CamcoForm
{
    partial class ShippingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoicePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textInvoiceSO = new System.Windows.Forms.TextBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textInvoicePO = new System.Windows.Forms.TextBox();
            this.btnPackingList = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.richTextShip = new System.Windows.Forms.RichTextBox();
            this.richTextBill = new System.Windows.Forms.RichTextBox();
            this.labelShippingAddress = new System.Windows.Forms.Label();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelInvoicePO = new System.Windows.Forms.Label();
            this.labelInvoiceSO = new System.Windows.Forms.Label();
            this.textInvoiceTotal = new System.Windows.Forms.TextBox();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipID,
            this.InvoiceSO,
            this.InvoicePO,
            this.Quantity,
            this.ProductName,
            this.QuantityPicked,
            this.QuantityRemaining,
            this.DateScheduled,
            this.Finished});
            this.dataGridView1.Location = new System.Drawing.Point(0, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShipID
            // 
            this.ShipID.HeaderText = "ShipID";
            this.ShipID.Name = "ShipID";
            this.ShipID.ReadOnly = true;
            // 
            // InvoiceSO
            // 
            this.InvoiceSO.HeaderText = "InvoiceSO";
            this.InvoiceSO.Name = "InvoiceSO";
            this.InvoiceSO.ReadOnly = true;
            // 
            // InvoicePO
            // 
            this.InvoicePO.HeaderText = "InvoicePO";
            this.InvoicePO.Name = "InvoicePO";
            this.InvoicePO.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // QuantityPicked
            // 
            this.QuantityPicked.HeaderText = "QuantityPicked";
            this.QuantityPicked.Name = "QuantityPicked";
            this.QuantityPicked.ReadOnly = true;
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.HeaderText = "QuantityRemaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // DateScheduled
            // 
            this.DateScheduled.HeaderText = "DateScheduled";
            this.DateScheduled.Name = "DateScheduled";
            // 
            // Finished
            // 
            this.Finished.HeaderText = "Finished";
            this.Finished.Name = "Finished";
            // 
            // textInvoiceSO
            // 
            this.textInvoiceSO.Location = new System.Drawing.Point(221, 47);
            this.textInvoiceSO.Name = "textInvoiceSO";
            this.textInvoiceSO.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceSO.TabIndex = 1;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(456, 71);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(119, 20);
            this.textCustomerID.TabIndex = 2;
            // 
            // textInvoicePO
            // 
            this.textInvoicePO.Location = new System.Drawing.Point(45, 47);
            this.textInvoicePO.Name = "textInvoicePO";
            this.textInvoicePO.Size = new System.Drawing.Size(100, 20);
            this.textInvoicePO.TabIndex = 3;
            this.textInvoicePO.TextChanged += new System.EventHandler(this.textInvoicePO_TextChanged);
            // 
            // btnPackingList
            // 
            this.btnPackingList.Location = new System.Drawing.Point(743, 186);
            this.btnPackingList.Name = "btnPackingList";
            this.btnPackingList.Size = new System.Drawing.Size(111, 45);
            this.btnPackingList.TabIndex = 4;
            this.btnPackingList.Text = "Print Packing List";
            this.btnPackingList.UseVisualStyleBackColor = true;
            this.btnPackingList.Click += new System.EventHandler(this.btnPackingList_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // richTextShip
            // 
            this.richTextShip.Location = new System.Drawing.Point(27, 141);
            this.richTextShip.Name = "richTextShip";
            this.richTextShip.Size = new System.Drawing.Size(184, 68);
            this.richTextShip.TabIndex = 5;
            this.richTextShip.Text = "";
            // 
            // richTextBill
            // 
            this.richTextBill.Location = new System.Drawing.Point(249, 141);
            this.richTextBill.Name = "richTextBill";
            this.richTextBill.Size = new System.Drawing.Size(179, 68);
            this.richTextBill.TabIndex = 6;
            this.richTextBill.Text = "";
            // 
            // labelShippingAddress
            // 
            this.labelShippingAddress.AutoSize = true;
            this.labelShippingAddress.Location = new System.Drawing.Point(42, 112);
            this.labelShippingAddress.Name = "labelShippingAddress";
            this.labelShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.labelShippingAddress.TabIndex = 7;
            this.labelShippingAddress.Text = "Shipping Address";
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(246, 112);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillingAddress.TabIndex = 8;
            this.labelBillingAddress.Text = "Billing Address";
            // 
            // labelInvoicePO
            // 
            this.labelInvoicePO.AutoSize = true;
            this.labelInvoicePO.Location = new System.Drawing.Point(42, 31);
            this.labelInvoicePO.Name = "labelInvoicePO";
            this.labelInvoicePO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoicePO.TabIndex = 9;
            this.labelInvoicePO.Text = "Invoice PO";
            // 
            // labelInvoiceSO
            // 
            this.labelInvoiceSO.AutoSize = true;
            this.labelInvoiceSO.Location = new System.Drawing.Point(218, 31);
            this.labelInvoiceSO.Name = "labelInvoiceSO";
            this.labelInvoiceSO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoiceSO.TabIndex = 10;
            this.labelInvoiceSO.Text = "Invoice SO";
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(494, 157);
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(104, 20);
            this.textInvoiceTotal.TabIndex = 11;
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Location = new System.Drawing.Point(491, 141);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(69, 13);
            this.labelInvoiceTotal.TabIndex = 12;
            this.labelInvoiceTotal.Text = "Invoice Total";
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 600);
            this.Controls.Add(this.labelInvoiceTotal);
            this.Controls.Add(this.textInvoiceTotal);
            this.Controls.Add(this.labelInvoiceSO);
            this.Controls.Add(this.labelInvoicePO);
            this.Controls.Add(this.labelBillingAddress);
            this.Controls.Add(this.labelShippingAddress);
            this.Controls.Add(this.richTextBill);
            this.Controls.Add(this.richTextShip);
            this.Controls.Add(this.btnPackingList);
            this.Controls.Add(this.textInvoicePO);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.textInvoiceSO);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "ShippingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShippingForm";
            this.Load += new System.EventHandler(this.ShippingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textInvoiceSO;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textInvoicePO;
        private System.Windows.Forms.Button btnPackingList;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox richTextShip;
        private System.Windows.Forms.RichTextBox richTextBill;
        private System.Windows.Forms.Label labelShippingAddress;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.Label labelInvoicePO;
        private System.Windows.Forms.Label labelInvoiceSO;
        private System.Windows.Forms.TextBox textInvoiceTotal;
        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoicePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateScheduled;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished;
    }
}