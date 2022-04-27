﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamcoForm
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            bool editMode = false;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet9.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter1.Fill(this.camcoDataSet9.Invoices);
            // TODO: This line of code loads data into the 'camcoInvoices.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.camcoInvoices.Invoices);

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newForm = new NewInvoiceForm();
            newForm.Show();
        }

        private void btnRefreshInvoice_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void btnEnterSO_Click(object sender, EventArgs e)
        {
            using (var DB = new CamcoEntities())
            {
                Invoice result = DB.Invoices.SingleOrDefault(x => x.InvoiceSO == textEnterSO.Text);

                if (result != null)
                {
                    NewInvoiceForm frm = new NewInvoiceForm();
                    frm.setAddress(result.CustomerID);
                    frm.setDetails(result.InvoiceSO);
                    /* need to add datagridview rows */
                    using (var DB2 = new CamcoEntities())
                    {
                        /* access InvoiceLineItems DB to add rows to DGV in NewInvoiceForm 
                        InvoiceLineItem result2 = DB.InvoiceLineItems.Any(c => c.InvoiceSO == result2SO); */


                    }
                   var newForm = new NewInvoiceForm();
                   frm.Show();
                }

                else
                {
                    string message = "The SO you have entered is invalid or does not exist.";
                    MessageBox.Show(message);
                }
            }
        }
    }
}
