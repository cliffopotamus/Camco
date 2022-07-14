namespace CamcoForm
{
    partial class ReceiveOrderForm
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
            this.textSO = new System.Windows.Forms.TextBox();
            this.textPO = new System.Windows.Forms.TextBox();
            this.labelSO = new System.Windows.Forms.Label();
            this.labelPO = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurchaseSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReceiveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSO
            // 
            this.textSO.Location = new System.Drawing.Point(57, 52);
            this.textSO.Name = "textSO";
            this.textSO.Size = new System.Drawing.Size(100, 20);
            this.textSO.TabIndex = 0;
            // 
            // textPO
            // 
            this.textPO.Location = new System.Drawing.Point(211, 52);
            this.textPO.Name = "textPO";
            this.textPO.Size = new System.Drawing.Size(100, 20);
            this.textPO.TabIndex = 1;
            // 
            // labelSO
            // 
            this.labelSO.AutoSize = true;
            this.labelSO.Location = new System.Drawing.Point(54, 36);
            this.labelSO.Name = "labelSO";
            this.labelSO.Size = new System.Drawing.Size(70, 13);
            this.labelSO.TabIndex = 2;
            this.labelSO.Text = "Purchase SO";
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.Location = new System.Drawing.Point(208, 36);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(70, 13);
            this.labelPO.TabIndex = 3;
            this.labelPO.Text = "Purchase PO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseSO,
            this.PurchasePO,
            this.Quantity,
            this.ProductName,
            this.ReceivedQuantity,
            this.RemainingQuantity,
            this.Commit,
            this.ReceiveID,
            this.ProductDescription});
            this.dataGridView1.Location = new System.Drawing.Point(21, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(705, 269);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // PurchaseSO
            // 
            this.PurchaseSO.HeaderText = "PurchaseSO";
            this.PurchaseSO.Name = "PurchaseSO";
            this.PurchaseSO.ReadOnly = true;
            // 
            // PurchasePO
            // 
            this.PurchasePO.HeaderText = "PurchasePO";
            this.PurchasePO.Name = "PurchasePO";
            this.PurchasePO.ReadOnly = true;
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
            // ReceivedQuantity
            // 
            this.ReceivedQuantity.HeaderText = "ReceivedQuantity";
            this.ReceivedQuantity.Name = "ReceivedQuantity";
            // 
            // RemainingQuantity
            // 
            this.RemainingQuantity.HeaderText = "RemainingQuantity";
            this.RemainingQuantity.Name = "RemainingQuantity";
            this.RemainingQuantity.ReadOnly = true;
            // 
            // Commit
            // 
            this.Commit.HeaderText = "Commit";
            this.Commit.Name = "Commit";
            // 
            // ReceiveID
            // 
            this.ReceiveID.HeaderText = "ReceiveID";
            this.ReceiveID.Name = "ReceiveID";
            this.ReceiveID.Visible = false;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "ProductDescription";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Visible = false;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(608, 415);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReceiveOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPO);
            this.Controls.Add(this.labelSO);
            this.Controls.Add(this.textPO);
            this.Controls.Add(this.textSO);
            this.Name = "ReceiveOrderForm";
            this.Text = "ReceiveOrderForm";
            this.Load += new System.EventHandler(this.ReceiveOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSO;
        private System.Windows.Forms.TextBox textPO;
        private System.Windows.Forms.Label labelSO;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Commit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
    }
}