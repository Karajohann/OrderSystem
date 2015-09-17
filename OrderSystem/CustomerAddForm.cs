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
            Customer Cust = new Customer();
            CustomersFunctions CF = new CustomersFunctions();
            if (textBox1.Text == string.Empty || textBox1.Text == null)
            {
                MessageBox.Show("Το ID πεδίο δεν μπορεί να είναι κενό");
                return;
            }

            if (textBox2.Text == string.Empty || textBox1.Text == null)
            {
                MessageBox.Show("Το πεδίο Όνομα δεν μπορεί να είναι κενό");
                return;
            }

            if (textBox3.Text == string.Empty || textBox1.Text == null)
            {
                MessageBox.Show("Το πεδίο Επώνυμο δεν μπορεί να είναι κενό");
                return;
            }
            CF.Add(Cust.StrCustomer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));

            this.FindForm().Dispose();
            
        }
    }
}
