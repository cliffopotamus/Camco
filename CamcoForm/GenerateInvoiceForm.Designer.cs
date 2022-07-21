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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoiceForm));
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
            this.ShipLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoicePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generatedInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generatedInvoiceDataset = new CamcoForm.GeneratedInvoiceDataset();
            this.generatedInvoiceTableAdapter = new CamcoForm.GeneratedInvoiceDatasetTableAdapters.GeneratedInvoiceTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Location = new System.Drawing.Point(652, 261);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(69, 13);
            this.labelInvoiceTotal.TabIndex = 22;
            this.labelInvoiceTotal.Text = "Invoice Total";
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(652, 277);
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(104, 20);
            this.textInvoiceTotal.TabIndex = 21;
            // 
            // labelInvoiceSO
            // 
            this.labelInvoiceSO.AutoSize = true;
            this.labelInvoiceSO.Location = new System.Drawing.Point(66, 193);
            this.labelInvoiceSO.Name = "labelInvoiceSO";
            this.labelInvoiceSO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoiceSO.TabIndex = 20;
            this.labelInvoiceSO.Text = "Invoice SO";
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(430, 213);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillingAddress.TabIndex = 19;
            this.labelBillingAddress.Text = "Billing Address";
            // 
            // labelShippingAddress
            // 
            this.labelShippingAddress.AutoSize = true;
            this.labelShippingAddress.Location = new System.Drawing.Point(236, 213);
            this.labelShippingAddress.Name = "labelShippingAddress";
            this.labelShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.labelShippingAddress.TabIndex = 18;
            this.labelShippingAddress.Text = "Shipping Address";
            // 
            // richTextBill
            // 
            this.richTextBill.Location = new System.Drawing.Point(433, 229);
            this.richTextBill.Name = "richTextBill";
            this.richTextBill.Size = new System.Drawing.Size(179, 68);
            this.richTextBill.TabIndex = 17;
            this.richTextBill.Text = "";
            // 
            // richTextShip
            // 
            this.richTextShip.Location = new System.Drawing.Point(239, 229);
            this.richTextShip.Name = "richTextShip";
            this.richTextShip.Size = new System.Drawing.Size(184, 68);
            this.richTextShip.TabIndex = 16;
            this.richTextShip.Text = "";
            // 
            // textInvoicePO
            // 
            this.textInvoicePO.Location = new System.Drawing.Point(69, 268);
            this.textInvoicePO.Name = "textInvoicePO";
            this.textInvoicePO.Size = new System.Drawing.Size(100, 20);
            this.textInvoicePO.TabIndex = 15;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(602, 162);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(119, 20);
            this.textCustomerID.TabIndex = 14;
            this.textCustomerID.Visible = false;
            // 
            // textInvoiceSO
            // 
            this.textInvoiceSO.Location = new System.Drawing.Point(69, 209);
            this.textInvoiceSO.Name = "textInvoiceSO";
            this.textInvoiceSO.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceSO.TabIndex = 13;
            // 
            // labelInvoicePO
            // 
            this.labelInvoicePO.AutoSize = true;
            this.labelInvoicePO.Location = new System.Drawing.Point(66, 252);
            this.labelInvoicePO.Name = "labelInvoicePO";
            this.labelInvoicePO.Size = new System.Drawing.Size(60, 13);
            this.labelInvoicePO.TabIndex = 23;
            this.labelInvoicePO.Text = "Invoice PO";
            // 
            // textInvoiceNumber
            // 
            this.textInvoiceNumber.Location = new System.Drawing.Point(368, 109);
            this.textInvoiceNumber.Name = "textInvoiceNumber";
            this.textInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceNumber.TabIndex = 24;
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(365, 93);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(82, 13);
            this.labelInvoiceNumber.TabIndex = 25;
            this.labelInvoiceNumber.Text = "Invoice Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipLineID,
            this.InvoiceNumber,
            this.InvoiceSO,
            this.InvoicePO,
            this.Quantity,
            this.ProductName,
            this.ProductDescription,
            this.QuantityPicked,
            this.QuantityRemaining,
            this.SalesPrice,
            this.ProductExtension,
            this.DateScheduled,
            this.Invoice});
            this.dataGridView1.Location = new System.Drawing.Point(50, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(706, 350);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShipLineID
            // 
            this.ShipLineID.HeaderText = "ShipLineID";
            this.ShipLineID.Name = "ShipLineID";
            this.ShipLineID.ReadOnly = true;
            this.ShipLineID.Visible = false;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.HeaderText = "InvoiceNumber";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            this.InvoiceNumber.Visible = false;
            // 
            // InvoiceSO
            // 
            this.InvoiceSO.HeaderText = "InvoiceSO";
            this.InvoiceSO.Name = "InvoiceSO";
            this.InvoiceSO.ReadOnly = true;
            this.InvoiceSO.Visible = false;
            // 
            // InvoicePO
            // 
            this.InvoicePO.HeaderText = "InvoicePO";
            this.InvoicePO.Name = "InvoicePO";
            this.InvoicePO.ReadOnly = true;
            this.InvoicePO.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // QuantityPicked
            // 
            this.QuantityPicked.HeaderText = "Picked";
            this.QuantityPicked.Name = "QuantityPicked";
            this.QuantityPicked.ReadOnly = true;
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.HeaderText = "Remaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // SalesPrice
            // 
            this.SalesPrice.HeaderText = "Price";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // ProductExtension
            // 
            this.ProductExtension.HeaderText = "Extension";
            this.ProductExtension.Name = "ProductExtension";
            this.ProductExtension.ReadOnly = true;
            // 
            // DateScheduled
            // 
            this.DateScheduled.HeaderText = "Date";
            this.DateScheduled.Name = "DateScheduled";
            this.DateScheduled.ReadOnly = true;
            this.DateScheduled.Visible = false;
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Visible = false;
            // 
            // generatedInvoiceBindingSource
            // 
            this.generatedInvoiceBindingSource.DataMember = "GeneratedInvoice";
            this.generatedInvoiceBindingSource.DataSource = this.generatedInvoiceDataset;
            // 
            // generatedInvoiceDataset
            // 
            this.generatedInvoiceDataset.DataSetName = "GeneratedInvoiceDataset";
            this.generatedInvoiceDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generatedInvoiceTableAdapter
            // 
            this.generatedInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(677, 702);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(111, 38);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(69, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 62);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(69, 153);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(119, 20);
            this.textCustomerName.TabIndex = 29;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(66, 132);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(51, 13);
            this.labelCustomer.TabIndex = 30;
            this.labelCustomer.Text = "Customer";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(368, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(185, 62);
            this.richTextBox2.TabIndex = 31;
            this.richTextBox2.Text = "INVOICE";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(512, 109);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(100, 20);
            this.textDate.TabIndex = 32;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(508, 93);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 33;
            this.labelDate.Text = "Date";
            // 
            // GenerateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPrint);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateInvoiceForm";
            this.Text = "GenerateInvoiceForm";
            this.Load += new System.EventHandler(this.GenerateInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedInvoiceDataset)).EndInit();
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
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoicePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateScheduled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label labelDate;
    }
}