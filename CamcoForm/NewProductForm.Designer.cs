namespace CamcoForm
{
    partial class NewProductForm
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
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.textUnitCost = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textProductDescription = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUnitCost = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(61, 66);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(146, 20);
            this.textProductName.TabIndex = 0;
            // 
            // textTotalCost
            // 
            this.textTotalCost.Location = new System.Drawing.Point(61, 357);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(146, 20);
            this.textTotalCost.TabIndex = 1;
            // 
            // textUnitCost
            // 
            this.textUnitCost.Location = new System.Drawing.Point(61, 284);
            this.textUnitCost.Name = "textUnitCost";
            this.textUnitCost.Size = new System.Drawing.Size(146, 20);
            this.textUnitCost.TabIndex = 2;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(61, 206);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(146, 20);
            this.textQuantity.TabIndex = 3;
            // 
            // textProductDescription
            // 
            this.textProductDescription.Location = new System.Drawing.Point(61, 135);
            this.textProductDescription.Name = "textProductDescription";
            this.textProductDescription.Size = new System.Drawing.Size(146, 20);
            this.textProductDescription.TabIndex = 4;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(58, 50);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(58, 190);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(58, 119);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 13);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Product Description";
            // 
            // labelUnitCost
            // 
            this.labelUnitCost.AutoSize = true;
            this.labelUnitCost.Location = new System.Drawing.Point(58, 268);
            this.labelUnitCost.Name = "labelUnitCost";
            this.labelUnitCost.Size = new System.Drawing.Size(50, 13);
            this.labelUnitCost.TabIndex = 8;
            this.labelUnitCost.Text = "Unit Cost";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(58, 341);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(55, 13);
            this.labelTotalCost.TabIndex = 9;
            this.labelTotalCost.Text = "Total Cost";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(533, 375);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(70, 25);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(651, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelUnitCost);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textProductDescription);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textUnitCost);
            this.Controls.Add(this.textTotalCost);
            this.Controls.Add(this.textProductName);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.TextBox textUnitCost;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textProductDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUnitCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
    }
}