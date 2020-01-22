using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dictionaries: Make a program similar to GradebookDict, 
             * but which takes in students names and ID numbers (as integers) instead of names and grades. 
             * In this case, however, the keys should be integers (the IDs) and the values should be strings (the names). 
             * Modify the roster printing code accordingly. */

            Dictionary<int, string> roster = new Dictionary<int, string>();

            string name = "_";
            int idNum = 0;

            while (name != "")
            {
                while (idNum != )
                {
                    Console.Write("Student Name: ");
                    name = Console.ReadLine();

                    Console.Write("Student ID: ");
                    idNum = Convert.ToInt32(Console.ReadLine());

                    roster.Add(idNum, name);
                }

            } 
           
            if (name == "")
            {
                Console.WriteLine(roster);
            }
           
            
     






        }
    }
}
