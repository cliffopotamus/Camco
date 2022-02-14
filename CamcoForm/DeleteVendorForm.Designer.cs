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
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.labelDeleteAccountNo = new System.Windows.Forms.Label();
            this.textDeleteVendor = new System.Windows.Forms.TextBox();
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
            this.labelDeleteAccountNo.Size = new System.Drawing.Size(115, 13);
            this.labelDeleteAccountNo.TabIndex = 5;
            this.labelDeleteAccountNo.Text = "Enter Account Number";
            // 
            // textDeleteVendor
            // 
            this.textDeleteVendor.Location = new System.Drawing.Point(309, 205);
            this.textDeleteVendor.Name = "textDeleteVendor";
            this.textDeleteVendor.Size = new System.Drawing.Size(186, 20);
            this.textDeleteVendor.TabIndex = 4;
            // 
            // DeleteVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.labelDeleteAccountNo);
            this.Controls.Add(this.textDeleteVendor);
            this.Name = "DeleteVendorForm";
            this.Text = "DeleteVendorForm";
            this.Load += new System.EventHandler(this.DeleteVendorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Label labelDeleteAccountNo;
        private System.Windows.Forms.TextBox textDeleteVendor;
    }
}