using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>();

            for (int i=0; i<=20; i++)
            {
                listOfIntegers.Add(i);
                //Console.WriteLine(i);
            }

            int sumOfEvens = 0;

            for (int j=0; j<listOfIntegers.Count; j++)
            {
                if (j%2 == 0)
                {
                    sumOfEvens += j;
                    //Console.WriteLine(j);
                    //Console.WriteLine(sumOfEvens);
                } 
            }

            Console.WriteLine("The sum of all even numbers in a list of integers 0-20 is " + sumOfEvens);
            
        }
    }
}
