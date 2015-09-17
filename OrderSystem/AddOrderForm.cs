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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
        }

        public void SetIDforAddOrderForm(string ID)
        {
            textBox1.Text = ID;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox5.Text));
            OrdersFunctions.Create(order.ToString());
            this.FindForm().Dispose();
        }
    }
}
