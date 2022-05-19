namespace CamcoForm
{
    partial class ShippingForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textInvoiceSO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textInvoicePO = new System.Windows.Forms.TextBox();
            this.ShipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoicePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipID,
            this.InvoiceSO,
            this.InvoicePO,
            this.Quantity,
            this.ProductName,
            this.QuantityPicked,
            this.QuantityRemaining,
            this.Finished});
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // textInvoiceSO
            // 
            this.textInvoiceSO.Location = new System.Drawing.Point(672, 376);
            this.textInvoiceSO.Name = "textInvoiceSO";
            this.textInvoiceSO.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceSO.TabIndex = 1;
            this.textInvoiceSO.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textInvoicePO
            // 
            this.textInvoicePO.Location = new System.Drawing.Point(672, 350);
            this.textInvoicePO.Name = "textInvoicePO";
            this.textInvoicePO.Size = new System.Drawing.Size(100, 20);
            this.textInvoicePO.TabIndex = 3;
            this.textInvoicePO.Visible = false;
            // 
            // ShipID
            // 
            this.ShipID.HeaderText = "ShipID";
            this.ShipID.Name = "ShipID";
            this.ShipID.ReadOnly = true;
            // 
            // InvoiceSO
            // 
            this.InvoiceSO.HeaderText = "InvoiceSO";
            this.InvoiceSO.Name = "InvoiceSO";
            this.InvoiceSO.ReadOnly = true;
            // 
            // InvoicePO
            // 
            this.InvoicePO.HeaderText = "InvoicePO";
            this.InvoicePO.Name = "InvoicePO";
            this.InvoicePO.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // QuantityPicked
            // 
            this.QuantityPicked.HeaderText = "QuantityPicked";
            this.QuantityPicked.Name = "QuantityPicked";
            this.QuantityPicked.ReadOnly = true;
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.HeaderText = "QuantityRemaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // Finished
            // 
            this.Finished.HeaderText = "Finished";
            this.Finished.Name = "Finished";
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textInvoicePO);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textInvoiceSO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShippingForm";
            this.Text = "ShippingForm";
            this.Load += new System.EventHandler(this.ShippingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textInvoiceSO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoicePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished;
        private System.Windows.Forms.TextBox textInvoicePO;
    }
}