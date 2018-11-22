using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        public string Name { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string name, DateTime lastUpdated)

        {
            name = Name;
            lastUpdated = LastUpdated;
      
        }

        public List <Dictionary<string, double>> Menuitems { get; set; }


        public override String ToString()
        {
            return Name + " (Name: " + Name + ", Last Updated: " + LastUpdated + ")";
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

            Menu menuObj = o as Menu;
            return Name == menuObj.Name;
        }


    }
}


