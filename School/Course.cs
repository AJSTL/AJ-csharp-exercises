using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace School
{
    public class Course
    {
        private static int nextCourseId = 1;
        private string name;
        private int v;

        public static string Name { get; set; }

        public int CourseID { get; private set; }

        public int NumberOfCredits { get; set; }

        public List<Student> Students { get; private set; }

        

    }
}
