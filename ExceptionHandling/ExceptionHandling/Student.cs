using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public double AverageGrade()
        {
            return Grades.Sum() / Grades.Length;
        }
    }
}
