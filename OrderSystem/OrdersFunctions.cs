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

namespace OrderSystem
{
    class OrdersFunctions
    {
        private const string FileOrdersPath = @"Orders.txt";
        private const string FileOrderHelp = @"OrderHelpFile.txt";

        public static void CheckandCreate()
        {
            if (File.Exists(FileOrdersPath))
            {

            }
            else
            {
                Order o = new Order();
                File.AppendAllText(FileOrdersPath, o.ToString() + Environment.NewLine);
            }
        }

        public static void Create(string Order)
        {
            try
            {
                File.AppendAllText(FileOrdersPath, Order + Environment.NewLine);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public static List<Order> Read(int ID)
        {            
            List<Order> Ordering = new List<Order>();
            Order neworder;
            string[] lines = File.ReadAllLines(FileOrdersPath);
            foreach (string line in lines)
            {
                var word = line.Split(',','\n');
                int IdComparison = Convert.ToInt32(word[0]);
                if (IdComparison == ID)
                {
                    neworder = new Order(Int32.Parse(word[0]), word[1], word[2], Convert.ToInt32(word[3]), Convert.ToSingle(word[4]));
                    Ordering.Add(neworder);
                }
            }
            return Ordering;
        }

        //public static void Updating
        //{

        //}

        //public static void Delete
        //{

        //}
    }
}
