using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    public delegate void ShowOrTransfer(string info);
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
        public virtual void SelectData(int intData, ShowOrTransfer info)
        {
            switch (intData)
            {
                case 0:
                    info(string.Format($" Age: {Age}"));
                    break;
                case 1:
                    info(string.Format($" Weight: {Weight}"));
                    break;
                case 2:
                    info(string.Format($" Height: {Height}"));
                    break;
                case 3:
                    info(string.Format($" Id: {PersonID}"));
                    break;
            }
        }

        public void SelectData(string stringData, ShowOrTransfer info)
        {
            switch (stringData)
            {
                case "Surname":
                    info(string.Format($" Surname: {Surname}"));
                    break;
                case "Name":
                    info(string.Format($" Name: {Name}"));
                    break;
            }
        }

    }
}

