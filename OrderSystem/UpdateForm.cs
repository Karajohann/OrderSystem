using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace OrderSystem
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            
        }

        public void SetExistCells(int id, string FirstName, string LastName, string Telephone, string Address)
        {

            IDExist.Text = id.ToString();
            FirstNameExist.Text = FirstName;
            LastNameExist.Text = LastName;
            TelephoneExist.Text = Telephone;
            AddressExist.Text = Address;
            IDReplace.Text = id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersFunctions CF = new CustomersFunctions();
            CF.Update(Convert.ToInt32(IDReplace.Text), FirstNameReplace.Text,
                LastNameReplace.Text, TelephoneReplace.Text, AddressReplace.Text);

        }


        
    }
}
