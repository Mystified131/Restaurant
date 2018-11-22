using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        public string Name { get; set; }
        public Double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public MenuItem(string name, Double price)

        { name = Name;
            price = Price;
        }

        public override String ToString()
        {
            return Name + " (Item Name: " + Name + ", Price " + Price + ")";
        }

        public override bool Equals(Object o)
        {
            if (o == this)
            {
                return true;
            }

            if ((o == null) & o.GetType() != GetType())
            {
                return false;
            }

            Student menuitemObj = o as Student;
            return Name == menuitemObj.Name;
        }


    }
}
