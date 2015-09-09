using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystem
{
    class Customer
    {
        string _ID;
        string _firstName;
        string _lastName;
        string _telephone;
        string _address;

        public string ID
        {
            get
            {
                return this._ID;
            }

            set
            {
                 _ID = value;
            }

        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public Customer()
        {

        }

        public Customer(string ID, string FirstName, string LastName, string Telephone, string Address)    //Base Constructor (private fields not null at all)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Telephone = Telephone;
            this.Address = Address;
        }

        /// <summary>
        /// Επιστρέφει τα στοιχεία του πελάτη σε μορφή "ID, FirstName, LastName, Telephone, Address"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ID + "," + FirstName + "," + LastName + "," + Telephone + "," + Address;
        }
        public string ToString(string ID, string FirstName, string LastName, string Telephone, string Address)
        {
            return ID + "," + FirstName + "," + LastName + "," + Telephone + "," + Address;
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

            return this.FirstName == ((Customer)obj).FirstName &&
            this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this._ID.GetHashCode() ^ this._firstName.GetHashCode() ^ this._lastName.GetHashCode() ^
                this._telephone.GetHashCode() ^ this._address.GetHashCode();
        }


    }
}
