namespace CamcoForm
{
    partial class NewCustomerForm
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
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textCustomerBillingState = new System.Windows.Forms.TextBox();
            this.textCustomerBillingZipCode = new System.Windows.Forms.TextBox();
            this.textCustomerBillingAddress = new System.Windows.Forms.TextBox();
            this.textCustomerShippingState = new System.Windows.Forms.TextBox();
            this.textCustomerShippingZip = new System.Windows.Forms.TextBox();
            this.textCustomerShippingAddress = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelShippingZipCode = new System.Windows.Forms.Label();
            this.labelCustomerShipAddress = new System.Windows.Forms.Label();
            this.labelBillingState = new System.Windows.Forms.Label();
            this.labelShippingState = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBillingZipCode = new System.Windows.Forms.Label();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.textFax = new System.Windows.Forms.TextBox();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textCustomerShippingCity = new System.Windows.Forms.TextBox();
            this.textCustomerBillingCity = new System.Windows.Forms.TextBox();
            this.textBillingCity = new System.Windows.Forms.Label();
            this.textShippingCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(62, 61);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(85, 20);
            this.textCustomerName.TabIndex = 0;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(221, 61);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(85, 20);
            this.textPhone.TabIndex = 1;
            // 
            // textCustomerBillingState
            // 
            this.textCustomerBillingState.Location = new System.Drawing.Point(534, 157);
            this.textCustomerBillingState.Name = "textCustomerBillingState";
            this.textCustomerBillingState.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingState.TabIndex = 2;
            // 
            // textCustomerBillingZipCode
            // 
            this.textCustomerBillingZipCode.Location = new System.Drawing.Point(379, 157);
            this.textCustomerBillingZipCode.Name = "textCustomerBillingZipCode";
            this.textCustomerBillingZipCode.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingZipCode.TabIndex = 3;
            // 
            // textCustomerBillingAddress
            // 
            this.textCustomerBillingAddress.Location = new System.Drawing.Point(62, 157);
            this.textCustomerBillingAddress.Name = "textCustomerBillingAddress";
            this.textCustomerBillingAddress.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingAddress.TabIndex = 4;
            // 
            // textCustomerShippingState
            // 
            this.textCustomerShippingState.Location = new System.Drawing.Point(535, 246);
            this.textCustomerShippingState.Name = "textCustomerShippingState";
            this.textCustomerShippingState.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingState.TabIndex = 5;
            // 
            // textCustomerShippingZip
            // 
            this.textCustomerShippingZip.Location = new System.Drawing.Point(379, 246);
            this.textCustomerShippingZip.Name = "textCustomerShippingZip";
            this.textCustomerShippingZip.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingZip.TabIndex = 6;
            // 
            // textCustomerShippingAddress
            // 
            this.textCustomerShippingAddress.Location = new System.Drawing.Point(61, 246);
            this.textCustomerShippingAddress.Name = "textCustomerShippingAddress";
            this.textCustomerShippingAddress.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingAddress.TabIndex = 7;
            this.textCustomerShippingAddress.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(64, 41);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 8;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelShippingZipCode
            // 
            this.labelShippingZipCode.AutoSize = true;
            this.labelShippingZipCode.Location = new System.Drawing.Point(376, 230);
            this.labelShippingZipCode.Name = "labelShippingZipCode";
            this.labelShippingZipCode.Size = new System.Drawing.Size(94, 13);
            this.labelShippingZipCode.TabIndex = 9;
            this.labelShippingZipCode.Text = "Shipping Zip Code";
            // 
            // labelCustomerShipAddress
            // 
            this.labelCustomerShipAddress.AutoSize = true;
            this.labelCustomerShipAddress.Location = new System.Drawing.Point(59, 230);
            this.labelCustomerShipAddress.Name = "labelCustomerShipAddress";
            this.labelCustomerShipAddress.Size = new System.Drawing.Size(89, 13);
            this.labelCustomerShipAddress.TabIndex = 10;
            this.labelCustomerShipAddress.Text = "Shipping Address";
            // 
            // labelBillingState
            // 
            this.labelBillingState.AutoSize = true;
            this.labelBillingState.Location = new System.Drawing.Point(532, 141);
            this.labelBillingState.Name = "labelBillingState";
            this.labelBillingState.Size = new System.Drawing.Size(62, 13);
            this.labelBillingState.TabIndex = 11;
            this.labelBillingState.Text = "Billing State";
            // 
            // labelShippingState
            // 
            this.labelShippingState.AutoSize = true;
            this.labelShippingState.Location = new System.Drawing.Point(532, 230);
            this.labelShippingState.Name = "labelShippingState";
            this.labelShippingState.Size = new System.Drawing.Size(76, 13);
            this.labelShippingState.TabIndex = 12;
            this.labelShippingState.Text = "Shipping State";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(218, 41);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelBillingZipCode
            // 
            this.labelBillingZipCode.AutoSize = true;
            this.labelBillingZipCode.Location = new System.Drawing.Point(376, 141);
            this.labelBillingZipCode.Name = "labelBillingZipCode";
            this.labelBillingZipCode.Size = new System.Drawing.Size(80, 13);
            this.labelBillingZipCode.TabIndex = 14;
            this.labelBillingZipCode.Text = "Billing Zip Code";
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(59, 141);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.labelBillingAddress.TabIndex = 15;
            this.labelBillingAddress.Text = "Billing Address";
            // 
            // textFax
            // 
            this.textFax.Location = new System.Drawing.Point(379, 61);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(85, 20);
            this.textFax.TabIndex = 16;
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(535, 61);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(85, 20);
            this.textAccount.TabIndex = 17;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(376, 41);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(64, 13);
            this.labelFax.TabIndex = 18;
            this.labelFax.Text = "Fax Number";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(532, 45);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(87, 13);
            this.labelAccount.TabIndex = 19;
            this.labelAccount.Text = "Account Number";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(535, 397);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(92, 25);
            this.buttonFinish.TabIndex = 20;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(658, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 25);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textCustomerShippingCity
            // 
            this.textCustomerShippingCity.Location = new System.Drawing.Point(221, 246);
            this.textCustomerShippingCity.Name = "textCustomerShippingCity";
            this.textCustomerShippingCity.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShippingCity.TabIndex = 22;
            // 
            // textCustomerBillingCity
            // 
            this.textCustomerBillingCity.Location = new System.Drawing.Point(221, 157);
            this.textCustomerBillingCity.Name = "textCustomerBillingCity";
            this.textCustomerBillingCity.Size = new System.Drawing.Size(85, 20);
            this.textCustomerBillingCity.TabIndex = 23;
            // 
            // textBillingCity
            // 
            this.textBillingCity.AutoSize = true;
            this.textBillingCity.Location = new System.Drawing.Point(218, 141);
            this.textBillingCity.Name = "textBillingCity";
            this.textBillingCity.Size = new System.Drawing.Size(54, 13);
            this.textBillingCity.TabIndex = 24;
            this.textBillingCity.Text = "Billing City";
            // 
            // textShippingCity
            // 
            this.textShippingCity.AutoSize = true;
            this.textShippingCity.Location = new System.Drawing.Point(218, 230);
            this.textShippingCity.Name = "textShippingCity";
            this.textShippingCity.Size = new System.Drawing.Size(68, 13);
            this.textShippingCity.TabIndex = 25;
            this.textShippingCity.Text = "Shipping City";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "NewCustomerForm";
            this.Text = "NewCustomerForm";
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textCustomerBillingState;
        private System.Windows.Forms.TextBox textCustomerBillingZipCode;
        private System.Windows.Forms.TextBox textCustomerBillingAddress;
        private System.Windows.Forms.TextBox textCustomerShippingState;
        private System.Windows.Forms.TextBox textCustomerShippingZip;
        private System.Windows.Forms.TextBox textCustomerShippingAddress;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelShippingZipCode;
        private System.Windows.Forms.Label labelCustomerShipAddress;
        private System.Windows.Forms.Label labelBillingState;
        private System.Windows.Forms.Label labelShippingState;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBillingZipCode;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textCustomerShippingCity;
        private System.Windows.Forms.TextBox textCustomerBillingCity;
        private System.Windows.Forms.Label textBillingCity;
        private System.Windows.Forms.Label textShippingCity;
    }
}