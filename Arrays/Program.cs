using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays: Create and initialize in a single line an array with the following values: 1, 1, 2, 3, 5, 8. 
            //Then loop through the array and print out each value.

            int[] array = { 1, 1, 2, 3, 5, 8 };

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
