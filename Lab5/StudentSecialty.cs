using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    class StudentSecialty : Student
    {
        private StudentInfo Info = new StudentInfo();
        public string Speciality { get; set; }
        public int SkippingHours { get; set; }
        public double AvarageMark { get; set; }

        public StudentSecialty(int age, string name, string surname, int weight,
          int height, int course, faculty faculty, string speciality, int skippingHours, double avarageMark,
          string livePlace, int studyCost, string favoriteSubject)
          : base(age, name, surname, weight, height, course, faculty)
        {
            this.Speciality = speciality;
            this.SkippingHours = skippingHours;
            this.AvarageMark = avarageMark;
            this.Info.LivePlace = livePlace;
            this.Info.StudyCost = studyCost;
            this.Info.FavoriteSubject = favoriteSubject;
        }
        public override void SelectData(int b)
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
                case 4:
                    Console.WriteLine($" Course: {Course}");
                    break;
                case 5:
                    Console.WriteLine($" Faculty: {Faculty} ");
                    break;
                case 6:
                    Console.WriteLine($" Speciality: {Speciality} ");
                    break;
                case 7:
                    Console.WriteLine($" Skipping hours: {SkippingHours} ");
                    break;
                case 8:
                    Console.WriteLine($" Avarage mark: {AvarageMark} ");
                    break;
                case 9:
                    Console.WriteLine($" Live place: {Info.LivePlace} ");
                    break;
                case 10:
                    Console.WriteLine($" Study cost: {Info.StudyCost} ");
                    break;
                case 11:
                    Console.WriteLine($" Favorite subject: {Info.FavoriteSubject} ");
                    break;
                case 12:
                    Console.WriteLine($" All data of 1 person: \n Name: {Name} \n Surname: {Surname}" +
                        $" \n Age: {Age} \n Weight: {Weight} \n Height: {Height} \n Id: {PersonID}" +
                        $" \n Course: {Course} \n Faculty: {Faculty} \n Speciality: {Speciality}" +
                        $" \n Skipping hours: {SkippingHours} \n Avarage mark: {AvarageMark}" +
                        $" \n Live place: {Info.LivePlace} \n Study cost: {Info.StudyCost} \n Favorite subject: {Info.FavoriteSubject}");
                    break;
            }
        }
    }
}
