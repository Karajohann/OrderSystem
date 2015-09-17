﻿using System;
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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

        }

        public void SetLabelInfos(int ID, string FirstName, string LastName, string Telephone = "-", string Address = "-")
        {            
            string Infos = ID.ToString() + "\n" + FirstName + "\n" + LastName + "\n" + Telephone + "\n" + Address;
            CustomerInfo.Text = Infos;
        }


        private string SetId
        {
            get
            {
                char[] delimiterChars = { ',', '\n' };

                string text = CustomerInfo.Text;

                string[] words = text.Split(delimiterChars);
                return words[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm AOF = new AddOrderForm();
            AOF.SetIDforAddOrderForm(SetId);
            AOF.Show();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            int ID = int.Parse(SetId);
            OrdersGridView.DataSource = OrdersFunctions.Read(ID);
        }

    }
}
