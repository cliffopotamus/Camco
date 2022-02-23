namespace CamcoForm
{
    partial class NewPurchaseForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.textState = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textBillZip = new System.Windows.Forms.TextBox();
            this.labelLineItem = new System.Windows.Forms.Label();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelInvoiceItem = new System.Windows.Forms.Label();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelPONumber = new System.Windows.Forms.Label();
            this.textPONumber = new System.Windows.Forms.TextBox();
            this.labelSONumber = new System.Windows.Forms.Label();
            this.textSONumber = new System.Windows.Forms.TextBox();
            this.labelComboVendor = new System.Windows.Forms.Label();
            this.comboVendorName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(719, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 27);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(643, 416);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 27);
            this.btnFinish.TabIndex = 72;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(453, 76);
            this.textState.Multiline = true;
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(121, 25);
            this.textState.TabIndex = 71;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(450, 60);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 69;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(176, 60);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 66;
            this.labelCity.Text = "City";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(316, 60);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(50, 13);
            this.labelZip.TabIndex = 64;
            this.labelZip.Text = "Zip Code";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(179, 76);
            this.textCity.Multiline = true;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(121, 25);
            this.textCity.TabIndex = 61;
            // 
            // textBillZip
            // 
            this.textBillZip.Location = new System.Drawing.Point(319, 76);
            this.textBillZip.Multiline = true;
            this.textBillZip.Name = "textBillZip";
            this.textBillZip.Size = new System.Drawing.Size(121, 25);
            this.textBillZip.TabIndex = 60;
            // 
            // labelLineItem
            // 
            this.labelLineItem.AutoSize = true;
            this.labelLineItem.Location = new System.Drawing.Point(32, 234);
            this.labelLineItem.Name = "labelLineItem";
            this.labelLineItem.Size = new System.Drawing.Size(67, 13);
            this.labelLineItem.TabIndex = 59;
            this.labelLineItem.Text = "Line Number";
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(615, 234);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(84, 13);
            this.labelInvoiceDate.TabIndex = 58;
            this.labelInvoiceDate.Text = "Date Scheduled";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(502, 234);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice.TabIndex = 57;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(390, 234);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.labelUnitPrice.TabIndex = 56;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelInvoiceItem
            // 
            this.labelInvoiceItem.AutoSize = true;
            this.labelInvoiceItem.Location = new System.Drawing.Point(123, 234);
            this.labelInvoiceItem.Name = "labelInvoiceItem";
            this.labelInvoiceItem.Size = new System.Drawing.Size(27, 13);
            this.labelInvoiceItem.TabIndex = 55;
            this.labelInvoiceItem.Text = "Item";
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(214, 234);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(83, 13);
            this.labelItemDescription.TabIndex = 54;
            this.labelItemDescription.Text = "Item Description";
            // 
            // comboItem
            // 
            this.comboItem.DisplayMember = "ProductName";
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(104, 191);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(241, 21);
            this.comboItem.TabIndex = 53;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(101, 177);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(27, 13);
            this.labelItem.TabIndex = 52;
            this.labelItem.Text = "Item";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(29, 192);
            this.textQuantity.Multiline = true;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(43, 20);
            this.textQuantity.TabIndex = 51;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(31, 126);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 50;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(32, 60);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 47;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(35, 76);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(121, 25);
            this.textAddress.TabIndex = 46;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(459, 7);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(84, 13);
            this.labelDate.TabIndex = 45;
            this.labelDate.Text = "Date Scheduled";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(462, 23);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(121, 20);
            this.textDate.TabIndex = 44;
            // 
            // labelPONumber
            // 
            this.labelPONumber.AutoSize = true;
            this.labelPONumber.Location = new System.Drawing.Point(316, 7);
            this.labelPONumber.Name = "labelPONumber";
            this.labelPONumber.Size = new System.Drawing.Size(62, 13);
            this.labelPONumber.TabIndex = 43;
            this.labelPONumber.Text = "PO Number";
            // 
            // textPONumber
            // 
            this.textPONumber.Location = new System.Drawing.Point(319, 23);
            this.textPONumber.Name = "textPONumber";
            this.textPONumber.Size = new System.Drawing.Size(121, 20);
            this.textPONumber.TabIndex = 42;
            // 
            // labelSONumber
            // 
            this.labelSONumber.AutoSize = true;
            this.labelSONumber.Location = new System.Drawing.Point(173, 7);
            this.labelSONumber.Name = "labelSONumber";
            this.labelSONumber.Size = new System.Drawing.Size(62, 13);
            this.labelSONumber.TabIndex = 41;
            this.labelSONumber.Text = "SO Number";
            // 
            // textSONumber
            // 
            this.textSONumber.Location = new System.Drawing.Point(176, 23);
            this.textSONumber.Name = "textSONumber";
            this.textSONumber.Size = new System.Drawing.Size(121, 20);
            this.textSONumber.TabIndex = 40;
            // 
            // labelComboVendor
            // 
            this.labelComboVendor.AutoSize = true;
            this.labelComboVendor.Location = new System.Drawing.Point(25, 7);
            this.labelComboVendor.Name = "labelComboVendor";
            this.labelComboVendor.Size = new System.Drawing.Size(72, 13);
            this.labelComboVendor.TabIndex = 39;
            this.labelComboVendor.Text = "Vendor Name";
            // 
            // comboVendorName
            // 
            this.comboVendorName.DisplayMember = "CustomerName";
            this.comboVendorName.FormattingEnabled = true;
            this.comboVendorName.Location = new System.Drawing.Point(29, 23);
            this.comboVendorName.Name = "comboVendorName";
            this.comboVendorName.Size = new System.Drawing.Size(121, 21);
            this.comboVendorName.TabIndex = 38;
            // 
            // NewPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textBillZip);
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
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.labelPONumber);
            this.Controls.Add(this.textPONumber);
            this.Controls.Add(this.labelSONumber);
            this.Controls.Add(this.textSONumber);
            this.Controls.Add(this.labelComboVendor);
            this.Controls.Add(this.comboVendorName);
            this.Name = "NewPurchaseForm";
            this.Text = "NewPurchaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textBillZip;
        private System.Windows.Forms.Label labelLineItem;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelInvoiceItem;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label labelPONumber;
        private System.Windows.Forms.TextBox textPONumber;
        private System.Windows.Forms.Label labelSONumber;
        private System.Windows.Forms.TextBox textSONumber;
        private System.Windows.Forms.Label labelComboVendor;
        private System.Windows.Forms.ComboBox comboVendorName;
    }
}