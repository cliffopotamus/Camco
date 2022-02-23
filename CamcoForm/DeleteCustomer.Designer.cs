namespace CamcoForm
{
    partial class DeleteCustomer
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
            this.textDeleteCustomer = new System.Windows.Forms.TextBox();
            this.labelDeleteAccountNo = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDeleteCustomer
            // 
            this.textDeleteCustomer.Location = new System.Drawing.Point(309, 205);
            this.textDeleteCustomer.Name = "textDeleteCustomer";
            this.textDeleteCustomer.Size = new System.Drawing.Size(186, 20);
            this.textDeleteCustomer.TabIndex = 0;
            this.textDeleteCustomer.TextChanged += new System.EventHandler(this.textDeleteCustomer_TextChanged);
            // 
            // labelDeleteAccountNo
            // 
            this.labelDeleteAccountNo.AutoSize = true;
            this.labelDeleteAccountNo.Location = new System.Drawing.Point(313, 183);
            this.labelDeleteAccountNo.Name = "labelDeleteAccountNo";
            this.labelDeleteAccountNo.Size = new System.Drawing.Size(115, 13);
            this.labelDeleteAccountNo.TabIndex = 1;
            this.labelDeleteAccountNo.Text = "Enter Account Number";
            this.labelDeleteAccountNo.Click += new System.EventHandler(this.labelDeleteAccountNo_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(606, 407);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(699, 407);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteCancel.TabIndex = 3;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.labelDeleteAccountNo);
            this.Controls.Add(this.textDeleteCustomer);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDeleteCustomer;
        private System.Windows.Forms.Label labelDeleteAccountNo;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteCancel;
    }
}