using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marina.Entity
{
    class Slipway
    {
        private int id;

        public int Id
        {
            get 
            {
                return id; 
            }
            set 
            { 
                id = value;
            }
        }
        private string name;

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

        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
    }
}
