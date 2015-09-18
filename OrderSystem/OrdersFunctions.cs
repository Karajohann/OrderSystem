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

        public static void Create(string Order, string Path)
        {
            try
            {
                File.AppendAllText(Path, Order + Environment.NewLine);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// Διαβάζει όλες τις παραγγελίες από όλους τους πελάτες
        /// </summary>
        /// <returns></returns>
        public static List<Order> Read()
        {
            List<Order> Orders = new List<Order>();
            Order neworder;
            string[] lines = File.ReadAllLines(FileOrdersPath);
            foreach (string line in lines)
            {
                var columns = line.Split(',');
                neworder = new Order(Convert.ToInt32(columns[0]), columns[1], (columns[2]), Convert.ToInt32(columns[3]), Convert.ToDouble(columns[4]));
                Orders.Add(neworder);
            }
            return Orders;
        }
        /// <summary>
        /// Διαβάζει μόνο τις παραγγελίες του πελάτη της παραμέτρου
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Order> Read(int ID)
        {
            List<Order> Ordering = new List<Order>();
            Order neworder;
            string[] lines = File.ReadAllLines(FileOrdersPath);
            foreach (string line in lines)
            {
                var word = line.Split(',', '\n');
                int IdComparison = Convert.ToInt32(word[0]);
                if (IdComparison == ID)
                {
                    neworder = new Order(Int32.Parse(word[0]), word[1], word[2], Convert.ToInt32(word[3]), Convert.ToDouble(word[4]));
                    Ordering.Add(neworder);
                }
            }
            return Ordering;
        }


        public static void Update(int ID, string ordercode, string description, int quantity, double price)
        {
            List<Order> orders = Read();
            Order order = new Order(ID, ordercode, description, quantity, price);
            try
            {
                foreach (Order i in orders)
                {                    
                    Create(i.ToString(), FileOrderHelp);
                }
                Create(order.ToString(), FileOrderHelp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            File.Copy(FileOrderHelp, FileOrdersPath, true);
            File.Delete(FileOrderHelp);
        }
        /// <summary>
        /// Διαγράφει μία παραγγελία από πελάτη
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ordercode"></param>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public static void Delete(int ID, string ordercode, string description, int quantity, double price)
        {
            List<Order> orders = Read();
            Order order = new Order(ID, ordercode, description, quantity, price);
            try
            {
                foreach (Order i in orders)
                {
                    if (order.IDCustomer != i.IDCustomer && order.Ordercode != i.Ordercode)
                    {
                        Create(i.ToString(), FileOrderHelp);
                    }
                    if (order.IDCustomer == i.IDCustomer && order.Ordercode != i.Ordercode)
                    {
                        Create(i.ToString(), FileOrderHelp);
                    }
                    if (order.IDCustomer != i.IDCustomer && order.Ordercode == i.Ordercode)
                    {
                        Create(i.ToString(), FileOrderHelp);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            File.Copy(FileOrderHelp, FileOrdersPath, true);
            File.Delete(FileOrderHelp);
        }
        /// <summary>
        /// Διαγράφει όλες τις παραγγελίες του πελάτη που έχει τεθεί το IDCustomer
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ordercode"></param>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public static void Delete(int IDCustomer)
        {
            List<Order> orders = Read();
            try
            {
                foreach (Order i in orders)
                {
                    if (IDCustomer != i.IDCustomer)
                    {
                        Create(i.ToString(), FileOrderHelp);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            File.Copy(FileOrderHelp, FileOrdersPath, true);
            File.Delete(FileOrderHelp);
        }
    }
}
