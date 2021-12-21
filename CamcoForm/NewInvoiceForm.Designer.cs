namespace CamcoForm
{
    partial class NewInvoiceForm
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
            this.comboCustomerName = new System.Windows.Forms.ComboBox();
            this.customerNameList = new CamcoForm.CustomerNameList();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CamcoForm.CustomerNameListTableAdapters.CustomersTableAdapter();
            this.labelComboCustomer = new System.Windows.Forms.Label();
            this.textSONumber = new System.Windows.Forms.TextBox();
            this.labelSONumber = new System.Windows.Forms.Label();
            this.textPONumber = new System.Windows.Forms.TextBox();
            this.labelPONumber = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBillTo = new System.Windows.Forms.TextBox();
            this.labelBillTo = new System.Windows.Forms.Label();
            this.textShipTo = new System.Windows.Forms.TextBox();
            this.labelShippingAddress = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.comboBoxItems = new CamcoForm.ComboBoxItems();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new CamcoForm.ComboBoxItemsTableAdapters.InventoryTableAdapter();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.labelInvoiceItem = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.labelLineItem = new System.Windows.Forms.Label();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            this.textInvoiceTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.DataSource = this.customersBindingSource;
            this.comboCustomerName.DisplayMember = "CustomerName";
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(67, 53);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(121, 21);
            this.comboCustomerName.TabIndex = 0;
            // 
            // customerNameList
            // 
            this.customerNameList.DataSetName = "CustomerNameList";
            this.customerNameList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customerNameList;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // labelComboCustomer
            // 
            this.labelComboCustomer.AutoSize = true;
            this.labelComboCustomer.Location = new System.Drawing.Point(64, 37);
            this.labelComboCustomer.Name = "labelComboCustomer";
            this.labelComboCustomer.Size = new System.Drawing.Size(82, 13);
            this.labelComboCustomer.TabIndex = 1;
            this.labelComboCustomer.Text = "Customer Name";
            // 
            // textSONumber
            // 
            this.textSONumber.Location = new System.Drawing.Point(238, 54);
            this.textSONumber.Name = "textSONumber";
            this.textSONumber.Size = new System.Drawing.Size(121, 20);
            this.textSONumber.TabIndex = 2;
            // 
            // labelSONumber
            // 
            this.labelSONumber.AutoSize = true;
            this.labelSONumber.Location = new System.Drawing.Point(235, 38);
            this.labelSONumber.Name = "labelSONumber";
            this.labelSONumber.Size = new System.Drawing.Size(62, 13);
            this.labelSONumber.TabIndex = 3;
            this.labelSONumber.Text = "SO Number";
            // 
            // textPONumber
            // 
            this.textPONumber.Location = new System.Drawing.Point(417, 53);
            this.textPONumber.Name = "textPONumber";
            this.textPONumber.Size = new System.Drawing.Size(121, 20);
            this.textPONumber.TabIndex = 4;
            // 
            // labelPONumber
            // 
            this.labelPONumber.AutoSize = true;
            this.labelPONumber.Location = new System.Drawing.Point(414, 37);
            this.labelPONumber.Name = "labelPONumber";
            this.labelPONumber.Size = new System.Drawing.Size(62, 13);
            this.labelPONumber.TabIndex = 5;
            this.labelPONumber.Text = "PO Number";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(595, 54);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(121, 20);
            this.textDate.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(592, 37);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(84, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date Scheduled";
            // 
            // textBillTo
            // 
            this.textBillTo.Location = new System.Drawing.Point(67, 97);
            this.textBillTo.Multiline = true;
            this.textBillTo.Name = "textBillTo";
            this.textBillTo.Size = new System.Drawing.Size(121, 20);
            this.textBillTo.TabIndex = 8;
            // 
            // labelBillTo
            // 
            this.labelBillTo.AutoSize = true;
            this.labelBillTo.Location = new System.Drawing.Point(64, 81);
            this.labelBillTo.Name = "labelBillTo";
            this.labelBillTo.Size = new System.Drawing.Size(75, 13);
            this.labelBillTo.TabIndex = 9;
            this.labelBillTo.Text = "Billing Address";
            // 
            // textShipTo
            // 
            this.textShipTo.Location = new System.Drawing.Point(238, 97);
            this.textShipTo.Multiline = true;
            this.textShipTo.Name = "textShipTo";
            this.textShipTo.Size = new System.Drawing.Size(121, 20);
            this.textShipTo.TabIndex = 10;
            // 
            // labelShippingAddress
            // 
            this.labelShippingAddress.AutoSize = true;
            this.labelShippingAddress.Location = new System.Drawing.Point(235, 81);
            this.labelShippingAddress.Name = "labelShippingAddress";
            this.labelShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.labelShippingAddress.TabIndex = 11;
            this.labelShippingAddress.Text = "Shipping Address";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(64, 179);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(67, 195);
            this.textQuantity.Multiline = true;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(43, 20);
            this.textQuantity.TabIndex = 13;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(142, 179);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(27, 13);
            this.labelItem.TabIndex = 14;
            this.labelItem.Text = "Item";
            // 
            // comboItem
            // 
            this.comboItem.DataSource = this.inventoryBindingSource;
            this.comboItem.DisplayMember = "ProductName";
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(145, 194);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(110, 21);
            this.comboItem.TabIndex = 15;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DataSetName = "ComboBoxItems";
            this.comboBoxItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.comboBoxItems;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(241, 236);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(83, 13);
            this.labelItemDescription.TabIndex = 16;
            this.labelItemDescription.Text = "Item Description";
            // 
            // labelInvoiceItem
            // 
            this.labelInvoiceItem.AutoSize = true;
            this.labelInvoiceItem.Location = new System.Drawing.Point(142, 236);
            this.labelInvoiceItem.Name = "labelInvoiceItem";
            this.labelInvoiceItem.Size = new System.Drawing.Size(27, 13);
            this.labelInvoiceItem.TabIndex = 17;
            this.labelInvoiceItem.Text = "Item";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(393, 236);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.labelUnitPrice.TabIndex = 18;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(505, 236);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice.TabIndex = 19;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(618, 236);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(84, 13);
            this.labelInvoiceDate.TabIndex = 20;
            this.labelInvoiceDate.Text = "Date Scheduled";
            // 
            // labelLineItem
            // 
            this.labelLineItem.AutoSize = true;
            this.labelLineItem.Location = new System.Drawing.Point(64, 236);
            this.labelLineItem.Name = "labelLineItem";
            this.labelLineItem.Size = new System.Drawing.Size(67, 13);
            this.labelLineItem.TabIndex = 21;
            this.labelLineItem.Text = "Line Number";
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Location = new System.Drawing.Point(635, 428);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(72, 13);
            this.labelInvoiceTotal.TabIndex = 22;
            this.labelInvoiceTotal.Text = "Invoice Total:";
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(713, 425);
            this.textInvoiceTotal.Multiline = true;
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(43, 20);
            this.textInvoiceTotal.TabIndex = 23;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textInvoiceTotal);
            this.Controls.Add(this.labelInvoiceTotal);
            this.Controls.Add(this.labelLineItem);
            this.Controls.Add(this.labelInvoiceDate);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelInvoiceItem);
            this.Controls.Add(this.labelItemDescription);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelShippingAddress);
            this.Controls.Add(this.textShipTo);
            this.Controls.Add(this.labelBillTo);
            this.Controls.Add(this.textBillTo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.labelPONumber);
            this.Controls.Add(this.textPONumber);
            this.Controls.Add(this.labelSONumber);
            this.Controls.Add(this.textSONumber);
            this.Controls.Add(this.labelComboCustomer);
            this.Controls.Add(this.comboCustomerName);
            this.Name = "NewInvoiceForm";
            this.Text = "NewInvoiceForm";
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerNameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCustomerName;
        private CustomerNameList customerNameList;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CustomerNameListTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label labelComboCustomer;
        private System.Windows.Forms.TextBox textSONumber;
        private System.Windows.Forms.Label labelSONumber;
        private System.Windows.Forms.TextBox textPONumber;
        private System.Windows.Forms.Label labelPONumber;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBillTo;
        private System.Windows.Forms.Label labelBillTo;
        private System.Windows.Forms.TextBox textShipTo;
        private System.Windows.Forms.Label labelShippingAddress;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboItem;
        private ComboBoxItems comboBoxItems;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private ComboBoxItemsTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.Label labelInvoiceItem;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.Label labelLineItem;
        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.TextBox textInvoiceTotal;
    }
}