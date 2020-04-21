using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    class Student : Person
    {
        public int Course { get; set; }
        public faculty Faculty { get; set; }
        public Student(int age, string name, string surname, int weight,
            int height, int course, faculty faculty)
            : base(age, name, surname, weight, height)
        {
            this.Course = course;
            this.Faculty = faculty;
        }
        public static int Sort(double Student1, double Student2)
        {
            if (Student1 > Student2)
                return 1;
            else
                return 2;

        }
    }
}
