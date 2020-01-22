using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists and Strings: Write a static method to print out each word in a list that has exactly 5 letters.

            // Create a List using Range    
            string[] fruitsArray = {"apple", "banana", "orange", "pear", "grape", "pineapple", "papaya", "mango"};
            List<string> fruits = new List<string>(fruitsArray);

            for (int i=0; i<fruits.Count; i++)
            {
                if (fruits[i].Length == 5)
                {
                    Console.WriteLine(fruits[i]);
                }
            }
            

        }
    }
}
