namespace CamcoForm
{
    partial class DeleteProductForm
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
            this.textProductID = new System.Windows.Forms.TextBox();
            this.comboInventory = new System.Windows.Forms.ComboBox();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.labelDeleteProductID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(96, 329);
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(83, 20);
            this.textProductID.TabIndex = 14;
            // 
            // comboInventory
            // 
            this.comboInventory.FormattingEnabled = true;
            this.comboInventory.Location = new System.Drawing.Point(306, 186);
            this.comboInventory.Name = "comboInventory";
            this.comboInventory.Size = new System.Drawing.Size(172, 21);
            this.comboInventory.TabIndex = 13;
            this.comboInventory.SelectedIndexChanged += new System.EventHandler(this.comboDeleteProduct_SelectedIndexChanged);
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(689, 394);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteCancel.TabIndex = 12;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(596, 394);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(64, 21);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // labelDeleteProductID
            // 
            this.labelDeleteProductID.AutoSize = true;
            this.labelDeleteProductID.Location = new System.Drawing.Point(303, 170);
            this.labelDeleteProductID.Name = "labelDeleteProductID";
            this.labelDeleteProductID.Size = new System.Drawing.Size(77, 13);
            this.labelDeleteProductID.TabIndex = 10;
            this.labelDeleteProductID.Text = "Select Product";
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.comboInventory);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.labelDeleteProductID);
            this.Name = "DeleteProductForm";
            this.Text = "DeleteProductForm";
            this.Load += new System.EventHandler(this.DeleteProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.ComboBox comboInventory;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label labelDeleteProductID;
    }
}