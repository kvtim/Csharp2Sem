using System;

namespace LR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSecialty person1 = new StudentSecialty(18, "Egor", "Shirko", 49, 205, 1,
                faculty.KSIS, "IiTP", 90, 10.0, "Pizdische", 1000000, "C++");
            StudentSecialty person2 = new StudentSecialty(20, "Petr", "Petrovich", 119, 167, 3,
                 faculty.FRE, "Radiotexnik", 5, 2.3, "Brest", 100, "Radio");

            while (true)
            {
                Console.Write(" Select first student data: Name or Surname: ");
                string StringData1 = Console.ReadLine();
                person1.SelectData(StringData1);
                Console.Write(" Select first student data: \n 0: Age; \n 1: Weight;" +
                    " \n 2: Height; \n 3: Id; \n 4: Course; \n 5: Faculty; \n 6: Speciality;" +
                    " \n 7: Skipping hours; \n 8: Avarage mark; \n 9: Live place; \n 10: Study cost;" +
                    " \n 11: Favorite subject; \n 12: All data of 1 person; " +
                    " \n Your choice: ");
                int IntData1 = Convert.ToInt32(Console.ReadLine());
                person1.SelectData(IntData1);
                Console.Write(" Go to next person? Yes or No: ");
                string continuation = Console.ReadLine();
                if (continuation == "Yes")
                    break;
            }

            while (true)
            {
                Console.Write(" Select second student data: Name or Surname: ");
                string StringData2 = Console.ReadLine();
                person1.SelectData(StringData2);
                Console.Write(" Select second student data: \n 0: Age; \n 1: Weight;" +
                    " \n 2: Height; \n 3: Id; \n 4: Course; \n 5: Faculty; \n 6: Speciality;" +
                    " \n 7: Skipping hours; \n 8: Avarage mark; \n 9: Live place; \n 10: Study cost;" +
                    " \n 11: Favorite subject; \n 12: All data of 2 person; " +
                    " \n Your choice: ");
                int IntData2 = Convert.ToInt32(Console.ReadLine());
                person2.SelectData(IntData2);
                Console.Write(" Go to sort? Yes or No: ");
                string exit = Console.ReadLine();
                if (exit == "Yes")
                    break;
            }

            Console.Write(" Do you wont to sort students parametrs? Yes or No: ");
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice == "Yes")
                {
                    Console.Write(" Сhoose by what parameters to sort students: \n 1: Age; \n 2: Weight;" +
                    " \n 3: Height; \n 4: Course; \n 5: Skipping hours; " +
                    " \n 6: Avarage mark; \n Your choice: ");
                    int sort = Convert.ToInt32(Console.ReadLine());
                    switch (sort)
                    {
                        case 1:
                            if (StudentSecialty.Sort(person1.Age, person2.Age) == 2)
                                Console.WriteLine($" Age of first student: {person1.Age}" +
                                    $" \n Age of second student: {person2.Age}");
                            else
                                Console.WriteLine($" Age of second student: {person2.Age}" +
                                    $" \n Age of first student: {person1.Age}");
                            break;
                        case 2:
                            if (StudentSecialty.Sort(person1.Weight, person2.Weight) == 2)
                                Console.WriteLine($" Weight of first student: {person1.Weight}" +
                                    $" \n Weight of second student: {person2.Weight}");
                            else
                                Console.WriteLine($" Weight of second student: {person2.Weight}" +
                                    $" \n Weight of first student: {person1.Weight}");
                            break;
                        case 3:
                            if (StudentSecialty.Sort(person1.Height, person2.Height) == 2)
                                Console.WriteLine($" Height of first student: {person1.Height}" +
                                    $" \n Height of second student: {person2.Height}");
                            else
                                Console.WriteLine($" Height of second student: {person2.Height}" +
                                    $" \n Height of first student: {person1.Height}");
                            break;
                        case 4:
                            if (StudentSecialty.Sort(person1.Course, person2.Course) == 2)
                                Console.WriteLine($" Course of first student: {person1.Course}" +
                                    $" \n Course of second student: {person2.Course}");
                            else
                                Console.WriteLine($" Course of second student: {person2.Course}" +
                                    $" \n Course of first student: {person1.Course}");
                            break;
                        case 5:
                            if (StudentSecialty.Sort(person1.SkippingHours, person2.SkippingHours) == 2)
                                Console.WriteLine($" Skipping hours of first student: {person1.SkippingHours}" +
                                    $" \n Skipping hours of second student: {person2.SkippingHours}");
                            else
                                Console.WriteLine($" Skipping hours of second student: {person2.SkippingHours}" +
                                    $" \n Skipping hours of first student: {person1.SkippingHours}");
                            break;
                        case 6:
                            if (StudentSecialty.Sort(person1.AvarageMark, person2.AvarageMark) == 2)
                                Console.WriteLine($" Avarage mark of first student: {person1.AvarageMark}" +
                                    $" \n Avarage mark of second student: {person2.AvarageMark}");
                            else
                                Console.WriteLine($" Avarage mark of second student: {person2.AvarageMark}" +
                                    $" \n Avarage mark of first student: {person1.AvarageMark}");
                            break;
                        default:
                            Console.WriteLine(" Your choice isn't correct!");
                            break;

                    }
                    Console.Write(" Sort by other parameters? Yes or No: ");

                    if (Console.ReadLine() == "No")
                    {
                        break;
                    }
                }
                else if (choice == "No")
                    break;
                else
                {
                    Console.Write(" Required to enter Yes or No: ");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
