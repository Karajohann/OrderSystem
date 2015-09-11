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
    public class CustomersFunctions
    {
        /*
         * Edo anti na valeis olo to path mporeis na grapseis to ekseis:
         * @"filename.extension" ean grapseis me tin morfi auth xoris na valeis path 
         * mono diladi to onoma tou arxeiou me to extension to arxeio tha dimiourgithei 
         * mesa sto fakelo pou tha egkatastathei to programma tora otan esy tha trexeis
         * to programma apo to visual studio patontas F5 to arxeio tha apothikevete mesa
         * sto fakelo bin tou project gia na pas grigora sto fakelo mesa apo to visual studio
         * patas deksi click pano sto onoma tou project apo to solution explorer kai meta click
         * sto open Folder in File Explorer
         */
        private const string FileCustomersPath = @"Customers.txt";
        private const string FileHelp = @"HelpFile.txt";
        private const string FileOrdersPath = @"Orders.txt";

        public CustomersFunctions()
        {

        }


        public void Add(string Customer)//Create
        {
            try
            {
                if (File.Exists(FileCustomersPath))
                {
                    File.AppendAllText(FileCustomersPath, Customer + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(FileCustomersPath, Customer + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public void Add(string Customer, string Path)
        {
            try
            {
                if (File.Exists(Path))
                {
                    File.AppendAllText(Path, Customer + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(Path, Customer + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public void Delete(int ID)
        {
            //Πρώτα πρέπει να πάρω τα δεδομένα σε Customers obj
            List<Customer> customers = Read();

            /*Τώρα θα πρέπει να συγκρίνω το ID του Customer με το ID παράμετρο το οποίο θα το εξαιρεί και να γράψω στο νέο αρχείο
            το οποίο θα κάνει override το παλιό*/
            foreach (Customer i in customers)
            {
                if (i.ID != ID)
                {
                    Add(i.ToString(), FileHelp);
                }
            }
            //Πρέπει να αντιγράψω το FileHelp στο FileCustomersPath και να το κάνω overwrite
            File.Copy(FileHelp, FileCustomersPath, true);
            //Πρέπει να σβήσω το File Help
            File.Delete(FileHelp);

        }

        public void Update(int ID, string FirstName, string LastName, string Telephone, string Address)
        {
            //Πρώτα πρέπει να πέρνω τα δεδομένα σε Customers obj
            List<Customer> customers = Read();
            // Φτιάνχω έναν νέο Customer με τα νέα στοιχεία τα οποία τα έχω περάσει σαν παραμέτρους.
            Customer Cust = new Customer(ID, FirstName, LastName, Telephone, Address);
            /*Τώρα θα πρέπει να συγκρίνω το ID του Customer με το ID μέσα στο List και να γράψω στο νέο αρχείο
            το οποίο θα κάνει override το παλιό*/
            try
            {
                foreach (Customer i in customers)
                {
                    if (i.ID != Cust.ID)
                    {
                        Add(i.ToString(), FileHelp);
                        Add(Cust.ToString(), FileHelp);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            //Πρέπει να αντιγράψω το FileHelp στο FileCustomersPath και να το κάνω overwrite
            File.Copy(FileHelp, FileCustomersPath, true);
            //Πρέπει να σβήσω το File Help
            File.Delete(FileHelp);
        }

        public static List<Customer> Read()
        {
            List<Customer> customers = new List<Customer>();
            Customer newcustomer;
            string[] lines = File.ReadAllLines(FileCustomersPath);
            foreach (string line in lines)
            {
                var columns = line.Split(',');
                newcustomer = new Customer(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3], columns[4]);
                customers.Add(newcustomer);
            }
            return customers;
        }

    }
}
