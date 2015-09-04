using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystem
{
    class CustomersFunction
    {
        public class Add
        {
            string FilePath = @"C:\Users\Giannis\Documents\GitHub\OrderSystem\";
            private Add()
            {

            }

            public Add(string ID)
            {
                File.Create(FilePath + ID + ".txt");
            }
        }

    }
}
