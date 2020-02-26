using System;
using System.Collections.Generic;
using System.Linq;
using static Restaurant.MenuItem;


namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        //A way to tell when the menu was last updated
        public DateTime LastUpdated { get; set; }


        public Boolean NewItemsAvailable
        {
            get
            {
                return MenuItems.Any(x => x.IsNew);
            }
        }

        public void AddItem(MenuItem item)
        {
            //A way to add items from the menu  
            item.AddedOn = DateTime.Now.Date;
            LastUpdated = DateTime.Now.Date;
            MenuItems.Add(item);  
        }

        public void RemoveItem(MenuItem item)
        {
            //A way to remove items from the menu
            MenuItems.RemoveAll(x => x.Equals(item));
        }


        public void PrintMenu()
        {
            //A way to print out an entire menu

            foreach (CategoryType category in Enum.GetValues(typeof(CategoryType)))
            {
                Console.WriteLine(category);

                foreach (MenuItem item in MenuItems)
                {
                    if (item.Category == category)
                    {
                        item.PrintMenuItem(item);
                    }
                }
            }
        }

    }


}



