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
        public static void Sort(ref StudentSecialty[] student, int parameter)
        {
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < student.Length - 1; j++)
                {
                    switch (parameter)
                    {
                        case 1:
                            if (student[j].Age > student[j + 1].Age)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                        case 2:
                            if (student[j].Weight > student[j + 1].Weight)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                        case 3:
                            if (student[j].Height > student[j + 1].Height)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                        case 4:
                            if (student[j].Course > student[j + 1].Course)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                        case 5:
                            if (student[j].SkippingHours > student[j + 1].SkippingHours)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                        case 6:
                            if (student[j].AvarageMark > student[j + 1].AvarageMark)
                            {
                                StudentSecialty temp = student[j];
                                student[j] = student[j + 1];
                                student[j + 1] = temp;
                            }
                            break;
                    }

                }
            }
        }
    }
}
