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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameList = new CamcoForm.CustomerNameList();
            this.customersTableAdapter = new CamcoForm.CustomerNameListTableAdapters.CustomersTableAdapter();
            this.labelComboCustomer = new System.Windows.Forms.Label();
            this.textSONumber = new System.Windows.Forms.TextBox();
            this.labelSONumber = new System.Windows.Forms.Label();
            this.textPONumber = new System.Windows.Forms.TextBox();
            this.labelPONumber = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBillAddress = new System.Windows.Forms.TextBox();
            this.labelBillAddress = new System.Windows.Forms.Label();
            this.textShipAddress = new System.Windows.Forms.TextBox();
            this.labelShippingAddress = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.comboInventory = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.labelInvoiceItem = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.labelLineItem = new System.Windows.Forms.Label();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            this.textInvoiceTotal = new System.Windows.Forms.TextBox();
            this.textBillZip = new System.Windows.Forms.TextBox();
            this.textBillCity = new System.Windows.Forms.TextBox();
            this.textShipZip = new System.Windows.Forms.TextBox();
            this.textShipCity = new System.Windows.Forms.TextBox();
            this.labelBillZip = new System.Windows.Forms.Label();
            this.labelShipCity = new System.Windows.Forms.Label();
            this.labelBillCity = new System.Windows.Forms.Label();
            this.labelShipZip = new System.Windows.Forms.Label();
            this.labelShipState = new System.Windows.Forms.Label();
            this.labelBillState = new System.Windows.Forms.Label();
            this.textShipState = new System.Windows.Forms.TextBox();
            this.textBillState = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.DataSource = this.customersBindingSource;
            this.comboCustomerName.DisplayMember = "CustomerName";
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(32, 25);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(121, 21);
            this.comboCustomerName.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customerNameList;
            // 
            // customerNameList
            // 
            this.customerNameList.DataSetName = "CustomerNameList";
            this.customerNameList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // labelComboCustomer
            // 
            this.labelComboCustomer.AutoSize = true;
            this.labelComboCustomer.Location = new System.Drawing.Point(28, 9);
            this.labelComboCustomer.Name = "labelComboCustomer";
            this.labelComboCustomer.Size = new System.Drawing.Size(82, 13);
            this.labelComboCustomer.TabIndex = 1;
            this.labelComboCustomer.Text = "Customer Name";
            // 
            // textSONumber
            // 
            this.textSONumber.Location = new System.Drawing.Point(179, 25);
            this.textSONumber.Name = "textSONumber";
            this.textSONumber.Size = new System.Drawing.Size(121, 20);
            this.textSONumber.TabIndex = 2;
            // 
            // labelSONumber
            // 
            this.labelSONumber.AutoSize = true;
            this.labelSONumber.Location = new System.Drawing.Point(176, 9);
            this.labelSONumber.Name = "labelSONumber";
            this.labelSONumber.Size = new System.Drawing.Size(62, 13);
            this.labelSONumber.TabIndex = 3;
            this.labelSONumber.Text = "SO Number";
            // 
            // textPONumber
            // 
            this.textPONumber.Location = new System.Drawing.Point(322, 25);
            this.textPONumber.Name = "textPONumber";
            this.textPONumber.Size = new System.Drawing.Size(121, 20);
            this.textPONumber.TabIndex = 4;
            // 
            // labelPONumber
            // 
            this.labelPONumber.AutoSize = true;
            this.labelPONumber.Location = new System.Drawing.Point(319, 9);
            this.labelPONumber.Name = "labelPONumber";
            this.labelPONumber.Size = new System.Drawing.Size(62, 13);
            this.labelPONumber.TabIndex = 5;
            this.labelPONumber.Text = "PO Number";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(465, 25);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(121, 20);
            this.textDate.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(462, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(84, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date Scheduled";
            // 
            // textBillAddress
            // 
            this.textBillAddress.Location = new System.Drawing.Point(31, 78);
            this.textBillAddress.Multiline = true;
            this.textBillAddress.Name = "textBillAddress";
            this.textBillAddress.Size = new System.Drawing.Size(121, 25);
            this.textBillAddress.TabIndex = 8;
            // 
            // labelBillAddress
            // 
            this.labelBillAddress.AutoSize = true;
            this.labelBillAddress.Location = new System.Drawing.Point(29, 62);
            this.labelBillAddress.Name = "labelBillAddress";
            this.labelBillAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillAddress.TabIndex = 9;
            this.labelBillAddress.Text = "Billing Address";
            // 
            // textShipAddress
            // 
            this.textShipAddress.Location = new System.Drawing.Point(31, 132);
            this.textShipAddress.Multiline = true;
            this.textShipAddress.Name = "textShipAddress";
            this.textShipAddress.Size = new System.Drawing.Size(121, 25);
            this.textShipAddress.TabIndex = 10;
            // 
            // labelShippingAddress
            // 
            this.labelShippingAddress.AutoSize = true;
            this.labelShippingAddress.Location = new System.Drawing.Point(28, 118);
            this.labelShippingAddress.Name = "labelShippingAddress";
            this.labelShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.labelShippingAddress.TabIndex = 11;
            this.labelShippingAddress.Text = "Shipping Address";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(28, 169);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(31, 185);
            this.textQuantity.Multiline = true;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(43, 20);
            this.textQuantity.TabIndex = 13;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(104, 169);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(27, 13);
            this.labelItem.TabIndex = 14;
            this.labelItem.Text = "Item";
            // 
            // comboInventory
            // 
            this.comboInventory.FormattingEnabled = true;
            this.comboInventory.Location = new System.Drawing.Point(107, 185);
            this.comboInventory.Name = "comboInventory";
            this.comboInventory.Size = new System.Drawing.Size(241, 21);
            this.comboInventory.TabIndex = 15;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(155, 220);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(83, 13);
            this.labelItemDescription.TabIndex = 16;
            this.labelItemDescription.Text = "Item Description";
            // 
            // labelInvoiceItem
            // 
            this.labelInvoiceItem.AutoSize = true;
            this.labelInvoiceItem.Location = new System.Drawing.Point(104, 220);
            this.labelInvoiceItem.Name = "labelInvoiceItem";
            this.labelInvoiceItem.Size = new System.Drawing.Size(27, 13);
            this.labelInvoiceItem.TabIndex = 17;
            this.labelInvoiceItem.Text = "Item";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(328, 220);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.labelUnitPrice.TabIndex = 18;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(405, 220);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice.TabIndex = 19;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(505, 220);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(84, 13);
            this.labelInvoiceDate.TabIndex = 20;
            this.labelInvoiceDate.Text = "Date Scheduled";
            // 
            // labelLineItem
            // 
            this.labelLineItem.AutoSize = true;
            this.labelLineItem.Location = new System.Drawing.Point(28, 220);
            this.labelLineItem.Name = "labelLineItem";
            this.labelLineItem.Size = new System.Drawing.Size(67, 13);
            this.labelLineItem.TabIndex = 21;
            this.labelLineItem.Text = "Line Number";
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Location = new System.Drawing.Point(574, 406);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(72, 13);
            this.labelInvoiceTotal.TabIndex = 22;
            this.labelInvoiceTotal.Text = "Invoice Total:";
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(583, 422);
            this.textInvoiceTotal.Multiline = true;
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(43, 20);
            this.textInvoiceTotal.TabIndex = 23;
            // 
            // textBillZip
            // 
            this.textBillZip.Location = new System.Drawing.Point(322, 78);
            this.textBillZip.Multiline = true;
            this.textBillZip.Name = "textBillZip";
            this.textBillZip.Size = new System.Drawing.Size(121, 25);
            this.textBillZip.TabIndex = 24;
            // 
            // textBillCity
            // 
            this.textBillCity.Location = new System.Drawing.Point(182, 78);
            this.textBillCity.Multiline = true;
            this.textBillCity.Name = "textBillCity";
            this.textBillCity.Size = new System.Drawing.Size(121, 25);
            this.textBillCity.TabIndex = 25;
            // 
            // textShipZip
            // 
            this.textShipZip.Location = new System.Drawing.Point(322, 132);
            this.textShipZip.Multiline = true;
            this.textShipZip.Name = "textShipZip";
            this.textShipZip.Size = new System.Drawing.Size(121, 25);
            this.textShipZip.TabIndex = 26;
            // 
            // textShipCity
            // 
            this.textShipCity.Location = new System.Drawing.Point(182, 134);
            this.textShipCity.Multiline = true;
            this.textShipCity.Name = "textShipCity";
            this.textShipCity.Size = new System.Drawing.Size(121, 25);
            this.textShipCity.TabIndex = 27;
            // 
            // labelBillZip
            // 
            this.labelBillZip.AutoSize = true;
            this.labelBillZip.Location = new System.Drawing.Point(319, 62);
            this.labelBillZip.Name = "labelBillZip";
            this.labelBillZip.Size = new System.Drawing.Size(52, 13);
            this.labelBillZip.TabIndex = 28;
            this.labelBillZip.Text = "Billing Zip";
            // 
            // labelShipCity
            // 
            this.labelShipCity.AutoSize = true;
            this.labelShipCity.Location = new System.Drawing.Point(187, 118);
            this.labelShipCity.Name = "labelShipCity";
            this.labelShipCity.Size = new System.Drawing.Size(68, 13);
            this.labelShipCity.TabIndex = 29;
            this.labelShipCity.Text = "Shipping City";
            // 
            // labelBillCity
            // 
            this.labelBillCity.AutoSize = true;
            this.labelBillCity.Location = new System.Drawing.Point(184, 62);
            this.labelBillCity.Name = "labelBillCity";
            this.labelBillCity.Size = new System.Drawing.Size(54, 13);
            this.labelBillCity.TabIndex = 30;
            this.labelBillCity.Text = "Billing City";
            // 
            // labelShipZip
            // 
            this.labelShipZip.AutoSize = true;
            this.labelShipZip.Location = new System.Drawing.Point(319, 118);
            this.labelShipZip.Name = "labelShipZip";
            this.labelShipZip.Size = new System.Drawing.Size(66, 13);
            this.labelShipZip.TabIndex = 31;
            this.labelShipZip.Text = "Shipping Zip";
            // 
            // labelShipState
            // 
            this.labelShipState.AutoSize = true;
            this.labelShipState.Location = new System.Drawing.Point(453, 118);
            this.labelShipState.Name = "labelShipState";
            this.labelShipState.Size = new System.Drawing.Size(76, 13);
            this.labelShipState.TabIndex = 32;
            this.labelShipState.Text = "Shipping State";
            // 
            // labelBillState
            // 
            this.labelBillState.AutoSize = true;
            this.labelBillState.Location = new System.Drawing.Point(453, 62);
            this.labelBillState.Name = "labelBillState";
            this.labelBillState.Size = new System.Drawing.Size(62, 13);
            this.labelBillState.TabIndex = 33;
            this.labelBillState.Text = "Billing State";
            // 
            // textShipState
            // 
            this.textShipState.Location = new System.Drawing.Point(456, 134);
            this.textShipState.Multiline = true;
            this.textShipState.Name = "textShipState";
            this.textShipState.Size = new System.Drawing.Size(121, 25);
            this.textShipState.TabIndex = 34;
            // 
            // textBillState
            // 
            this.textBillState.Location = new System.Drawing.Point(456, 78);
            this.textBillState.Multiline = true;
            this.textBillState.Name = "textBillState";
            this.textBillState.Size = new System.Drawing.Size(121, 25);
            this.textBillState.TabIndex = 35;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(646, 418);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 27);
            this.btnFinish.TabIndex = 36;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 27);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Item,
            this.ItemDescription,
            this.UnitPrice,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(31, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 189);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(366, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 21);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.textBillState);
            this.Controls.Add(this.textShipState);
            this.Controls.Add(this.labelBillState);
            this.Controls.Add(this.labelShipState);
            this.Controls.Add(this.labelShipZip);
            this.Controls.Add(this.labelBillCity);
            this.Controls.Add(this.labelShipCity);
            this.Controls.Add(this.labelBillZip);
            this.Controls.Add(this.textShipCity);
            this.Controls.Add(this.textShipZip);
            this.Controls.Add(this.textBillCity);
            this.Controls.Add(this.textBillZip);
            this.Controls.Add(this.textInvoiceTotal);
            this.Controls.Add(this.labelInvoiceTotal);
            this.Controls.Add(this.labelLineItem);
            this.Controls.Add(this.labelInvoiceDate);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelInvoiceItem);
            this.Controls.Add(this.labelItemDescription);
            this.Controls.Add(this.comboInventory);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelShippingAddress);
            this.Controls.Add(this.textShipAddress);
            this.Controls.Add(this.labelBillAddress);
            this.Controls.Add(this.textBillAddress);
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
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBillAddress;
        private System.Windows.Forms.Label labelBillAddress;
        private System.Windows.Forms.TextBox textShipAddress;
        private System.Windows.Forms.Label labelShippingAddress;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboInventory;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.Label labelInvoiceItem;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.Label labelLineItem;
        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.TextBox textInvoiceTotal;
        private System.Windows.Forms.TextBox textBillZip;
        private System.Windows.Forms.TextBox textBillCity;
        private System.Windows.Forms.TextBox textShipZip;
        private System.Windows.Forms.TextBox textShipCity;
        private System.Windows.Forms.Label labelBillZip;
        private System.Windows.Forms.Label labelShipCity;
        private System.Windows.Forms.Label labelBillCity;
        private System.Windows.Forms.Label labelShipZip;
        private System.Windows.Forms.Label labelShipState;
        private System.Windows.Forms.Label labelBillState;
        private System.Windows.Forms.TextBox textShipState;
        private System.Windows.Forms.TextBox textBillState;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}