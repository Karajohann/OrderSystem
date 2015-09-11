﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OrderSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CustomersFunctions.CheckandCreate();

            RefreshGrid();            
        }

        public void RefreshGrid()
        {
            dataGridView1.DataSource = CustomersFunctions.Read();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAddForm CAF = new CustomerAddForm();

            DialogResult result = CAF.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                CAF.Dispose();
                RefreshGrid();
            }
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                CAF.Dispose();
                RefreshGrid();
            }
            if (result != System.Windows.Forms.DialogResult.OK && result != System.Windows.Forms.DialogResult.Cancel)
            {
                CAF.Show();
            }


        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //Εδώ θέτω στην νέα Update Form ποιά θα είναι τα στοιχεία στα Κελιά των αποθηκευμένων.
            UpdateForm form = new UpdateForm();
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            string FirstName = row.Cells[1].Value.ToString();
            string LastName = row.Cells[2].Value.ToString();
            string Telephone = row.Cells[3].Value.ToString();
            string Address = row.Cells[4].Value.ToString();

            //Method η αποία τοποθετεί τα παραπάνω στοιχεία στα κουτιά των αποθηκευμένων.(η μέθοδος έχει δημιουργηθεί στην UpdateForm)
            form.SetExistCells(ID, FirstName, LastName, Telephone, Address);

            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                form.Dispose();
                RefreshGrid();
            }
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                form.Dispose();
                RefreshGrid();
            }
            if (result != System.Windows.Forms.DialogResult.OK && result != System.Windows.Forms.DialogResult.Cancel)
            {
                form.Show();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            CustomersFunctions CF = new CustomersFunctions();
            CF.Delete(ID);
            RefreshGrid();
        }
    }
}
