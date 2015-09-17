using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        int _IDCustomer;
        public int IDCustomer
        {
            get { return _IDCustomer; }
            set { _IDCustomer = value; }
        }
        string _productcode;
        public string Productcode
        {
            get { return _productcode; }
            set { _productcode = value; }
        }
        string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Order()
        {
            
        }

        public Order(int CustomerID, string productcode, string description, int quantity, float price)
        {
            this.IDCustomer = CustomerID;
            this.Productcode = productcode;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return IDCustomer + " " + Productcode + " " + Description + " " + Quantity + " " + Price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }

            return this.IDCustomer == ((Order)obj)._IDCustomer;
        }

        public override int GetHashCode()
        {
            return this._IDCustomer;
        }
    }
}
