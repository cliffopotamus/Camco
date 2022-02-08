namespace CamcoForm
{
    partial class EditCustomerForm
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
            this.textShippingCity = new System.Windows.Forms.Label();
            this.textBillingCity = new System.Windows.Forms.Label();
            this.textCustomerBillingCity = new System.Windows.Forms.TextBox();
            this.textCustomerShippingCity = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelFax = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.textFax = new System.Windows.Forms.TextBox();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelBillingZipCode = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelShippingState = new System.Windows.Forms.Label();
            this.labelBillingState = new System.Windows.Forms.Label();
            this.labelCustomerShipAddress = new System.Windows.Forms.Label();
            this.labelShippingZipCode = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textCustomerShippingAddress = new System.Windows.Forms.TextBox();
            this.textCustomerShippingZip = new System.Windows.Forms.TextBox();
            this.textCustomerShippingState = new System.Windows.Forms.TextBox();
            this.textCustomerBillingAddress = new System.Windows.Forms.TextBox();
            this.textCustomerBillingZipCode = new System.Windows.Forms.TextBox();
            this.textCustomerBillingState = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.comboCustomerName = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camcoDataSet5 = new CamcoForm.CamcoDataSet5();
            this.customersTableAdapter = new CamcoForm.CamcoDataSet5TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // textShippingCity
            // 
            this.textShippingCity.AutoSize = true;
            this.textShippingCity.Location = new System.Drawing.Point(214, 224);
            this.textShippingCity.Name = "textShippingCity";
            this.textShippingCity.Size = new System.Drawing.Size(68, 13);
            this.textShippingCity.TabIndex = 51;
            this.textShippingCity.Text = "Shipping City";
            // 
            // textBillingCity
            // 
            this.textBillingCity.AutoSize = true;
            this.textBillingCity.Location = new System.Drawing.Point(214, 135);
            this.textBillingCity.Name = "textBillingCity";
            this.textBillingCity.Size = new System.Drawing.Size(54, 13);
            this.textBillingCity.TabIndex = 50;
            this.textBillingCity.Text = "Billing City";
            // 
            // textCustomerBillingCity
            // 
            this.textCustomerBillingCity.Location = new System.Drawing.Point(217, 151);
            this.textCustomerBillingCity.Name = "textCustomerBillingCity";
            this.textCustomerBillingCity.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingCity.TabIndex = 49;
            // 
            // textCustomerShippingCity
            // 
            this.textCustomerShippingCity.Location = new System.Drawing.Point(217, 240);
            this.textCustomerShippingCity.Name = "textCustomerShippingCity";
            this.textCustomerShippingCity.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingCity.TabIndex = 48;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(654, 391);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 25);
            this.buttonCancel.TabIndex = 47;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(531, 391);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(92, 25);
            this.buttonFinish.TabIndex = 46;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(528, 39);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(87, 13);
            this.labelAccount.TabIndex = 45;
            this.labelAccount.Text = "Account Number";
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(372, 35);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(64, 13);
            this.labelFax.TabIndex = 44;
            this.labelFax.Text = "Fax Number";
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(531, 55);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(85, 20);
            this.textAccount.TabIndex = 43;
            // 
            // textFax
            // 
            this.textFax.Location = new System.Drawing.Point(375, 55);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(85, 20);
            this.textFax.TabIndex = 42;
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(55, 135);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillingAddress.TabIndex = 41;
            this.labelBillingAddress.Text = "Billing Address";
            // 
            // labelBillingZipCode
            // 
            this.labelBillingZipCode.AutoSize = true;
            this.labelBillingZipCode.Location = new System.Drawing.Point(372, 135);
            this.labelBillingZipCode.Name = "labelBillingZipCode";
            this.labelBillingZipCode.Size = new System.Drawing.Size(80, 13);
            this.labelBillingZipCode.TabIndex = 40;
            this.labelBillingZipCode.Text = "Billing Zip Code";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(214, 35);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 39;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelShippingState
            // 
            this.labelShippingState.AutoSize = true;
            this.labelShippingState.Location = new System.Drawing.Point(528, 224);
            this.labelShippingState.Name = "labelShippingState";
            this.labelShippingState.Size = new System.Drawing.Size(76, 13);
            this.labelShippingState.TabIndex = 38;
            this.labelShippingState.Text = "Shipping State";
            // 
            // labelBillingState
            // 
            this.labelBillingState.AutoSize = true;
            this.labelBillingState.Location = new System.Drawing.Point(528, 135);
            this.labelBillingState.Name = "labelBillingState";
            this.labelBillingState.Size = new System.Drawing.Size(62, 13);
            this.labelBillingState.TabIndex = 37;
            this.labelBillingState.Text = "Billing State";
            // 
            // labelCustomerShipAddress
            // 
            this.labelCustomerShipAddress.AutoSize = true;
            this.labelCustomerShipAddress.Location = new System.Drawing.Point(55, 224);
            this.labelCustomerShipAddress.Name = "labelCustomerShipAddress";
            this.labelCustomerShipAddress.Size = new System.Drawing.Size(89, 13);
            this.labelCustomerShipAddress.TabIndex = 36;
            this.labelCustomerShipAddress.Text = "Shipping Address";
            // 
            // labelShippingZipCode
            // 
            this.labelShippingZipCode.AutoSize = true;
            this.labelShippingZipCode.Location = new System.Drawing.Point(372, 224);
            this.labelShippingZipCode.Name = "labelShippingZipCode";
            this.labelShippingZipCode.Size = new System.Drawing.Size(94, 13);
            this.labelShippingZipCode.TabIndex = 35;
            this.labelShippingZipCode.Text = "Shipping Zip Code";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(60, 35);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 34;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textCustomerShippingAddress
            // 
            this.textCustomerShippingAddress.Location = new System.Drawing.Point(57, 240);
            this.textCustomerShippingAddress.Name = "textCustomerShippingAddress";
            this.textCustomerShippingAddress.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingAddress.TabIndex = 33;
            // 
            // textCustomerShippingZip
            // 
            this.textCustomerShippingZip.Location = new System.Drawing.Point(375, 240);
            this.textCustomerShippingZip.Name = "textCustomerShippingZip";
            this.textCustomerShippingZip.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingZip.TabIndex = 32;
            // 
            // textCustomerShippingState
            // 
            this.textCustomerShippingState.Location = new System.Drawing.Point(531, 240);
            this.textCustomerShippingState.Name = "textCustomerShippingState";
            this.textCustomerShippingState.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingState.TabIndex = 31;
            // 
            // textCustomerBillingAddress
            // 
            this.textCustomerBillingAddress.Location = new System.Drawing.Point(58, 151);
            this.textCustomerBillingAddress.Name = "textCustomerBillingAddress";
            this.textCustomerBillingAddress.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingAddress.TabIndex = 30;
            // 
            // textCustomerBillingZipCode
            // 
            this.textCustomerBillingZipCode.Location = new System.Drawing.Point(375, 151);
            this.textCustomerBillingZipCode.Name = "textCustomerBillingZipCode";
            this.textCustomerBillingZipCode.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingZipCode.TabIndex = 29;
            // 
            // textCustomerBillingState
            // 
            this.textCustomerBillingState.Location = new System.Drawing.Point(530, 151);
            this.textCustomerBillingState.Name = "textCustomerBillingState";
            this.textCustomerBillingState.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingState.TabIndex = 28;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(217, 55);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(85, 20);
            this.textPhone.TabIndex = 27;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(58, 55);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(85, 20);
            this.textCustomerName.TabIndex = 26;
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(52, 318);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboCustomerName.Size = new System.Drawing.Size(165, 21);
            this.comboCustomerName.TabIndex = 52;
            this.comboCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboCustomerName_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.camcoDataSet5;
            // 
            // camcoDataSet5
            // 
            this.camcoDataSet5.DataSetName = "CamcoDataSet5";
            this.camcoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboCustomerName);
            this.Controls.Add(this.textShippingCity);
            this.Controls.Add(this.textBillingCity);
            this.Controls.Add(this.textCustomerBillingCity);
            this.Controls.Add(this.textCustomerShippingCity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelFax);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.textFax);
            this.Controls.Add(this.labelBillingAddress);
            this.Controls.Add(this.labelBillingZipCode);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelShippingState);
            this.Controls.Add(this.labelBillingState);
            this.Controls.Add(this.labelCustomerShipAddress);
            this.Controls.Add(this.labelShippingZipCode);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textCustomerShippingAddress);
            this.Controls.Add(this.textCustomerShippingZip);
            this.Controls.Add(this.textCustomerShippingState);
            this.Controls.Add(this.textCustomerBillingAddress);
            this.Controls.Add(this.textCustomerBillingZipCode);
            this.Controls.Add(this.textCustomerBillingState);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textCustomerName);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textShippingCity;
        private System.Windows.Forms.Label textBillingCity;
        private System.Windows.Forms.TextBox textCustomerBillingCity;
        private System.Windows.Forms.TextBox textCustomerShippingCity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.Label labelBillingZipCode;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelShippingState;
        private System.Windows.Forms.Label labelBillingState;
        private System.Windows.Forms.Label labelCustomerShipAddress;
        private System.Windows.Forms.Label labelShippingZipCode;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textCustomerShippingAddress;
        private System.Windows.Forms.TextBox textCustomerShippingZip;
        private System.Windows.Forms.TextBox textCustomerShippingState;
        private System.Windows.Forms.TextBox textCustomerBillingAddress;
        private System.Windows.Forms.TextBox textCustomerBillingZipCode;
        private System.Windows.Forms.TextBox textCustomerBillingState;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.ComboBox comboCustomerName;
        private CamcoDataSet5 camcoDataSet5;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CamcoDataSet5TableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}