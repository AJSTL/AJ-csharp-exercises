using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public enum CategoryType { Appetizer, MainCourse, Dessert }
        public CategoryType Category { get; set; }
        public DateTime AddedOn { get; set; }
        public Boolean IsNew
        {
            get
            {
                return AddedOn.Date >= DateTime.Now.Date.AddMonths(-3); // from Scott's example
            }
        }

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }

        private static int Accumulator = 1;
        public int ItemID { get; set; }



        public MenuItem(string itemName, string itemDescription, double itemPrice, CategoryType itemCategory)
        {
            ItemID = Accumulator;
            Accumulator++;
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemDescription = itemDescription;
            Category = itemCategory;
        }
        public void PrintMenuItem(MenuItem item) // public because PrintMenu must be able to call it from Menu class
        {
            //A way to print out a menu item
            Console.WriteLine(item.ItemName);
            Console.WriteLine(item.ItemDescription);
            Console.WriteLine(item.ItemPrice);
            
        }
        /* leaving this example here for reference in case it's useful for PrintMenuItem
        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }*/

        //A way to determine whether or not two menu items are equal
        public override bool Equals(object o)
        {
            if (o == this)
            {
                return true;
            }
            if (o.GetType() != GetType() || o == null)
            {
                return false;
            }
            MenuItem itemObj = o as MenuItem;
            return itemObj.ItemID == ItemID;
        }

        public override int GetHashCode()
        {
            return ItemID;
        }
    }
}
