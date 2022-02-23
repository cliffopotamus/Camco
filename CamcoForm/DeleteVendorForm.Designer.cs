namespace CamcoForm
{
    partial class DeleteVendorForm
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
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.labelDeleteAccountNo = new System.Windows.Forms.Label();
            this.comboDeleteVendor = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camcoVendors = new CamcoForm.CamcoVendors();
            this.vendorsTableAdapter = new CamcoForm.CamcoVendorsTableAdapters.VendorsTableAdapter();
            this.textVendorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(699, 407);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteCancel.TabIndex = 7;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Location = new System.Drawing.Point(606, 407);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteVendor.TabIndex = 6;
            this.btnDeleteVendor.Text = "Delete Customer";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // labelDeleteAccountNo
            // 
            this.labelDeleteAccountNo.AutoSize = true;
            this.labelDeleteAccountNo.Location = new System.Drawing.Point(313, 183);
            this.labelDeleteAccountNo.Name = "labelDeleteAccountNo";
            this.labelDeleteAccountNo.Size = new System.Drawing.Size(74, 13);
            this.labelDeleteAccountNo.TabIndex = 5;
            this.labelDeleteAccountNo.Text = "Select Vendor";
            // 
            // comboDeleteVendor
            // 
            this.comboDeleteVendor.FormattingEnabled = true;
            this.comboDeleteVendor.Location = new System.Drawing.Point(316, 199);
            this.comboDeleteVendor.Name = "comboDeleteVendor";
            this.comboDeleteVendor.Size = new System.Drawing.Size(172, 21);
            this.comboDeleteVendor.TabIndex = 8;
            this.comboDeleteVendor.SelectedIndexChanged += new System.EventHandler(this.comboDeleteVendor_SelectedIndexChanged);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.camcoVendors;
            // 
            // camcoVendors
            // 
            this.camcoVendors.DataSetName = "CamcoVendors";
            this.camcoVendors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // textVendorID
            // 
            this.textVendorID.Location = new System.Drawing.Point(106, 342);
            this.textVendorID.Name = "textVendorID";
            this.textVendorID.Size = new System.Drawing.Size(83, 20);
            this.textVendorID.TabIndex = 9;
            // 
            // DeleteVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textVendorID);
            this.Controls.Add(this.comboDeleteVendor);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.labelDeleteAccountNo);
            this.Name = "DeleteVendorForm";
            this.Text = "DeleteVendorForm";
            this.Load += new System.EventHandler(this.DeleteVendorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Label labelDeleteAccountNo;
        private System.Windows.Forms.ComboBox comboDeleteVendor;
        private CamcoVendors camcoVendors;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private CamcoVendorsTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.TextBox textVendorID;
    }
}