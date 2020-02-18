using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class Student
        {
            private static int nextStudentID = 1;

            int studentId;
            int numberOfCredits;
            double gpa;

            public string Name
            { get; set; }

            public int StudentID { get; private set; }

            public int NumberOfCredits { get; set; }


        }
    }
}
