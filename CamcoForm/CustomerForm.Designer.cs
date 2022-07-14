namespace CamcoForm
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.BtnPurchases = new System.Windows.Forms.Button();
            this.BtnInvoices = new System.Windows.Forms.Button();
            this.BtnVendors = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNewCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerShipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBillAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBillCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerShipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBillZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerShipZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBillStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerShipStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camcoCustomers5 = new CamcoForm.CamcoCustomers5();
            this.customersTableAdapter = new CamcoForm.CamcoCustomers5TableAdapters.CustomersTableAdapter();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoCustomers5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.BtnPurchases);
            this.panel1.Controls.Add(this.BtnInvoices);
            this.panel1.Controls.Add(this.BtnVendors);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.Location = new System.Drawing.Point(0, 354);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(186, 42);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
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
            this.BtnPurchases.Click += new System.EventHandler(this.BtnPurchases_Click);
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
            this.BtnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
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
            this.BtnVendors.Click += new System.EventHandler(this.BtnVendors_Click);
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
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
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
            // BtnNewCustomer
            // 
            this.BtnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnNewCustomer.Location = new System.Drawing.Point(234, 50);
            this.BtnNewCustomer.Name = "BtnNewCustomer";
            this.BtnNewCustomer.Size = new System.Drawing.Size(156, 50);
            this.BtnNewCustomer.TabIndex = 2;
            this.BtnNewCustomer.Text = "Add New Customer";
            this.BtnNewCustomer.UseVisualStyleBackColor = false;
            this.BtnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
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
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerShipAddressDataGridViewTextBoxColumn,
            this.customerBillAddressDataGridViewTextBoxColumn,
            this.customerBillCityDataGridViewTextBoxColumn,
            this.customerShipCityDataGridViewTextBoxColumn,
            this.customerBillZipCodeDataGridViewTextBoxColumn,
            this.customerShipZipCodeDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerFaxDataGridViewTextBoxColumn,
            this.customerBillStateDataGridViewTextBoxColumn,
            this.customerShipStateDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(747, 377);
            this.dataGridView1.TabIndex = 3;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerShipAddressDataGridViewTextBoxColumn
            // 
            this.customerShipAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerShipAddress";
            this.customerShipAddressDataGridViewTextBoxColumn.HeaderText = "CustomerShipAddress";
            this.customerShipAddressDataGridViewTextBoxColumn.Name = "customerShipAddressDataGridViewTextBoxColumn";
            this.customerShipAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBillAddressDataGridViewTextBoxColumn
            // 
            this.customerBillAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerBillAddress";
            this.customerBillAddressDataGridViewTextBoxColumn.HeaderText = "CustomerBillAddress";
            this.customerBillAddressDataGridViewTextBoxColumn.Name = "customerBillAddressDataGridViewTextBoxColumn";
            this.customerBillAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBillCityDataGridViewTextBoxColumn
            // 
            this.customerBillCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerBillCity";
            this.customerBillCityDataGridViewTextBoxColumn.HeaderText = "CustomerBillCity";
            this.customerBillCityDataGridViewTextBoxColumn.Name = "customerBillCityDataGridViewTextBoxColumn";
            this.customerBillCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerShipCityDataGridViewTextBoxColumn
            // 
            this.customerShipCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerShipCity";
            this.customerShipCityDataGridViewTextBoxColumn.HeaderText = "CustomerShipCity";
            this.customerShipCityDataGridViewTextBoxColumn.Name = "customerShipCityDataGridViewTextBoxColumn";
            this.customerShipCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBillZipCodeDataGridViewTextBoxColumn
            // 
            this.customerBillZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerBillZipCode";
            this.customerBillZipCodeDataGridViewTextBoxColumn.HeaderText = "CustomerBillZipCode";
            this.customerBillZipCodeDataGridViewTextBoxColumn.Name = "customerBillZipCodeDataGridViewTextBoxColumn";
            this.customerBillZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerShipZipCodeDataGridViewTextBoxColumn
            // 
            this.customerShipZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerShipZipCode";
            this.customerShipZipCodeDataGridViewTextBoxColumn.HeaderText = "CustomerShipZipCode";
            this.customerShipZipCodeDataGridViewTextBoxColumn.Name = "customerShipZipCodeDataGridViewTextBoxColumn";
            this.customerShipZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFaxDataGridViewTextBoxColumn
            // 
            this.customerFaxDataGridViewTextBoxColumn.DataPropertyName = "CustomerFax";
            this.customerFaxDataGridViewTextBoxColumn.HeaderText = "CustomerFax";
            this.customerFaxDataGridViewTextBoxColumn.Name = "customerFaxDataGridViewTextBoxColumn";
            this.customerFaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBillStateDataGridViewTextBoxColumn
            // 
            this.customerBillStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerBillState";
            this.customerBillStateDataGridViewTextBoxColumn.HeaderText = "CustomerBillState";
            this.customerBillStateDataGridViewTextBoxColumn.Name = "customerBillStateDataGridViewTextBoxColumn";
            this.customerBillStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerShipStateDataGridViewTextBoxColumn
            // 
            this.customerShipStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerShipState";
            this.customerShipStateDataGridViewTextBoxColumn.HeaderText = "CustomerShipState";
            this.customerShipStateDataGridViewTextBoxColumn.Name = "customerShipStateDataGridViewTextBoxColumn";
            this.customerShipStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.camcoCustomers5;
            // 
            // camcoCustomers5
            // 
            this.camcoCustomers5.DataSetName = "CamcoCustomers5";
            this.camcoCustomers5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEditCustomer.Location = new System.Drawing.Point(470, 50);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(156, 50);
            this.btnEditCustomer.TabIndex = 4;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(703, 50);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(156, 50);
            this.btnDeleteCustomer.TabIndex = 5;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnNewCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camcoCustomers5)).EndInit();
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
        private System.Windows.Forms.Button BtnNewCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CamcoCustomers5 camcoCustomers5;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CamcoCustomers5TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerShipAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBillAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBillCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerShipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBillZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerShipZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBillStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerShipStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnInventory;
    }
}