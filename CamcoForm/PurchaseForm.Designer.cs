﻿namespace CamcoForm
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnPurchases = new System.Windows.Forms.Button();
            this.BtnInvoices = new System.Windows.Forms.Button();
            this.BtnVendors = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNewPurchaseOrder = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.btnDeletePO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purchaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camcoDataSet12 = new CamcoForm.CamcoDataSet12();
            this.purchaseOrderTableAdapter = new CamcoForm.CamcoDataSet12TableAdapters.PurchaseOrderTableAdapter();
            this.btnOpenPurchaseOrder = new System.Windows.Forms.Button();
            this.btnReceivedOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnInventory);
            this.panel1.Controls.Add(this.BtnPurchases);
            this.panel1.Controls.Add(this.BtnInvoices);
            this.panel1.Controls.Add(this.BtnVendors);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 571);
            this.panel1.TabIndex = 1;
            // 
            // BtnInventory
            // 
            this.BtnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventory.FlatAppearance.BorderSize = 0;
            this.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventory.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnInventory.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventory.Image")));
            this.BtnInventory.Location = new System.Drawing.Point(0, 354);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(186, 42);
            this.BtnInventory.TabIndex = 4;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventory.UseVisualStyleBackColor = true;
            // 
            // BtnPurchases
            // 
            this.BtnPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPurchases.FlatAppearance.BorderSize = 0;
            this.BtnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchases.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnPurchases.Image = ((System.Drawing.Image)(resources.GetObject("BtnPurchases.Image")));
            this.BtnPurchases.Location = new System.Drawing.Point(0, 312);
            this.BtnPurchases.Name = "BtnPurchases";
            this.BtnPurchases.Size = new System.Drawing.Size(186, 42);
            this.BtnPurchases.TabIndex = 1;
            this.BtnPurchases.Text = "Purchases";
            this.BtnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPurchases.UseVisualStyleBackColor = true;
            // 
            // BtnInvoices
            // 
            this.BtnInvoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInvoices.FlatAppearance.BorderSize = 0;
            this.BtnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvoices.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnInvoices.Image = ((System.Drawing.Image)(resources.GetObject("BtnInvoices.Image")));
            this.BtnInvoices.Location = new System.Drawing.Point(0, 270);
            this.BtnInvoices.Name = "BtnInvoices";
            this.BtnInvoices.Size = new System.Drawing.Size(186, 42);
            this.BtnInvoices.TabIndex = 1;
            this.BtnInvoices.Text = "Invoices";
            this.BtnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInvoices.UseVisualStyleBackColor = true;
            // 
            // BtnVendors
            // 
            this.BtnVendors.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendors.FlatAppearance.BorderSize = 0;
            this.BtnVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendors.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnVendors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnVendors.Image = ((System.Drawing.Image)(resources.GetObject("BtnVendors.Image")));
            this.BtnVendors.Location = new System.Drawing.Point(0, 228);
            this.BtnVendors.Name = "BtnVendors";
            this.BtnVendors.Size = new System.Drawing.Size(186, 42);
            this.BtnVendors.TabIndex = 1;
            this.BtnVendors.Text = "Vendors";
            this.BtnVendors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVendors.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.Location = new System.Drawing.Point(0, 186);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(186, 42);
            this.BtnCustomers.TabIndex = 1;
            this.BtnCustomers.Text = "Customers";
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(186, 42);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNewPurchaseOrder
            // 
            this.buttonNewPurchaseOrder.Location = new System.Drawing.Point(219, 60);
            this.buttonNewPurchaseOrder.Name = "buttonNewPurchaseOrder";
            this.buttonNewPurchaseOrder.Size = new System.Drawing.Size(125, 42);
            this.buttonNewPurchaseOrder.TabIndex = 2;
            this.buttonNewPurchaseOrder.Text = "New Purchase Order";
            this.buttonNewPurchaseOrder.UseVisualStyleBackColor = true;
            this.buttonNewPurchaseOrder.Click += new System.EventHandler(this.buttonNewPurchaseOrder_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Location = new System.Drawing.Point(402, 60);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(125, 42);
            this.btnReceiveOrder.TabIndex = 3;
            this.btnReceiveOrder.Text = "Receive Order";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // btnDeletePO
            // 
            this.btnDeletePO.Location = new System.Drawing.Point(929, 60);
            this.btnDeletePO.Name = "btnDeletePO";
            this.btnDeletePO.Size = new System.Drawing.Size(125, 42);
            this.btnDeletePO.TabIndex = 4;
            this.btnDeletePO.Text = " Delete Purchase Order     ";
            this.btnDeletePO.UseVisualStyleBackColor = true;
            this.btnDeletePO.Click += new System.EventHandler(this.btnDeletePO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseIDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.purchaseTotalDataGridViewTextBoxColumn,
            this.purchaseSODataGridViewTextBoxColumn,
            this.purchasePODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(219, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(702, 352);
            this.dataGridView1.TabIndex = 5;
            // 
            // purchaseIDDataGridViewTextBoxColumn
            // 
            this.purchaseIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.HeaderText = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.Name = "purchaseIDDataGridViewTextBoxColumn";
            this.purchaseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseTotalDataGridViewTextBoxColumn
            // 
            this.purchaseTotalDataGridViewTextBoxColumn.DataPropertyName = "PurchaseTotal";
            this.purchaseTotalDataGridViewTextBoxColumn.HeaderText = "PurchaseTotal";
            this.purchaseTotalDataGridViewTextBoxColumn.Name = "purchaseTotalDataGridViewTextBoxColumn";
            this.purchaseTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseSODataGridViewTextBoxColumn
            // 
            this.purchaseSODataGridViewTextBoxColumn.DataPropertyName = "PurchaseSO";
            this.purchaseSODataGridViewTextBoxColumn.HeaderText = "PurchaseSO";
            this.purchaseSODataGridViewTextBoxColumn.Name = "purchaseSODataGridViewTextBoxColumn";
            this.purchaseSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePODataGridViewTextBoxColumn
            // 
            this.purchasePODataGridViewTextBoxColumn.DataPropertyName = "PurchasePO";
            this.purchasePODataGridViewTextBoxColumn.HeaderText = "PurchasePO";
            this.purchasePODataGridViewTextBoxColumn.Name = "purchasePODataGridViewTextBoxColumn";
            this.purchasePODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.camcoDataSet12;
            // 
            // camcoDataSet12
            // 
            this.camcoDataSet12.DataSetName = "CamcoDataSet12";
            this.camcoDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // btnOpenPurchaseOrder
            // 
            this.btnOpenPurchaseOrder.Location = new System.Drawing.Point(591, 60);
            this.btnOpenPurchaseOrder.Name = "btnOpenPurchaseOrder";
            this.btnOpenPurchaseOrder.Size = new System.Drawing.Size(125, 42);
            this.btnOpenPurchaseOrder.TabIndex = 6;
            this.btnOpenPurchaseOrder.Text = "Open Purchase Order";
            this.btnOpenPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnOpenPurchaseOrder.Click += new System.EventHandler(this.btnOpenPurchaseOrder_Click);
            // 
            // btnReceivedOrder
            // 
            this.btnReceivedOrder.Location = new System.Drawing.Point(762, 60);
            this.btnReceivedOrder.Name = "btnReceivedOrder";
            this.btnReceivedOrder.Size = new System.Drawing.Size(125, 42);
            this.btnReceivedOrder.TabIndex = 7;
            this.btnReceivedOrder.Text = "Received Order";
            this.btnReceivedOrder.UseVisualStyleBackColor = true;
            this.btnReceivedOrder.Click += new System.EventHandler(this.btnReceivedOrder_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1066, 571);
            this.Controls.Add(this.btnReceivedOrder);
            this.Controls.Add(this.btnOpenPurchaseOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeletePO);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.buttonNewPurchaseOrder);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPurchases;
        private System.Windows.Forms.Button BtnInvoices;
        private System.Windows.Forms.Button BtnVendors;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNewPurchaseOrder;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.Button btnDeletePO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CamcoDataSet12 camcoDataSet12;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private CamcoDataSet12TableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOpenPurchaseOrder;
        private System.Windows.Forms.Button btnReceivedOrder;
    }
}