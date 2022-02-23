﻿namespace CamcoForm
{
    partial class NewInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInventoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPurchases = new System.Windows.Forms.Button();
            this.BtnInvoices = new System.Windows.Forms.Button();
            this.BtnVendors = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBillOfMaterials = new System.Windows.Forms.Button();
            this.btnWorkOrder = new System.Windows.Forms.Button();
            this.comboInventory = new System.Windows.Forms.ComboBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.camcoInventory = new CamcoForm.CamcoInventory();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new CamcoForm.CamcoInventoryTableAdapters.InventoryTableAdapter();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.realInventory = new CamcoForm.RealInventory();
            this.inventoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter1 = new CamcoForm.RealInventoryTableAdapters.InventoryTableAdapter();
            this.productNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnInventory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnPurchases);
            this.panel1.Controls.Add(this.BtnInvoices);
            this.panel1.Controls.Add(this.BtnVendors);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 538);
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
            this.BtnInventory.TabIndex = 3;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "testButton";
            this.button1.UseVisualStyleBackColor = true;
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
            // btnBillOfMaterials
            // 
            this.btnBillOfMaterials.Location = new System.Drawing.Point(576, 47);
            this.btnBillOfMaterials.Name = "btnBillOfMaterials";
            this.btnBillOfMaterials.Size = new System.Drawing.Size(125, 69);
            this.btnBillOfMaterials.TabIndex = 4;
            this.btnBillOfMaterials.Text = "Bill of Materials";
            this.btnBillOfMaterials.UseVisualStyleBackColor = true;
            this.btnBillOfMaterials.Click += new System.EventHandler(this.btnBillOfMaterials_Click);
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.Location = new System.Drawing.Point(738, 47);
            this.btnWorkOrder.Name = "btnWorkOrder";
            this.btnWorkOrder.Size = new System.Drawing.Size(140, 69);
            this.btnWorkOrder.TabIndex = 5;
            this.btnWorkOrder.Text = "Work Order";
            this.btnWorkOrder.UseVisualStyleBackColor = true;
            this.btnWorkOrder.Click += new System.EventHandler(this.btnWorkOrder_Click);
            // 
            // comboInventory
            // 
            this.comboInventory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboInventory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboInventory.FormattingEnabled = true;
            this.comboInventory.Location = new System.Drawing.Point(222, 259);
            this.comboInventory.Name = "comboInventory";
            this.comboInventory.Size = new System.Drawing.Size(204, 21);
            this.comboInventory.TabIndex = 7;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(222, 46);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(129, 70);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Add Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 303);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(522, 66);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // camcoInventory
            // 
            this.camcoInventory.DataSetName = "CamcoInventory";
            this.camcoInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.camcoInventory;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(402, 46);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(129, 70);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.camcoInventory;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(222, 131);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(129, 70);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(222, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 109);
            this.dataGridView1.TabIndex = 12;
            // 
            // realInventory
            // 
            this.realInventory.DataSetName = "RealInventory";
            this.realInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource2
            // 
            this.inventoryBindingSource2.DataMember = "Inventory";
            this.inventoryBindingSource2.DataSource = this.realInventory;
            // 
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // productNoDataGridViewTextBoxColumn
            // 
            this.productNoDataGridViewTextBoxColumn.DataPropertyName = "ProductNo";
            this.productNoDataGridViewTextBoxColumn.HeaderText = "ProductNo";
            this.productNoDataGridViewTextBoxColumn.Name = "productNoDataGridViewTextBoxColumn";
            this.productNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // NewInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.comboInventory);
            this.Controls.Add(this.btnWorkOrder);
            this.Controls.Add(this.btnBillOfMaterials);
            this.Controls.Add(this.panel1);
            this.Name = "NewInventoryForm";
            this.Text = "NewInventoryForm";
            this.Load += new System.EventHandler(this.NewInventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPurchases;
        private System.Windows.Forms.Button BtnInvoices;
        private System.Windows.Forms.Button BtnVendors;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBillOfMaterials;
        private System.Windows.Forms.Button btnWorkOrder;
        private System.Windows.Forms.ComboBox comboInventory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CamcoInventory camcoInventory;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private CamcoInventoryTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RealInventory realInventory;
        private System.Windows.Forms.BindingSource inventoryBindingSource2;
        private RealInventoryTableAdapters.InventoryTableAdapter inventoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
    }
}