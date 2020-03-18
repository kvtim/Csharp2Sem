using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Person person1 = new Person(18, "Egor", "Shirko", 49, 205);
                Console.Write(" Select the data of 1 person: Name or Surname: ");
                string StringData1 = Console.ReadLine();
                person1.SelectData(StringData1);
                Console.WriteLine(" Select the data of 1 person: \n 0: Age; \n 1: Weight; \n 2: Height; \n 3: Id; ");
                int IntData1 = Convert.ToInt32(Console.ReadLine());
                person1.SelectData(IntData1);
                Console.WriteLine(" Go to next person Yes or No: ");
                string b = Console.ReadLine();
                if (b == "Yes")
                    break;
            }
            while (true)
            {
                Person person2 = new Person(20, "Kirill", "Rogov", 33, 170);
                Console.Write(" Select the data of 2 person: Name or Surname: ");
                string StringData2 = Console.ReadLine();
                person2.SelectData(StringData2);
                Console.WriteLine(" Select the data of 2 person: \n 0: Age; \n 1: Weight; \n 2: Height; \n 3: Id; ");
                int IntData2 = Convert.ToInt32(Console.ReadLine());
                person2.SelectData(IntData2);
                Console.WriteLine(" Quit the program? Yes or No: ");
                string d = Console.ReadLine();
                if (d == "Yes")
                    break;
            }

        }
    }
}
