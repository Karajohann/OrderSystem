using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystem
{
    class CustomersFunctions
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
        private const string FileOrdersPath = @"Orders.txt";
        private void CheckFileExist(string FilePath)
        {

        }

        public void CreateFileData(string ID)
        {

        }

        public void Add(string Customer)
        {
            try
            {
                if (File.Exists(FileCustomersPath))
                {
                    File.AppendText(Customer);
                }
                else
                {
                    File.AppendAllText(FileCustomersPath, Customer);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            
        }

        public void Delete(int ID)
        {

        }

        public void Update(int ID, string FirstName, string LastName, string Telephone, string Address)
        {

        }

    }
}
