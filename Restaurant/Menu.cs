using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        //A way to tell when the menu was last updated
        public DateTime LastUpdated  {  get; set; }

        public Boolean NewItemsAvailable
        {
            get
            {
                 return MenuItems.Any(x => x.IsNew);                
            }
        }
        //private List<string> category = new List<string>() {"Appetizer", "MainCourse", "Dessert"};
       

        private void AddItem(MenuItem item)
        {
            item.AddedOn = DateTime.Now.Date;
            LastUpdated = DateTime.Now.Date;
            MenuItems.Add(item);
            //A way to add items from the menu       
        }

        private void RemoveItem(MenuItem item)
        {
            MenuItems.RemoveAll(x => x.Equals(item));
            //MenuItems.Remove(item);
            //A way to remove items from the menu
        }

        private bool IsNew(MenuItem item)
        {
            //A way to tell if a menu item is new
            if (item.IsNew) return true;
            else return false;
        }

        //private string DateUpdated(MenuItem item)
        //{
            
            //A way to tell when the menu was last updated
       // }


        public void PrintMenu()
        {
            //A way to print out an entire menu

            foreach (var category in Category)
            {
                Console.WriteLine(category);

                foreach (MenuItem item in MenuItems)
                {
                    item.PrintMenuItem(item);
                }
            }
        }
        
    }


}


  
