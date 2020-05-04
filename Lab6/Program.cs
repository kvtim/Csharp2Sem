using System;

namespace LR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSecialty[] person = new StudentSecialty[3];
            person[0] = new StudentSecialty(18, "Ignat", "Sidorov", 49, 205, 4,
                faculty.KSIS, "IiTP", 90, 10.0, "Minsk", 1000000, "C#");
            person[1] = new StudentSecialty(23, "Petr", "Ivanov", 123, 167, 1,
                 faculty.FRE, "Radio Engineering", 5, 2.3, "Brest", 100, "Physics");
            person[2] = new StudentSecialty(20, "Ivan", "Petrov", 119, 190, 4,
                 faculty.FKP, "MiKPRS", 10, 5.6, "Vitebsk", 777, "Physical Culture");

            //for (int i = 0; i < person.Length;)
            //{
            //    Console.Write($" Select {i + 1} student data: Name or Surname: ");
            //    string stringData = Console.ReadLine();
            //    if (stringData != "Name" && stringData != "Surname")
            //    {
            //        Console.WriteLine("\n Your choice isn't correct!");
            //        continue;
            //    }
            //    person[i].SelectData(stringData);
            //    while (true)
            //    {
            //        Console.Write($"\n Select {i + 1} student data: \n 0: Age; \n 1: Weight;" +
            //    " \n 2: Height; \n 3: Id; \n 4: Course; \n 5: Faculty; \n 6: Speciality;" +
            //    " \n 7: Skipping hours; \n 8: Avarage mark; \n 9: Live place; \n 10: Study cost;" +
            //    $" \n 11: Favorite subject; \n 12: All data of {i + 1} person; " +
            //    " \n\n Your choice: ");
            //        int intData = Convert.ToInt32(Console.ReadLine());
            //        person[i].SelectData(intData);
            //        if (intData != 0 && intData != 1 && intData != 2 && intData != 3 && intData != 4 && intData != 5 && intData != 6 &&
            //            intData != 7 && intData != 8 && intData != 9 && intData != 10 && intData != 11 && intData != 12)
            //        {
            //            Console.WriteLine("\n Your choice isn't correct!");
            //            continue;
            //        }
            //        break;
            //    }
            //    if (i == person.Length - 1)
            //    {
            //        while (true)
            //        {
            //            Console.Write("\n Show more information about last student? Yes or No: ");
            //            string exit = Console.ReadLine();
            //            if (exit != "No" && exit != "Yes")
            //            {
            //                Console.WriteLine("\n Your choice isn't correct!");
            //                continue;
            //            }
            //            Console.WriteLine();
            //            if (exit == "No")
            //            {
            //                i++;
            //            }
            //            break;
            //        }

            //    }
            //    else
            //    {
            //        while (true)
            //        {
            //            Console.Write("\n Go to next student? Yes or No: ");
            //            string continuation = Console.ReadLine();
            //            if (continuation != "No" && continuation != "Yes")
            //            {
            //                Console.WriteLine("\n Your choice isn't correct!");
            //                continue;
            //            }
            //            Console.WriteLine();
            //            if (continuation == "Yes")
            //                i++;
            //            break;
            //        }
            //    }
            //}

            Console.Write(" Do you wont to sort students? Yes or No: ");
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice == "Yes")
                {
                    while (true)
                    {
                        Console.Write("\n Сhoose by what parameters to sort students: \n 1: Age; \n 2: Weight;" +
                           " \n 3: Height; \n 4: Course; \n 5: Skipping hours; \n 6: Avarage mark; \n\n Your choice: ");
                        int sort = Convert.ToInt32(Console.ReadLine());
                        if (sort != 0 && sort != 1 && sort != 2 && sort != 3 && sort != 4 && sort != 5 && sort != 6)
                        {
                            Console.WriteLine("\n Your choice isn't correct!");
                            continue;
                        }
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
                        }
                        break;
                    }

                    string exit;
                    while (true)
                    {
                        Console.Write("\n Sort by other parameters? Yes or No: ");

                        exit = Console.ReadLine();
                        if (exit != "Yes" && exit != "No")
                        {
                            Console.WriteLine("\n Your choice isn't correct!");
                            continue;
                        }
                        break;
                    }
                    if (exit == "No")
                    {
                        break;
                    }
                }
                else if (choice == "No")
                    break;
                else
                {
                    Console.Write("\n Your choice isn't correct! Required to enter Yes or No: ");
                    choice = Console.ReadLine();
                }
            }

            while (true)
            {
                Console.Write("\n Do you want to check if there are students from the same course? Yes or No: ");
                choice = Console.ReadLine();

                if (choice == "No")
                    break;
                if (choice == "Yes")
                {
                    bool chek = false;
                    for (int i = 0; i < person.Length - 1; i++)
                    {
                        for (int j = 1; j < person.Length; j++)
                        {
                            if (i == j)
                                continue;
                            if (person[i].Equals(person[j]))
                            {
                                Console.WriteLine($"\n {person[i].Name} and {person[j].Name} from once course!");
                                chek = true;
                            }
                        }
                    }
                    if (chek == false)
                        Console.WriteLine("\n There are no such students!\n");
                    break;
                }
                Console.WriteLine("\n Your choice isn't correct!");
            }

            while (true)
            {
                Console.Write("\n Do you want to show students with positive avarage mark? Yes or No: ");
                choice = Console.ReadLine();
                if (choice != "Yes" && choice != "No")
                {
                    Console.WriteLine("\n Your choice isn't correct!");
                    continue;
                }

                if (choice == "No")
                    break;

                if (choice == "Yes")
                {

                    for (int i = 0; i < person.Length; i++)
                    {
                        if (person[i].PositiveAverageMark() == true)
                        {
                            Console.WriteLine("\n Students with positive average mark: ");
                            break;
                        }
                        if (i == person.Length - 1)
                            Console.WriteLine("\n There is no such. Unfortunately, all students have negative grades. ");
                    }

                    for (int i = 0; i < person.Length; i++)
                    {
                        if (person[i].PositiveAverageMark() == true)
                        {
                            Console.WriteLine($"\n {person[i].Name}: {person[i].AvarageMark}");
                        }
                    }
                }
                break;
            }

            while (true)
            {
                Console.Write("\n Do you want to transfer a student to another faculty? Yes or No: ");
                choice = Console.ReadLine();
                if (choice != "Yes" && choice != "No")
                {
                    Console.WriteLine("\n Your choice isn't correct!");
                    continue;
                }

                if (choice == "No")
                    break;
                while (true)
                {
                    if (choice == "Yes")
                    {
                        int number, transfer, speciality = 100;
                        Console.WriteLine("\n Select the student you want to transfer to another faculty: ");

                        while (true)
                        {
                            for (int i = 0; i < person.Length; i++)
                            {
                                Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname}," +
                                    $" {person[i].Faculty}, {person[i].Speciality};");
                            }
                            Console.Write("\n Your choice: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number < 1 || number > person.Length)
                            {
                                Console.WriteLine("\n Your choice isn't correct!");
                                continue;
                            }

                            break;
                        }

                        while (true)
                        {
                            Console.Write("\n Choose a faculty for this student:\n 1: KSIS,\n 2: FITY,\n 3: IEF,\n 4: FKP,\n 5: FRE" +
                          "\n\n You choice: ");
                            transfer = Convert.ToInt32(Console.ReadLine());
                            if (transfer < 1 || transfer > 5)
                            {
                                Console.WriteLine("\n Your choice isn't correct!");
                                continue;
                            }
                            break;
                        }

                        person[number - 1].TransferFaculty(transfer);

                        Console.WriteLine("\n Now choose a new specialty for this student: ");
                        switch (transfer)
                        {
                            case 1:
                                while (true)
                                {
                                    Console.Write(" 1: POIT,\n 2: IiTP,\n 3: VMSiS,\n 4: EVS \n You choice: ");
                                    speciality = Convert.ToInt32(Console.ReadLine());
                                    if (speciality < 1 || speciality > 5)
                                    {
                                        Console.WriteLine("\n Your choice isn't correct!\n");
                                        continue;
                                    }
                                    break;
                                }
                                break;
                            case 2:
                                while (true)
                                {
                                    Console.Write(" 1: ASOI,\n 2: II,\n 3: ITiYTS,\n 4: PE, \n 5: Game Industry \n You choice: ");
                                    speciality = Convert.ToInt32(Console.ReadLine());
                                    if (speciality < 1 || speciality > 5)
                                    {
                                        Console.WriteLine("\n Your choice isn't correct!\n");
                                        continue;
                                    }
                                    break;
                                }
                                break;
                            case 3:
                                while (true)
                                {
                                    Console.Write(" 1: Logistics,\n 2: Economy,\n 3: Business,\n 4: Marketing \n You choice: ");
                                    speciality = Convert.ToInt32(Console.ReadLine());
                                    if (speciality < 1 || speciality > 4)
                                    {
                                        Console.WriteLine("\n Your choice isn't correct!\n");
                                        continue;
                                    }
                                    break;
                                }
                                break;
                            case 4:
                                while (true)
                                {
                                    Console.Write(" 1: I-POiT,\n 2: ISiTOPB,\n 3: Med Electronic,\n 4: MiKPRS, \n 5: PMS,\n" +
                                        " 6: ESB,\n You choice: ");
                                    speciality = Convert.ToInt32(Console.ReadLine());
                                    if (speciality < 1 || speciality > 6)
                                    {
                                        Console.WriteLine("\n Your choice isn't correct!\n");
                                        continue;
                                    }
                                    break;
                                }
                                break;
                            case 5:
                                while (true)
                                {
                                    Console.Write(" 1: KIS,\n 2: NiNE,\n 3: Radio Informatics,\n 4: Radio Engineering, " +
                                         "\n 5: Electronic Systems,\n 6: RZI,\n 7: Professional study \n\n You choice: ");
                                    speciality = Convert.ToInt32(Console.ReadLine());
                                    if (speciality < 1 || speciality > 7)
                                    {
                                        Console.WriteLine("\n Your choice isn't correct!\n");
                                        continue;
                                    }
                                    break;
                                }
                                break;
                        }

                        person[number - 1].TransferSpeciality(speciality);

                        Console.WriteLine("\n This student after transform:");
                        Console.WriteLine($"\n {person[number - 1].Name} {person[number - 1].Surname}\n" +
                            $" Faculty: {person[number - 1].Faculty}\n Speciality: {person[number - 1].Speciality}");

                        while (true)
                        {
                            Console.Write("\n Do you to transform other student? Yes or No: ");
                            choice = Console.ReadLine();
                            if (choice != "No" && choice != "Yes")
                            {
                                Console.WriteLine("\n Your choice isn't correct!");
                                continue;
                            }
                            break;
                        }
                        if (choice == "Yes")
                            continue;
                        break;
                    }
                }
                break;
            }
            Console.Write("\n Press eny key to exit... ");
            Console.ReadKey();
        }
    }
}
