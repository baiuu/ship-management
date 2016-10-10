using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marina.Entity
{
   public class Customer
    {
        public  string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public  string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public  string phoneno;

        public string Phoneno
        {
            get
            {
                return phoneno;
            }
            set
            {
                phoneno = value;
            }
        }

        private Entity.Boat boat1;

        internal Entity.Boat Boat1
        {
            get
            {
                return boat1;
            }
            set
            {
                boat1 = value;
            }
        }
    }
}
