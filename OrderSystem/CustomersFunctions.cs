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
        private string FilePath = @"C:\Users\Giannis\Documents\GitHub\OrderSystem\Data";
        private void CheckFileExist(string FilePath)
        {

        }

        public void CreateFileData(string ID)
        {
            string FileName = ID + ".txt";
            string FullPath = System.IO.Path.Combine(FilePath, FileName);
            File.Create(FullPath);
        }

        public void Add(string ID, string FirstName, string LastName, string Telephone, string Address)
        {
            string FileName = ID + ".txt";
            string FullPath = System.IO.Path.Combine(FilePath, FileName);
            string[] lines = { FirstName, LastName, Telephone, Address };

            System.IO.Directory.CreateDirectory(FilePath);
            try
            {

                if (!System.IO.File.Exists(FullPath))
                {
                    System.IO.File.WriteAllLines(FullPath, lines);
                    System.Windows.Forms.MessageBox.Show("Ο πελάτης δημιουργήθηκε");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File already exists.", ID);                  
                    return;
                }
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(int ID)
        {
            File.Delete(FilePath + ID + ".txt");
        }

        public void Update(int ID, string FirstName, string LastName, string Telephone, string Address)
        {

        }

    }
}
