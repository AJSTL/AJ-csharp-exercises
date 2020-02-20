using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); // from Scott's example
        // DOES THE SAME AS BELOW
        //public Menu()
        //
         //   MenuItems = new List<MenuItem>(); // from Scott's Example
        // }

        public Boolean newItemsAvailable
        {
            get
            {
                 return MenuItems.Any(x => x.isNew);
                
            }
        }
        //private List<string> category = new List<string>() {"Appetizer", "MainCourse", "Dessert"};
        public Category Category { get; set; }
    }


}
