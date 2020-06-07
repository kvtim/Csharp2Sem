using System;

namespace LR_5
{
    delegate void Actions(StudentSecialty[] person);
    class Program
    {
        static void Main(string[] args)
        {
            InputException Error = new InputException();

            StudentSecialty[] person = new StudentSecialty[3];
            person[0] = new StudentSecialty(18, "Ignat", "Sidorov", 49, 205, 4,
                Faculty.KSIS, "IiTP", 90, 10.0, "Minsk", 1000000, "C#");
            person[1] = new StudentSecialty(23, "Petr", "Ivanov", 123, 167, 1,
                 Faculty.FRE, "Radio Engineering", 5, 2.3, "Brest", 100, "Physics");
            person[2] = new StudentSecialty(20, "Ivan", "Petrov", 119, 190, 4,
                 Faculty.FKP, "MiKPRS", 10, 5.6, "Vitebsk", 777, "Physical Culture");



            Console.Write(" The program already has 3 students, do you want to add more? Yes or No: ");

            while (true)
            {
                string choice = Console.ReadLine();
                try
                {
                    if (choice == "Yes")
                    {
                        adding(ref person);

                        person[person.Length - 1].AddStudent += new AddMessage(Show);
                        person[person.Length - 1].DoAdding("\n Ok! You added a new student!");
                        person[person.Length - 1].AddStudent -= new AddMessage(Show);

                        while (true)
                        {
                            try
                            {
                                Console.Write("\n Do you want to add more students? Yes or No: ");
                                choice = Console.ReadLine();

                                if (choice == "Yes")
                                {
                                    adding(ref person);

                                    person[person.Length - 1].AddStudent += new AddMessage(Show);
                                    person[person.Length - 1].DoAdding("\n Ok! You added a new student!");
                                    person[person.Length - 1].AddStudent -= new AddMessage(Show);
                                }
                                else if (choice == "No")
                                    break;
                                else
                                    throw new InputException();
                            }
                            catch (InputException exeption)
                            {
                                Console.Write(exeption.Message);
                            }
                        }
                        break;
                    }
                    else if (choice == "No")
                        break;
                    else
                        throw new InputException("\n Your choice isn't correct! Required to enter Yes or No: ");
                }
                catch (InputException exeption)
                {
                    Console.Write(exeption.Message);
                }
            }

            Actions action = ShowInfo;
            action += Sort;
            action += CheckTheSameCourse;
            action += PositiveAvaraveMark;
            action += Transfer;


            action.Invoke(person);

            Console.Write("\n Press eny key to exit... ");
            Console.ReadKey();
        }

        static Add adding = delegate (ref StudentSecialty[] person)
        {
            Array.Resize(ref person, person.Length + 1);

            int[] intParameters = new int[6];
            string[] stringParameters = new string[4];
            double avarageMark;
            bool check = true;

            while (true)
            {
                try
                {
                    if (check == false)
                        Console.WriteLine("\n You entered an invalid value! You have to re-enter everything.");

                    Console.Write("\n Enter the name of the new student: ");
                    stringParameters[0] = Console.ReadLine();
                    if (stringParameters[0].Length == 0)
                        throw new InputException("\n Value cannot be empty! You have to re-enter everything.");

                    Console.Write("\n Enter the surname of the new student: ");
                    stringParameters[1] = Console.ReadLine();
                    if (stringParameters[1].Length == 0)
                        throw new InputException("\n Value cannot be empty! You have to re-enter everything.");

                    Console.Write("\n Enter the age of the new student: ");
                    check = int.TryParse(Console.ReadLine(), out intParameters[0]);

                    if (check)
                    {
                        Console.Write("\n Enter the weight of the new student: ");
                        check = int.TryParse(Console.ReadLine(), out intParameters[1]);
                        if (check)
                        {
                            Console.Write("\n Enter the height of the new student: ");
                            check = int.TryParse(Console.ReadLine(), out intParameters[2]);
                            if (check)
                            {
                                Console.Write("\n Enter the course of the new student(1 - 4): ");
                                check = int.TryParse(Console.ReadLine(), out intParameters[3]);
                                if (check)
                                {
                                    if (intParameters[3] < 1 || intParameters[3] > 4)
                                        throw new InputException("\n You entered an invalid value! You had to enter a value from 1 to 4! " +
                                            "Re-enter information.");

                                    Console.Write("\n Enter the town of the new student: ");
                                    stringParameters[2] = Console.ReadLine();
                                    if (stringParameters[2].Length == 0)
                                        throw new InputException("\n Value cannot be empty! You have to re-enter everything.");

                                    Console.Write("\n Enter a skiping hours of the new student: ");
                                    check = int.TryParse(Console.ReadLine(), out intParameters[4]);
                                    if (check)
                                    {
                                        Console.Write("\n Enter the avarage mark of the new student: ");
                                        check = double.TryParse(Console.ReadLine(), out avarageMark);
                                        if (avarageMark < 0.0 || avarageMark > 10.0)
                                            throw new InputException("\n You entered an invalid value! You had to enter a value from 0 to 10! " +
                                                "Re-enter information.");
                                        if (check)
                                        {
                                            Console.Write("\n Enter a study cost of the new student: ");
                                            check = int.TryParse(Console.ReadLine(), out intParameters[5]);
                                            if (check)
                                            {
                                                Console.Write("\n Enter the favorite subject of the new student: ");
                                                stringParameters[3] = Console.ReadLine();
                                                if (stringParameters[3].Length == 0)
                                                    throw new InputException("\n Value cannot be empty! You have to re-enter everything.");
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            person[person.Length - 1] = new StudentSecialty(intParameters[0], stringParameters[0], stringParameters[1],
                intParameters[1], intParameters[2], intParameters[3], Faculty.KSIS, "MiKPRS",
                intParameters[4], avarageMark, stringParameters[2], intParameters[5], stringParameters[3]);

            int number = person.Length - 1;
            int transfer = 100;

            FacultyTransfer(person, ref transfer, ref number);
            SpecialityTransfer(person, ref transfer, ref number, 100);
        };
        static void ShowInfo(StudentSecialty[] person)
        {
            ShowOrTransfer show = Show;

            string stringData;
            for (int i = 0; i < person.Length;)
            {
                try
                {
                    Console.Write($"\n Select {i + 1} student data: Name or Surname: ");
                    stringData = Console.ReadLine();
                    if (stringData != "Name" && stringData != "Surname")
                    {
                        throw new InputException();
                    }
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                    continue;
                }
                person[i].SelectData(stringData, show);
                while (true)
                {
                    try
                    {
                        Console.Write($"\n Select {i + 1} student data: \n 0: Age; \n 1: Weight;" +
                       " \n 2: Height; \n 3: Id; \n 4: Course; \n 5: Faculty; \n 6: Speciality;" +
                       " \n 7: Skipping hours; \n 8: Avarage mark; \n 9: Live place; \n 10: Study cost;" +
                      $" \n 11: Favorite subject; \n 12: All data of {i + 1} person; " +
                      " \n\n Your choice: ");
                        int intData;
                        bool chekInt = int.TryParse(Console.ReadLine(), out intData);
                        if (chekInt)
                        {
                            person[i].SelectData(intData, show);
                            if (intData != 0 && intData != 1 && intData != 2 && intData != 3 && intData != 4 && intData != 5 &&
                                intData != 6 && intData != 7 && intData != 8 && intData != 9 && intData != 10 && intData != 11 && intData != 12)
                            {
                                throw new InputException();
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n You should enter a number!");
                            continue;
                        }
                    }
                    catch (InputException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }

                }
                if (i == person.Length - 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\n Show more information about last student? Yes or No: ");
                            string exit = Console.ReadLine();
                            if (exit != "No" && exit != "Yes")
                            {
                                throw new InputException();
                            }
                            Console.WriteLine();
                            if (exit == "No")
                            {
                                i++;
                            }
                            break;
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\n Go to next student? Yes or No: ");
                            string continuation = Console.ReadLine();
                            if (continuation != "No" && continuation != "Yes")
                            {
                                throw new InputException();
                            }
                            Console.WriteLine();
                            if (continuation == "Yes")
                                i++;
                            break;
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                    }
                }
            }
        }
        static void Sort(StudentSecialty[] person)
        {
            Console.Write(" Do you wont to sort students? Yes or No: ");
            string choice = Console.ReadLine();

            while (true)
            {
                try
                {
                    if (choice == "Yes")
                    {
                        while (true)
                        {
                            try
                            {
                                int sort;
                                Console.Write("\n Сhoose by what parameters to sort students: \n 1: Age; \n 2: Weight;" +
                                   " \n 3: Height; \n 4: Course; \n 5: Skipping hours; \n 6: Avarage mark; \n\n Your choice: ");

                                bool chekInt = int.TryParse(Console.ReadLine(), out sort);

                                if (chekInt)
                                {
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
                                        default: throw new InputException();
                                    }
                                    break;
                                }
                                else
                                    Console.WriteLine("\n You should enter a number!");

                            }
                            catch (InputException exception)
                            {
                                Console.WriteLine(exception.Message);
                            }
                        }

                        string exit;
                        while (true)
                        {
                            try
                            {
                                Console.Write("\n Sort by other parameters? Yes or No: ");

                                exit = Console.ReadLine();
                                if (exit != "Yes" && exit != "No")
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            catch (InputException exception)
                            {
                                Console.Write(exception.Message);
                            }
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
                        throw new InputException("\n Your choice isn't correct! Required to enter Yes or No: ");
                    }
                }
                catch (InputException exception)
                {
                    Console.Write(exception.Message);
                    choice = Console.ReadLine();
                }
            }
        }
        static void CheckTheSameCourse(StudentSecialty[] person)
        {
            while (true)
            {
                try
                {
                    Console.Write("\n Do you want to check if there are students from the same course? Yes or No: ");
                    string choice = Console.ReadLine();

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

                    throw new InputException();
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        static void PositiveAvaraveMark(StudentSecialty[] person)
        {
            while (true)
            {
                try
                {
                    Console.Write("\n Do you want to show students with positive avarage mark? Yes or No: ");
                    string choice = Console.ReadLine();
                    if (choice != "Yes" && choice != "No")
                    {
                        throw new InputException();
                    }

                    if (choice == "No")
                        break;

                    if (choice == "Yes")
                    {

                        for (int i = 0; i < person.Length; i++)
                        {

                            if (StudentSecialty.allAvarageMark(person[i]))
                            {
                                Console.WriteLine("\n Students with positive average mark: ");
                                break;
                            }
                            if (i == person.Length - 1)
                                Console.WriteLine("\n There is no such. Unfortunately, all students have negative grades. ");
                        }

                        for (int i = 0; i < person.Length; i++)
                        {
                            if (StudentSecialty.allAvarageMark(person[i]))
                            {
                                Console.WriteLine($"\n {person[i].Name}: {person[i].AvarageMark}");
                            }
                        }
                    }
                    break;
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        static void Transfer(StudentSecialty[] person)
        {
            while (true)
            {
                try
                {
                    Console.Write("\n Do you want to transfer a student to another Faculty? Yes or No: ");
                    string choice = Console.ReadLine();
                    if (choice != "Yes" && choice != "No")
                    {
                        throw new InputException();
                    }

                    if (choice == "No")
                        break;
                    while (true)
                    {
                        if (choice == "Yes")
                        {
                            int number = 100, transfer = 100, newSpeciality = 100;

                            Console.WriteLine("\n Select the student you want to transfer to another Faculty: ");

                            while (true)
                            {
                                try
                                {
                                    for (int i = 0; i < person.Length; i++)
                                    {
                                        Console.WriteLine($"\n {i + 1}: {person[i].Name} {person[i].Surname}," +
                                            $" {person[i].Faculty}, {person[i].Speciality};");
                                    }
                                    Console.Write("\n Your choice: ");
                                    bool intChek = int.TryParse(Console.ReadLine(), out number);
                                    if (intChek)
                                    {
                                        if (number < 1 || number > person.Length)
                                        {
                                            throw new InputException();
                                        }

                                        break;
                                    }
                                    else
                                        Console.WriteLine("\n You should enter a number!");
                                }
                                catch (InputException exception)
                                {
                                    Console.WriteLine(exception.Message);
                                }
                            }

                            FacultyTransfer(person, ref transfer, ref number);

                            SpecialityTransfer(person, ref transfer, ref number, newSpeciality);

                            Console.WriteLine("\n This student after transform:");
                            Console.WriteLine($"\n {person[number - 1].Name} {person[number - 1].Surname}\n" +
                                $" Faculty: {person[number - 1].Faculty}\n Speciality: {person[number - 1].Speciality}");

                            while (true)
                            {
                                try
                                {
                                    Console.Write("\n Do you to transform other student? Yes or No: ");
                                    choice = Console.ReadLine();
                                    if (choice != "No" && choice != "Yes")
                                    {
                                        throw new InputException();
                                    }
                                    break;
                                }
                                catch (InputException exception)
                                {
                                    Console.WriteLine(exception.Message);
                                }
                            }
                            if (choice == "Yes")
                                continue;
                            break;
                        }
                    }
                    break;
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        static void FacultyTransfer(StudentSecialty[] person, ref int transfer, ref int number)
        {
            Faculty newFaculty;

            while (true)
            {
                try
                {
                    Console.Write("\n Choose a faculty for this student:\n 1: KSIS,\n 2: FITY,\n 3: IEF,\n 4: FKP,\n 5: FRE" +
                  "\n\n You choice: ");

                    bool intChek = int.TryParse(Console.ReadLine(), out transfer);
                    if (intChek)
                    {
                        switch (transfer)
                        {
                            case 1:
                                newFaculty = Faculty.KSIS;
                                break;
                            case 2:
                                newFaculty = Faculty.FITY;
                                break;
                            case 3:
                                newFaculty = Faculty.IEF;
                                break;
                            case 4:
                                newFaculty = Faculty.FKP;
                                break;
                            case 5:
                                newFaculty = Faculty.FRE;
                                break;
                            default:
                                throw new InputException();
                        }
                        break;
                    }
                    else
                        Console.WriteLine("\n You should enter a number!");
                }
                catch (InputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            person[number - 1].TransferFaculty(newFaculty);
        }
        static void SpecialityTransfer(StudentSecialty[] person, ref int transfer, ref int number, int newSpeciality)
        {
            Console.WriteLine("\n Now choose a specialty for this student: ");
            switch (transfer)
            {
                case 1:
                    while (true)
                    {
                        try
                        {
                            Console.Write(" 1: POIT,\n 2: IiTP,\n 3: VMSiS,\n 4: EVS \n\n You choice: ");
                            bool chekInt = int.TryParse(Console.ReadLine(), out newSpeciality);
                            if (chekInt)
                            {
                                if (newSpeciality < 1 || newSpeciality > 5)
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            else
                                Console.WriteLine("\n You should enter a number!\n");
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 2:
                    while (true)
                    {
                        try
                        {
                            Console.Write(" 1: ASOI,\n 2: II,\n 3: ITiYTS,\n 4: PE, \n 5: Game Industry \n\n You choice: ");
                            bool chekInt = int.TryParse(Console.ReadLine(), out newSpeciality);
                            if (chekInt)
                            {
                                if (newSpeciality < 1 || newSpeciality > 5)
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            else
                                Console.WriteLine("\n You should enter a number!\n");
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    while (true)
                    {
                        try
                        {
                            Console.Write(" 1: Logistics,\n 2: Economy,\n 3: Business,\n 4: Marketing \n\n You choice: ");
                            bool chekInt = int.TryParse(Console.ReadLine(), out newSpeciality);
                            if (chekInt)
                            {
                                if (newSpeciality < 1 || newSpeciality > 4)
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            else
                                Console.WriteLine("\n You should enter a number!\n");
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 4:
                    while (true)
                    {
                        try
                        {
                            Console.Write(" 1: I-POiT,\n 2: ISiTOPB,\n 3: Med Electronic,\n 4: MiKPRS, \n 5: PMS,\n" +
                                " 6: ESB,\n\n You choice: ");
                            bool chekInt = int.TryParse(Console.ReadLine(), out newSpeciality);
                            if (chekInt)
                            {
                                if (newSpeciality < 1 || newSpeciality > 6)
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            else
                                Console.WriteLine("\n You should enter a number!\n");
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 5:
                    while (true)
                    {
                        try
                        {
                            Console.Write(" 1: KIS,\n 2: NiNE,\n 3: Radio Informatics,\n 4: Radio Engineering, " +
                                 "\n 5: Electronic Systems,\n 6: RZI,\n 7: Professional study \n\n You choice: ");
                            bool chekInt = int.TryParse(Console.ReadLine(), out newSpeciality);
                            if (chekInt)
                            {
                                if (newSpeciality < 1 || newSpeciality > 7)
                                {
                                    throw new InputException();
                                }
                                break;
                            }
                            else
                                Console.WriteLine("\n You should enter a number!\n");
                        }
                        catch (InputException exception)
                        {
                            Console.WriteLine(exception.Message);
                            Console.WriteLine();
                        }
                    }
                    break;
            }

            person[number - 1].TransferSpeciality(newSpeciality);
        }
        static void Show(string info)
        {
            Console.WriteLine(info);
        }
    }
}
