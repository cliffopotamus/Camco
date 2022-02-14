namespace CamcoForm
{
    partial class NewVendorForm
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
            this.labelVendorAddress = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFax = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textFax = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelFinish = new System.Windows.Forms.Button();
            this.labelCancel = new System.Windows.Forms.Button();
            this.textAccountNo = new System.Windows.Forms.TextBox();
            this.labelAccountNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVendorAddress
            // 
            this.labelVendorAddress.AutoSize = true;
            this.labelVendorAddress.Location = new System.Drawing.Point(61, 187);
            this.labelVendorAddress.Name = "labelVendorAddress";
            this.labelVendorAddress.Size = new System.Drawing.Size(45, 13);
            this.labelVendorAddress.TabIndex = 0;
            this.labelVendorAddress.Text = "Address";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(61, 84);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(72, 13);
            this.labelVendorName.TabIndex = 1;
            this.labelVendorName.Text = "Vendor Name";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(241, 187);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(50, 13);
            this.labelZipCode.TabIndex = 2;
            this.labelZipCode.Text = "Zip Code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(412, 187);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(603, 187);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(241, 84);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(412, 84);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(64, 13);
            this.labelFax.TabIndex = 6;
            this.labelFax.Text = "Fax Number";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(64, 100);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(123, 20);
            this.textName.TabIndex = 7;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(244, 100);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(123, 20);
            this.textPhone.TabIndex = 8;
            // 
            // textFax
            // 
            this.textFax.Location = new System.Drawing.Point(415, 100);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(123, 20);
            this.textFax.TabIndex = 9;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(244, 203);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(62, 20);
            this.textZip.TabIndex = 11;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(606, 203);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(46, 20);
            this.textState.TabIndex = 12;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(415, 203);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(123, 20);
            this.textCity.TabIndex = 13;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(64, 203);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(123, 20);
            this.textAddress.TabIndex = 14;
            // 
            // labelFinish
            // 
            this.labelFinish.Location = new System.Drawing.Point(520, 414);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(115, 24);
            this.labelFinish.TabIndex = 15;
            this.labelFinish.Text = "Add Vendor";
            this.labelFinish.UseVisualStyleBackColor = true;
            this.labelFinish.Click += new System.EventHandler(this.labelFinish_Click);
            // 
            // labelCancel
            // 
            this.labelCancel.Location = new System.Drawing.Point(672, 414);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(86, 24);
            this.labelCancel.TabIndex = 16;
            this.labelCancel.Text = "Cancel";
            this.labelCancel.UseVisualStyleBackColor = true;
            this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
            // 
            // textAccountNo
            // 
            this.textAccountNo.Location = new System.Drawing.Point(590, 100);
            this.textAccountNo.Name = "textAccountNo";
            this.textAccountNo.Size = new System.Drawing.Size(62, 20);
            this.textAccountNo.TabIndex = 17;
            // 
            // labelAccountNo
            // 
            this.labelAccountNo.AutoSize = true;
            this.labelAccountNo.Location = new System.Drawing.Point(587, 84);
            this.labelAccountNo.Name = "labelAccountNo";
            this.labelAccountNo.Size = new System.Drawing.Size(67, 13);
            this.labelAccountNo.TabIndex = 18;
            this.labelAccountNo.Text = "Account No.";
            // 
            // NewVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAccountNo);
            this.Controls.Add(this.textAccountNo);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textFax);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelFax);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelVendorName);
            this.Controls.Add(this.labelVendorAddress);
            this.Name = "NewVendorForm";
            this.Text = "NewVendorForm";
            this.Load += new System.EventHandler(this.NewVendorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVendorAddress;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button labelFinish;
        private System.Windows.Forms.Button labelCancel;
        private System.Windows.Forms.TextBox textAccountNo;
        private System.Windows.Forms.Label labelAccountNo;
    }
}