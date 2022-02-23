namespace CamcoForm
{
    partial class EditVendorForm
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
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textFax = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelVendorAddress = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textVendorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(81, 202);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(123, 20);
            this.textAddress.TabIndex = 28;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(394, 202);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(123, 20);
            this.textCity.TabIndex = 27;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(576, 202);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(46, 20);
            this.textState.TabIndex = 26;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(260, 202);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(62, 20);
            this.textZip.TabIndex = 25;
            // 
            // textFax
            // 
            this.textFax.Location = new System.Drawing.Point(436, 117);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(123, 20);
            this.textFax.TabIndex = 24;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(260, 117);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(123, 20);
            this.textPhone.TabIndex = 23;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(81, 117);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(123, 20);
            this.textName.TabIndex = 22;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(433, 101);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(64, 13);
            this.labelFax.TabIndex = 21;
            this.labelFax.Text = "Fax Number";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(257, 101);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(573, 186);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 19;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(391, 186);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 18;
            this.labelCity.Text = "City";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(257, 186);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(50, 13);
            this.labelZipCode.TabIndex = 17;
            this.labelZipCode.Text = "Zip Code";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(78, 101);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(72, 13);
            this.labelVendorName.TabIndex = 16;
            this.labelVendorName.Text = "Vendor Name";
            // 
            // labelVendorAddress
            // 
            this.labelVendorAddress.AutoSize = true;
            this.labelVendorAddress.Location = new System.Drawing.Point(78, 186);
            this.labelVendorAddress.Name = "labelVendorAddress";
            this.labelVendorAddress.Size = new System.Drawing.Size(45, 13);
            this.labelVendorAddress.TabIndex = 15;
            this.labelVendorAddress.Text = "Address";
            // 
            // comboVendor
            // 
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(83, 294);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(121, 21);
            this.comboVendor.TabIndex = 29;
            this.comboVendor.Text = "Select Vendor";
            this.comboVendor.SelectedIndexChanged += new System.EventHandler(this.comboVendor_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(640, 389);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 25);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(517, 389);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(92, 25);
            this.buttonFinish.TabIndex = 48;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textVendorID
            // 
            this.textVendorID.Location = new System.Drawing.Point(81, 392);
            this.textVendorID.Name = "textVendorID";
            this.textVendorID.Size = new System.Drawing.Size(85, 20);
            this.textVendorID.TabIndex = 54;
            // 
            // EditVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textVendorID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.comboVendor);
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
            this.Name = "EditVendorForm";
            this.Text = "EditVendorForm";
            this.Load += new System.EventHandler(this.EditVendorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelVendorAddress;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textVendorID;
    }
}