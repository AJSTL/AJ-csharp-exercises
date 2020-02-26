using System;
using static Restaurant.MenuItem;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEST data: name, description, price, category
            MenuItem testApp = new MenuItem("Test Appetizer","Test Appetizer Description", 8, CategoryType.Appetizer);
            MenuItem testEntree = new MenuItem("Test Entree", "Test Entree Description", 16, CategoryType.MainCourse);
            MenuItem testDessert = new MenuItem("Test Dessert", "Test Dessert Description", 6, CategoryType.Dessert);

            
            Console.WriteLine("TEST: print the test items one at a time");
            Console.WriteLine(testApp.ItemName + ", " + testApp.ItemDescription + ", " + testApp.ItemPrice);
            Console.WriteLine(testEntree.ItemName + ", " + testEntree.ItemDescription + ", " + testEntree.ItemPrice);
            Console.WriteLine(testDessert.ItemName + ", " + testDessert.ItemDescription + ", " + testApp.ItemPrice);


            Console.WriteLine("TEST: adding the items to the menu");
            Menu testMenu = new Menu();
            testMenu.AddItem(testApp);
            testMenu.AddItem(testEntree);
            testMenu.AddItem(testDessert);

  
            Console.WriteLine("TEST: print the full menu with categories");
            testMenu.PrintMenu();

            Console.WriteLine("TEST: remove an item from the menu");
            testMenu.RemoveItem(testDessert);

            Console.WriteLine("TEST: reprint the full menu with categories, less the removed item");
            testMenu.PrintMenu();

            Console.WriteLine("TEST: print when the menu was last updated");
            Console.WriteLine(testMenu.LastUpdated.ToString());

            Console.WriteLine("TEST: print bool new items available");
            Console.WriteLine(testMenu.NewItemsAvailable);

            Console.WriteLine("TEST: print the appetizer added date");
            Console.WriteLine(testApp.AddedOn);

            Console.WriteLine("TEST: print bool appetizer is new");
            Console.WriteLine(testApp.IsNew);
        }
    }
}
