namespace CamcoForm
{
    partial class GenerateInvoiceForm
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
            this.components = new System.ComponentModel.Container();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            this.textInvoiceTotal = new System.Windows.Forms.TextBox();
            this.labelInvoiceSO = new System.Windows.Forms.Label();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelShippingAddress = new System.Windows.Forms.Label();
            this.richTextBill = new System.Windows.Forms.RichTextBox();
            this.richTextShip = new System.Windows.Forms.RichTextBox();
            this.textInvoicePO = new System.Windows.Forms.TextBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textInvoiceSO = new System.Windows.Forms.TextBox();
            this.labelInvoicePO = new System.Windows.Forms.Label();
            this.textInvoiceNumber = new System.Windows.Forms.TextBox();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generatedInvoiceDataset = new CamcoForm.GeneratedInvoiceDataset();
            this.generatedInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generatedInvoiceTableAdapter = new CamcoForm.GeneratedInvoiceDatasetTableAdapters.GeneratedInvoiceTableAdapter();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPickedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateScheduledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Location = new System.Drawing.Point(413, 43);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(69, 13);
            this.labelInvoiceTotal.TabIndex = 22;
            this.labelInvoiceTotal.Text = "Invoice Total";
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(416, 64);
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(104, 20);
            this.textInvoiceTotal.TabIndex = 21;
            // 
            // labelInvoiceSO
            // 
            this.labelInvoiceSO.AutoSize = true;
            this.labelInvoiceSO.Location = new System.Drawing.Point(288, 43);
            this.labelInvoiceSO.Name = "labelInvoiceSO";
            this.labelInvoiceSO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoiceSO.TabIndex = 20;
            this.labelInvoiceSO.Text = "Invoice SO";
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(509, 102);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillingAddress.TabIndex = 19;
            this.labelBillingAddress.Text = "Billing Address";
            // 
            // labelShippingAddress
            // 
            this.labelShippingAddress.AutoSize = true;
            this.labelShippingAddress.Location = new System.Drawing.Point(38, 102);
            this.labelShippingAddress.Name = "labelShippingAddress";
            this.labelShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.labelShippingAddress.TabIndex = 18;
            this.labelShippingAddress.Text = "Shipping Address";
            // 
            // richTextBill
            // 
            this.richTextBill.Location = new System.Drawing.Point(512, 118);
            this.richTextBill.Name = "richTextBill";
            this.richTextBill.Size = new System.Drawing.Size(179, 68);
            this.richTextBill.TabIndex = 17;
            this.richTextBill.Text = "";
            // 
            // richTextShip
            // 
            this.richTextShip.Location = new System.Drawing.Point(41, 118);
            this.richTextShip.Name = "richTextShip";
            this.richTextShip.Size = new System.Drawing.Size(184, 68);
            this.richTextShip.TabIndex = 16;
            this.richTextShip.Text = "";
            // 
            // textInvoicePO
            // 
            this.textInvoicePO.Location = new System.Drawing.Point(168, 64);
            this.textInvoicePO.Name = "textInvoicePO";
            this.textInvoicePO.Size = new System.Drawing.Size(100, 20);
            this.textInvoicePO.TabIndex = 15;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(548, 64);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(119, 20);
            this.textCustomerID.TabIndex = 14;
            this.textCustomerID.Visible = false;
            // 
            // textInvoiceSO
            // 
            this.textInvoiceSO.Location = new System.Drawing.Point(291, 64);
            this.textInvoiceSO.Name = "textInvoiceSO";
            this.textInvoiceSO.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceSO.TabIndex = 13;
            // 
            // labelInvoicePO
            // 
            this.labelInvoicePO.AutoSize = true;
            this.labelInvoicePO.Location = new System.Drawing.Point(165, 43);
            this.labelInvoicePO.Name = "labelInvoicePO";
            this.labelInvoicePO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoicePO.TabIndex = 23;
            this.labelInvoicePO.Text = "Invoice PO";
            // 
            // textInvoiceNumber
            // 
            this.textInvoiceNumber.Location = new System.Drawing.Point(48, 64);
            this.textInvoiceNumber.Name = "textInvoiceNumber";
            this.textInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceNumber.TabIndex = 24;
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(45, 43);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(82, 13);
            this.labelInvoiceNumber.TabIndex = 25;
            this.labelInvoiceNumber.Text = "Invoice Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.invoiceSODataGridViewTextBoxColumn,
            this.invoicePODataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.quantityPickedDataGridViewTextBoxColumn,
            this.quantityRemainingDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn,
            this.dateScheduledDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generatedInvoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(702, 350);
            this.dataGridView1.TabIndex = 26;
            // 
            // generatedInvoiceDataset
            // 
            this.generatedInvoiceDataset.DataSetName = "GeneratedInvoiceDataset";
            this.generatedInvoiceDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generatedInvoiceBindingSource
            // 
            this.generatedInvoiceBindingSource.DataMember = "GeneratedInvoice";
            this.generatedInvoiceBindingSource.DataSource = this.generatedInvoiceDataset;
            // 
            // generatedInvoiceTableAdapter
            // 
            this.generatedInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceSODataGridViewTextBoxColumn
            // 
            this.invoiceSODataGridViewTextBoxColumn.DataPropertyName = "InvoiceSO";
            this.invoiceSODataGridViewTextBoxColumn.HeaderText = "InvoiceSO";
            this.invoiceSODataGridViewTextBoxColumn.Name = "invoiceSODataGridViewTextBoxColumn";
            this.invoiceSODataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceSODataGridViewTextBoxColumn.Visible = false;
            // 
            // invoicePODataGridViewTextBoxColumn
            // 
            this.invoicePODataGridViewTextBoxColumn.DataPropertyName = "InvoicePO";
            this.invoicePODataGridViewTextBoxColumn.HeaderText = "InvoicePO";
            this.invoicePODataGridViewTextBoxColumn.Name = "invoicePODataGridViewTextBoxColumn";
            this.invoicePODataGridViewTextBoxColumn.ReadOnly = true;
            this.invoicePODataGridViewTextBoxColumn.Visible = false;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityPickedDataGridViewTextBoxColumn
            // 
            this.quantityPickedDataGridViewTextBoxColumn.DataPropertyName = "QuantityPicked";
            this.quantityPickedDataGridViewTextBoxColumn.HeaderText = "QuantityPicked";
            this.quantityPickedDataGridViewTextBoxColumn.Name = "quantityPickedDataGridViewTextBoxColumn";
            this.quantityPickedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityRemainingDataGridViewTextBoxColumn
            // 
            this.quantityRemainingDataGridViewTextBoxColumn.DataPropertyName = "QuantityRemaining";
            this.quantityRemainingDataGridViewTextBoxColumn.HeaderText = "QuantityRemaining";
            this.quantityRemainingDataGridViewTextBoxColumn.Name = "quantityRemainingDataGridViewTextBoxColumn";
            this.quantityRemainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateScheduledDataGridViewTextBoxColumn
            // 
            this.dateScheduledDataGridViewTextBoxColumn.DataPropertyName = "DateScheduled";
            this.dateScheduledDataGridViewTextBoxColumn.HeaderText = "DateScheduled";
            this.dateScheduledDataGridViewTextBoxColumn.Name = "dateScheduledDataGridViewTextBoxColumn";
            this.dateScheduledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GenerateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInvoiceNumber);
            this.Controls.Add(this.textInvoiceNumber);
            this.Controls.Add(this.labelInvoicePO);
            this.Controls.Add(this.labelInvoiceTotal);
            this.Controls.Add(this.textInvoiceTotal);
            this.Controls.Add(this.labelInvoiceSO);
            this.Controls.Add(this.labelBillingAddress);
            this.Controls.Add(this.labelShippingAddress);
            this.Controls.Add(this.richTextBill);
            this.Controls.Add(this.richTextShip);
            this.Controls.Add(this.textInvoicePO);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.textInvoiceSO);
            this.Name = "GenerateInvoiceForm";
            this.Text = "GenerateInvoiceForm";
            this.Load += new System.EventHandler(this.GenerateInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.TextBox textInvoiceTotal;
        private System.Windows.Forms.Label labelInvoiceSO;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.Label labelShippingAddress;
        private System.Windows.Forms.RichTextBox richTextBill;
        private System.Windows.Forms.RichTextBox richTextShip;
        private System.Windows.Forms.TextBox textInvoicePO;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textInvoiceSO;
        private System.Windows.Forms.Label labelInvoicePO;
        private System.Windows.Forms.TextBox textInvoiceNumber;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GeneratedInvoiceDataset generatedInvoiceDataset;
        private System.Windows.Forms.BindingSource generatedInvoiceBindingSource;
        private GeneratedInvoiceDatasetTableAdapters.GeneratedInvoiceTableAdapter generatedInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPickedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityRemainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateScheduledDataGridViewTextBoxColumn;
    }
}