using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class CustomerAddForm : Form
    {
        public CustomerAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Customer Cust = new Customer();
                Cust.ID = textBox1.Text;
                Cust.FirstName = textBox2.Text;
                Cust.LastName = textBox3.Text;
                Cust.Telephone = textBox4.Text;
                Cust.Address = textBox5.Text;
                CustomersFunctions CF = new CustomersFunctions();
                CF.Add(Cust);
            }
            catch(StackOverflowException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }
    }
}
