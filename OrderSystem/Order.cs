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
        string _ordercode;
        public string Ordercode
        {
            get { return _ordercode; }
            set { _ordercode = value; }
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
        double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }



        public Order()
        {
            
        }

        public Order(int CustomerID, string ordercode, string description, int quantity, double price)
        {
            this.IDCustomer = CustomerID;
            this.Ordercode = ordercode;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return IDCustomer + "," + Ordercode + "," + Description + "," + Quantity + "," + Price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Order))
            {
                return false;
            }

            return this.IDCustomer == ((Order)obj).IDCustomer ^ this.Ordercode == ((Order)obj).Ordercode;
        }

        public override int GetHashCode()
        {
            return this._IDCustomer;
        }
    }
}
