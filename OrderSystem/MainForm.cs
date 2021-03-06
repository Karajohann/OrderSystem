﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            OrdersFunctions.CheckandCreate();

            RefreshGridCustomers();
        }

        public void RefreshGridCustomers()
        {
            dataGridView1.DataSource = CustomersFunctions.ReadGrid();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAddForm CAF = new CustomerAddForm();
            CAF.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            //Εδώ θέτω στην νέα Update Form ποιά θα είναι τα στοιχεία στα Κελιά των αποθηκευμένων.
            UpdateForm UpdateForm = new UpdateForm();
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            string FirstName = row.Cells[1].Value.ToString();
            string LastName = row.Cells[2].Value.ToString();
            string Telephone = row.Cells[3].Value.ToString();
            string Address = row.Cells[4].Value.ToString();

            //Method η αποία τοποθετεί τα παραπάνω στοιχεία στα κουτιά των αποθηκευμένων.(η μέθοδος έχει δημιουργηθεί στην UpdateForm)
            UpdateForm.SetExistCells(ID, FirstName, LastName, Telephone, Address);
            UpdateForm.Show();


        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            string FirstName = row.Cells[1].Value.ToString();
            string LastName = row.Cells[2].Value.ToString();
            if (MessageBox.Show("ΠΡΟΣΟΧΗ! Εάν ο πελάτης έχει αποθηκευμένες παραγγελίες θα σβηστούν και αυτές!\nΕίστε σίγουροι ότι θέλετε να σβήσετε τον πελάτη;", "Διαγραφή πελάτη " + FirstName + " " + LastName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CustomersFunctions CF = new CustomersFunctions();
                CF.Delete(ID);
                OrdersFunctions.Delete(ID);
                RefreshGridCustomers();                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGridCustomers();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrdersForm OF = new OrdersForm();
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            string FirstName = row.Cells[1].Value.ToString();
            string LastName = row.Cells[2].Value.ToString();
            string Telephone = row.Cells[3].Value.ToString();
            string Address = row.Cells[4].Value.ToString();

            OF.SetLabelInfos(ID, FirstName, LastName, Telephone, Address);
            OF.Show();
        }
    }
}
