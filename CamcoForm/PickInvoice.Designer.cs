﻿namespace CamcoForm
{
    partial class PickInvoice
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
            this.textSONumber = new System.Windows.Forms.TextBox();
            this.labelSO = new System.Windows.Forms.Label();
            this.labelPONumber = new System.Windows.Forms.Label();
            this.textPONumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvoiceSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoicePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textInvoiceTotal = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSONumber
            // 
            this.textSONumber.Location = new System.Drawing.Point(41, 44);
            this.textSONumber.Name = "textSONumber";
            this.textSONumber.Size = new System.Drawing.Size(100, 20);
            this.textSONumber.TabIndex = 0;
            // 
            // labelSO
            // 
            this.labelSO.AutoSize = true;
            this.labelSO.Location = new System.Drawing.Point(38, 28);
            this.labelSO.Name = "labelSO";
            this.labelSO.Size = new System.Drawing.Size(62, 13);
            this.labelSO.TabIndex = 1;
            this.labelSO.Text = "SO Number";
            // 
            // labelPONumber
            // 
            this.labelPONumber.AutoSize = true;
            this.labelPONumber.Location = new System.Drawing.Point(173, 28);
            this.labelPONumber.Name = "labelPONumber";
            this.labelPONumber.Size = new System.Drawing.Size(62, 13);
            this.labelPONumber.TabIndex = 2;
            this.labelPONumber.Text = "PO Number";
            // 
            // textPONumber
            // 
            this.textPONumber.Location = new System.Drawing.Point(176, 44);
            this.textPONumber.Name = "textPONumber";
            this.textPONumber.Size = new System.Drawing.Size(100, 20);
            this.textPONumber.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceSO,
            this.InvoicePO,
            this.Quantity,
            this.ProductName,
            this.QuantityPicked,
            this.QuantityRemaining,
            this.Commit,
            this.ProductDescription,
            this.PickID,
            this.ProductPrice,
            this.Kit});
            this.dataGridView1.Location = new System.Drawing.Point(41, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(711, 264);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // InvoiceSO
            // 
            this.InvoiceSO.HeaderText = "InvoiceSO";
            this.InvoiceSO.Name = "InvoiceSO";
            this.InvoiceSO.ReadOnly = true;
            this.InvoiceSO.Visible = false;
            // 
            // InvoicePO
            // 
            this.InvoicePO.HeaderText = "InvoicePO";
            this.InvoicePO.Name = "InvoicePO";
            this.InvoicePO.Visible = false;
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
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.HeaderText = "QuantityRemaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // Commit
            // 
            this.Commit.HeaderText = "Commit";
            this.Commit.Name = "Commit";
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "ProductDescription";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Visible = false;
            // 
            // PickID
            // 
            this.PickID.HeaderText = "PickID";
            this.PickID.Name = "PickID";
            this.PickID.Visible = false;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // Kit
            // 
            this.Kit.HeaderText = "Kit";
            this.Kit.Name = "Kit";
            this.Kit.Visible = false;
            // 
            // textInvoiceTotal
            // 
            this.textInvoiceTotal.Location = new System.Drawing.Point(603, 76);
            this.textInvoiceTotal.Name = "textInvoiceTotal";
            this.textInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.textInvoiceTotal.TabIndex = 5;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(628, 415);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(677, 98);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(75, 23);
            this.btnVoid.TabIndex = 8;
            this.btnVoid.Text = "Void Pick";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // PickInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.textInvoiceTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textPONumber);
            this.Controls.Add(this.labelPONumber);
            this.Controls.Add(this.labelSO);
            this.Controls.Add(this.textSONumber);
            this.Name = "PickInvoice";
            this.Text = "PickInvoice";
            this.Load += new System.EventHandler(this.PickInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSONumber;
        private System.Windows.Forms.Label labelSO;
        private System.Windows.Forms.Label labelPONumber;
        private System.Windows.Forms.TextBox textPONumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textInvoiceTotal;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoicePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Commit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kit;
    }
}