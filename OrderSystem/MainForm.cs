using System;
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

            Refresh2Grid();
        }

        public void Refresh2Grid()
        {
            dataGridView1.DataSource = CustomersFunctions.Read();            
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
            CustomersFunctions CF = new CustomersFunctions();
            CF.Delete(ID);
            Refresh2Grid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Refresh2Grid();
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
