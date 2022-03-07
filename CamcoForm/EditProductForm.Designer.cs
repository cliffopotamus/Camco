namespace CamcoForm
{
    partial class EditProductForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelUnitCost = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textProductDescription = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textUnitCost = new System.Windows.Forms.TextBox();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textProductID = new System.Windows.Forms.TextBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboInventory = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(662, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(544, 375);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(70, 25);
            this.btnFinish.TabIndex = 21;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(69, 341);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(55, 13);
            this.labelTotalCost.TabIndex = 20;
            this.labelTotalCost.Text = "Total Cost";
            this.labelTotalCost.Visible = false;
            // 
            // labelUnitCost
            // 
            this.labelUnitCost.AutoSize = true;
            this.labelUnitCost.Location = new System.Drawing.Point(69, 268);
            this.labelUnitCost.Name = "labelUnitCost";
            this.labelUnitCost.Size = new System.Drawing.Size(50, 13);
            this.labelUnitCost.TabIndex = 19;
            this.labelUnitCost.Text = "Unit Cost";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(69, 119);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 13);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Product Description";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(69, 50);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 17;
            this.labelProductName.Text = "Product Name";
            // 
            // textProductDescription
            // 
            this.textProductDescription.Location = new System.Drawing.Point(72, 135);
            this.textProductDescription.Name = "textProductDescription";
            this.textProductDescription.Size = new System.Drawing.Size(146, 20);
            this.textProductDescription.TabIndex = 16;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(72, 206);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(146, 20);
            this.textQuantity.TabIndex = 15;
            this.textQuantity.TextChanged += new System.EventHandler(this.textQuantity_TextChanged);
            // 
            // textUnitCost
            // 
            this.textUnitCost.Location = new System.Drawing.Point(72, 284);
            this.textUnitCost.Name = "textUnitCost";
            this.textUnitCost.Size = new System.Drawing.Size(146, 20);
            this.textUnitCost.TabIndex = 14;
            this.textUnitCost.TextChanged += new System.EventHandler(this.textUnitCost_TextChanged);
            // 
            // textTotalCost
            // 
            this.textTotalCost.Location = new System.Drawing.Point(72, 357);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(146, 20);
            this.textTotalCost.TabIndex = 13;
            this.textTotalCost.Visible = false;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(72, 66);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(146, 20);
            this.textProductName.TabIndex = 12;
            // 
            // textProductID
            // 
            this.textProductID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource1, "ProductNo", true));
            this.textProductID.Location = new System.Drawing.Point(72, 395);
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(92, 20);
            this.textProductID.TabIndex = 23;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            // 
            // comboInventory
            // 
            this.comboInventory.FormattingEnabled = true;
            this.comboInventory.Location = new System.Drawing.Point(426, 59);
            this.comboInventory.Name = "comboInventory";
            this.comboInventory.Size = new System.Drawing.Size(168, 21);
            this.comboInventory.TabIndex = 24;
            this.comboInventory.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(73, 190);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 25;
            this.labelQuantity.Text = "Quantity";
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataSource = typeof(CamcoForm.Inventory);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboInventory);
            this.Controls.Add(this.textProductID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelUnitCost);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textProductDescription);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textUnitCost);
            this.Controls.Add(this.textTotalCost);
            this.Controls.Add(this.textProductName);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelUnitCost;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textProductDescription;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textUnitCost;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.ComboBox comboInventory;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
    }
}