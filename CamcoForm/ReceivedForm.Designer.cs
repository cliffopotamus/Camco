namespace CamcoForm
{
    partial class ReceivedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivedForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReceivedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPurchaseSO = new System.Windows.Forms.TextBox();
            this.textPurchasePO = new System.Windows.Forms.TextBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.labelPurchaseSO = new System.Windows.Forms.Label();
            this.labelPurchasePO = new System.Windows.Forms.Label();
            this.labelPurchaseTotal = new System.Windows.Forms.Label();
            this.textPurchaseTotal = new System.Windows.Forms.TextBox();
            this.btnPackingList = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textVendorName = new System.Windows.Forms.TextBox();
            this.labelVendorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceivedID,
            this.PurchaseSO,
            this.PurchasePO,
            this.Quantity,
            this.ProductName,
            this.ProductDescription,
            this.QuantityReceived,
            this.QuantityRemaining,
            this.DateScheduled});
            this.dataGridView1.Location = new System.Drawing.Point(41, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(807, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReceivedID
            // 
            this.ReceivedID.HeaderText = "ReceivedID";
            this.ReceivedID.Name = "ReceivedID";
            this.ReceivedID.ReadOnly = true;
            this.ReceivedID.Visible = false;
            // 
            // PurchaseSO
            // 
            this.PurchaseSO.HeaderText = "PurchaseSO";
            this.PurchaseSO.Name = "PurchaseSO";
            this.PurchaseSO.ReadOnly = true;
            // 
            // PurchasePO
            // 
            this.PurchasePO.HeaderText = "PurchasePO";
            this.PurchasePO.Name = "PurchasePO";
            this.PurchasePO.ReadOnly = true;
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
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "ProductDescription";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.HeaderText = "QuantityReceived";
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
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
            this.DateScheduled.ReadOnly = true;
            // 
            // textPurchaseSO
            // 
            this.textPurchaseSO.Location = new System.Drawing.Point(216, 43);
            this.textPurchaseSO.Name = "textPurchaseSO";
            this.textPurchaseSO.Size = new System.Drawing.Size(100, 20);
            this.textPurchaseSO.TabIndex = 1;
            // 
            // textPurchasePO
            // 
            this.textPurchasePO.Location = new System.Drawing.Point(357, 43);
            this.textPurchasePO.Name = "textPurchasePO";
            this.textPurchasePO.Size = new System.Drawing.Size(100, 20);
            this.textPurchasePO.TabIndex = 2;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(739, 522);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 3;
            this.textCustomerID.Visible = false;
            // 
            // labelPurchaseSO
            // 
            this.labelPurchaseSO.AutoSize = true;
            this.labelPurchaseSO.Location = new System.Drawing.Point(213, 27);
            this.labelPurchaseSO.Name = "labelPurchaseSO";
            this.labelPurchaseSO.Size = new System.Drawing.Size(67, 13);
            this.labelPurchaseSO.TabIndex = 4;
            this.labelPurchaseSO.Text = "PurchaseSO";
            // 
            // labelPurchasePO
            // 
            this.labelPurchasePO.AutoSize = true;
            this.labelPurchasePO.Location = new System.Drawing.Point(354, 27);
            this.labelPurchasePO.Name = "labelPurchasePO";
            this.labelPurchasePO.Size = new System.Drawing.Size(67, 13);
            this.labelPurchasePO.TabIndex = 5;
            this.labelPurchasePO.Text = "PurchasePO";
            // 
            // labelPurchaseTotal
            // 
            this.labelPurchaseTotal.AutoSize = true;
            this.labelPurchaseTotal.Location = new System.Drawing.Point(495, 27);
            this.labelPurchaseTotal.Name = "labelPurchaseTotal";
            this.labelPurchaseTotal.Size = new System.Drawing.Size(79, 13);
            this.labelPurchaseTotal.TabIndex = 6;
            this.labelPurchaseTotal.Text = "Purchase Total";
            // 
            // textPurchaseTotal
            // 
            this.textPurchaseTotal.Location = new System.Drawing.Point(498, 43);
            this.textPurchaseTotal.Name = "textPurchaseTotal";
            this.textPurchaseTotal.Size = new System.Drawing.Size(100, 20);
            this.textPurchaseTotal.TabIndex = 7;
            // 
            // btnPackingList
            // 
            this.btnPackingList.Location = new System.Drawing.Point(845, 499);
            this.btnPackingList.Name = "btnPackingList";
            this.btnPackingList.Size = new System.Drawing.Size(104, 43);
            this.btnPackingList.TabIndex = 8;
            this.btnPackingList.Text = "Print Packing List";
            this.btnPackingList.UseVisualStyleBackColor = true;
            this.btnPackingList.Click += new System.EventHandler(this.btnPackingList_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // 
            // textVendorName
            // 
            this.textVendorName.Location = new System.Drawing.Point(66, 43);
            this.textVendorName.Name = "textVendorName";
            this.textVendorName.Size = new System.Drawing.Size(100, 20);
            this.textVendorName.TabIndex = 9;
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(63, 27);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(72, 13);
            this.labelVendorName.TabIndex = 10;
            this.labelVendorName.Text = "Vendor Name";
            // 
            // ReceivedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 554);
            this.Controls.Add(this.labelVendorName);
            this.Controls.Add(this.textVendorName);
            this.Controls.Add(this.btnPackingList);
            this.Controls.Add(this.textPurchaseTotal);
            this.Controls.Add(this.labelPurchaseTotal);
            this.Controls.Add(this.labelPurchasePO);
            this.Controls.Add(this.labelPurchaseSO);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.textPurchasePO);
            this.Controls.Add(this.textPurchaseSO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReceivedForm";
            this.Text = "ReceivedForm";
            this.Load += new System.EventHandler(this.ReceivedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPurchaseSO;
        private System.Windows.Forms.TextBox textPurchasePO;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label labelPurchaseSO;
        private System.Windows.Forms.Label labelPurchasePO;
        private System.Windows.Forms.Label labelPurchaseTotal;
        private System.Windows.Forms.TextBox textPurchaseTotal;
        private System.Windows.Forms.Button btnPackingList;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textVendorName;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateScheduled;
    }
}