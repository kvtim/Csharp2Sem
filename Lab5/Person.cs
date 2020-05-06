using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int PersonID { get; set; }

        static private int id = 100;
        public Person(int age, string name, string surname, int weight, int height)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.Weight = weight;
            this.Height = height;
            Person.id += 1;
            this.PersonID = Person.id;

        }
        public virtual void SelectData(int b)
        {
    switch (b)
            {
                case 0:
                    Console.WriteLine($" Age: {Age}");
                    break;
                case 1:
                    Console.WriteLine($" Weight: {Weight}");
                    break;
                case 2:
                    Console.WriteLine($" Height: {Height}");
                    break;
                case 3:
                    Console.WriteLine($" Id: {PersonID}");
                    break;
            }
        }

        public void SelectData(string a)
        {
            switch (a)
            {
                case "Surname":
                    Console.WriteLine($" Surname: {Surname}");
                    break;
                case "Name":
                    Console.WriteLine($" Name: {Name}");
                    break;
            }
        } 

    }
}

