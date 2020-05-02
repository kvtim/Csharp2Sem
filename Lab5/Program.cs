using System;

namespace LR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSecialty[] person = new StudentSecialty[3];
            person[0] = new StudentSecialty(18, "Ignat", "Sidorov", 49, 205, 1,
                faculty.KSIS, "IiTP", 90, 10.0, "Minsk", 1000000, "C++");
            person[1] = new StudentSecialty(23, "Petr", "Ivanov", 123, 167, 3,
                 faculty.FRE, "Radio Engineering", 5, 2.3, "Brest", 100, "Physics");
            person[2] = new StudentSecialty(20, "Ivan", "Petrov", 119, 190, 4,
                 faculty.FKP, "Computer Science", 10, 5.6, "Vitebsk", 777, "Physical Culture");

            for (int i = 0; i < person.Length;)
            {
                Console.Write($" Select {i + 1} student data: Name or Surname: ");
                string StringData1 = Console.ReadLine();
                person[i].SelectData(StringData1);
                Console.Write($"\n Select {i + 1} student data: \n 0: Age; \n 1: Weight;" +
                    " \n 2: Height; \n 3: Id; \n 4: Course; \n 5: Faculty; \n 6: Speciality;" +
                    " \n 7: Skipping hours; \n 8: Avarage mark; \n 9: Live place; \n 10: Study cost;" +
                    $" \n 11: Favorite subject; \n 12: All data of {i + 1} person; " +
                    " \n\n Your choice: ");
                int IntData1 = Convert.ToInt32(Console.ReadLine());
                person[i].SelectData(IntData1);
                if (i == person.Length - 1)
                {
                    Console.Write("\n Show more information about last student? Yes or No: ");
                    string exit = Console.ReadLine();
                    Console.WriteLine();
                    if (exit == "No")
                    {
                        i++;
                    }
                }
                else
                {
                    Console.Write("\n Go to next student? Yes or No: ");
                    string continuation = Console.ReadLine();
                    Console.WriteLine();
                    if (continuation == "Yes")
                        i++;
                }
            }

            Console.Write(" Do you wont to sort students? Yes or No: ");
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice == "Yes")
                {
                    Console.Write("\n Сhoose by what parameters to sort students: \n 1: Age; \n 2: Weight;" +
                    " \n 3: Height; \n 4: Course; \n 5: Skipping hours; " +
                    " \n 6: Avarage mark; \n\n Your choice: ");
                    int sort = Convert.ToInt32(Console.ReadLine());

                    switch (sort)
                    {
                        case 1:
                            StudentSecialty.Sort(person, 1);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student age: {person[i].Age}");
                            }
                            break;
                        case 2:
                            StudentSecialty.Sort(person, 2);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student weight: {person[i].Weight}");
                            }
                            break;
                        case 3:
                            StudentSecialty.Sort(person, 3);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student height: {person[i].Height}");
                            }
                            break;
                        case 4:
                            StudentSecialty.Sort(person, 4);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student course: {person[i].Course}");
                            }
                            break;
                        case 5:
                            StudentSecialty.Sort(person, 5);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student skipping hours: {person[i].SkippingHours}");
                            }
                            break;
                        case 6:
                            StudentSecialty.Sort(person, 6);
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname} \n " +
                                $"Student avarage mark: {person[i].AvarageMark}");
                            }
                            break;
                        default:
                            Console.WriteLine("\n Your choice isn't correct!");
                            break;

                    }
                    Console.Write("\n Sort by other parameters? Yes or No: ");

                    if (Console.ReadLine() == "No")
                    {
                        break;
                    }
                }
                else if (choice == "No")
                    break;
                else
                {
                    Console.Write("\n Required to enter Yes or No: ");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
