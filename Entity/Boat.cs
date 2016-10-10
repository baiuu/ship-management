using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marina.Entity
{
   public  class Boat
    {
        public   string stateregistrationno;

        public string Stateregistrationno
        {
            get
            {
                return stateregistrationno;
            }
            set
            {
                stateregistrationno = value;
            }
        }

        public  string manufacturer;

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public double length;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public string customerphone;

        public string Customerphone
        {
            get
            {
                return customerphone;
            }
            set
            {
                customerphone = value;
            }
        }

        public int slipwayno;

        public int Slipwayno
        {
            get
            {
                return slipwayno;
            }
            set
            {
                slipwayno = value;
            }
        }

        public string validity;

        public string Validity
        {
            get
            {
                return validity;
            }
            set
            {
                validity = value;
            }
        }

        public int keel;

        public int Keel
        {
            get
            {
                return keel;
            }
            set
            {
                keel = value;
            }
        }

        public int sail;

        public int Sail
        {
            get
            {
                return sail;
            }
            set
            {
                sail = value;
            }
        }

        public char type;

        public char Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public char energe;

        public char Energe
        {
            get
            {
                return energe;
            }
            set
            {
                energe = value;
            }
        }
    }
}
