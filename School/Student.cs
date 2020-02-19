using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            NumberOfCredits += courseCredits;
            //calculated by dividing the total amount of grade points earned by the total amount of credit hours attempted
            Gpa = Gpa + grade / courseCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            // Freshman	0 through 27      // Sophomore   28 through 55
            // Junior  56 through 87      //Senior  88 or more

            if (NumberOfCredits <= 27)
            {
                return "Freshman";
            } 
            else if (NumberOfCredits > 27 && NumberOfCredits <= 55)
            {
                return "Sophomore";
            } 
            else if (NumberOfCredits > 55 && NumberOfCredits <= 87)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

    }
}
