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
            this.textBillingState = new System.Windows.Forms.TextBox();
            this.textBillingZipCode = new System.Windows.Forms.TextBox();
            this.textBillingAddress = new System.Windows.Forms.TextBox();
            this.textCustomerShipState = new System.Windows.Forms.TextBox();
            this.textCustomerShipZip = new System.Windows.Forms.TextBox();
            this.textCustomerAddress = new System.Windows.Forms.TextBox();
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
            // textBillingState
            // 
            this.textBillingState.Location = new System.Drawing.Point(379, 157);
            this.textBillingState.Name = "textBillingState";
            this.textBillingState.Size = new System.Drawing.Size(85, 20);
            this.textBillingState.TabIndex = 2;
            // 
            // textBillingZipCode
            // 
            this.textBillingZipCode.Location = new System.Drawing.Point(221, 157);
            this.textBillingZipCode.Name = "textBillingZipCode";
            this.textBillingZipCode.Size = new System.Drawing.Size(85, 20);
            this.textBillingZipCode.TabIndex = 3;
            // 
            // textBillingAddress
            // 
            this.textBillingAddress.Location = new System.Drawing.Point(62, 157);
            this.textBillingAddress.Name = "textBillingAddress";
            this.textBillingAddress.Size = new System.Drawing.Size(85, 20);
            this.textBillingAddress.TabIndex = 4;
            // 
            // textCustomerShipState
            // 
            this.textCustomerShipState.Location = new System.Drawing.Point(379, 246);
            this.textCustomerShipState.Name = "textCustomerShipState";
            this.textCustomerShipState.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShipState.TabIndex = 5;
            // 
            // textCustomerShipZip
            // 
            this.textCustomerShipZip.Location = new System.Drawing.Point(221, 246);
            this.textCustomerShipZip.Name = "textCustomerShipZip";
            this.textCustomerShipZip.Size = new System.Drawing.Size(85, 20);
            this.textCustomerShipZip.TabIndex = 6;
            // 
            // textCustomerAddress
            // 
            this.textCustomerAddress.Location = new System.Drawing.Point(61, 246);
            this.textCustomerAddress.Name = "textCustomerAddress";
            this.textCustomerAddress.Size = new System.Drawing.Size(85, 20);
            this.textCustomerAddress.TabIndex = 7;
            this.textCustomerAddress.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
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
            this.labelShippingZipCode.Location = new System.Drawing.Point(218, 230);
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
            this.labelBillingState.Location = new System.Drawing.Point(378, 141);
            this.labelBillingState.Name = "labelBillingState";
            this.labelBillingState.Size = new System.Drawing.Size(62, 13);
            this.labelBillingState.TabIndex = 11;
            this.labelBillingState.Text = "Billing State";
            // 
            // labelShippingState
            // 
            this.labelShippingState.AutoSize = true;
            this.labelShippingState.Location = new System.Drawing.Point(378, 230);
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
            this.labelBillingZipCode.Location = new System.Drawing.Point(218, 141);
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
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(658, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 25);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.textCustomerAddress);
            this.Controls.Add(this.textCustomerShipZip);
            this.Controls.Add(this.textCustomerShipState);
            this.Controls.Add(this.textBillingAddress);
            this.Controls.Add(this.textBillingZipCode);
            this.Controls.Add(this.textBillingState);
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
        private System.Windows.Forms.TextBox textBillingState;
        private System.Windows.Forms.TextBox textBillingZipCode;
        private System.Windows.Forms.TextBox textBillingAddress;
        private System.Windows.Forms.TextBox textCustomerShipState;
        private System.Windows.Forms.TextBox textCustomerShipZip;
        private System.Windows.Forms.TextBox textCustomerAddress;
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
    }
}