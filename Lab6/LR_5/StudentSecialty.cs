using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    class StudentSecialty : Student, IEquatable<StudentSecialty>, ISomeMethods
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
        public bool Equals(StudentSecialty nextStudent)
        {
                return (this.Course == nextStudent.Course);
        }
        public void TransferFaculty(Faculty newFaculty)
        {
            this.Faculty = newFaculty;
        }
        public void TransferSpeciality(int newSpeciality)
        {
            if (this.Faculty == Faculty.KSIS)
            {
                switch (newSpeciality)
                {
                    case 1:
                        this.Speciality = "POIT";
                        break;
                    case 2:
                        this.Speciality = "IiTP";
                        break;
                    case 3:
                        this.Speciality = "VMSiS";
                        break;
                    case 4:
                        this.Speciality = "EVS";
                        break;
                }
            }
            else if (this.Faculty == Faculty.FITY)
            {
                switch (newSpeciality)
                {
                    case 1:
                        this.Speciality = "ASOI";
                        break;
                    case 2:
                        this.Speciality = "II";
                        break;
                    case 3:
                        this.Speciality = "ITiYTS";
                        break;
                    case 4:
                        this.Speciality = "PE";
                        break;
                    case 5:
                        this.Speciality = "Game Industry";
                        break;
                }
            }
            else if (this.Faculty == Faculty.IEF)
            {
                switch (newSpeciality)
                {
                    case 1:
                        this.Speciality = "Logistics";
                        break;
                    case 2:
                        this.Speciality = "Economy";
                        break;
                    case 3:
                        this.Speciality = "Business";
                        break;
                    case 4:
                        this.Speciality = "Marketing";
                        break;
                }
            }
            else if (this.Faculty == Faculty.FKP)
            {
                switch (newSpeciality)
                {
                    case 1:
                        this.Speciality = "I-POiT";
                        break;
                    case 2:
                        this.Speciality = "ISiTOPB";
                        break;
                    case 3:
                        this.Speciality = "Med Electronic";
                        break;
                    case 4:
                        this.Speciality = "MiKPRS";
                        break;
                    case 5:
                        this.Speciality = "PMS";
                        break;
                    case 6:
                        this.Speciality = "ESB";
                        break;
                }
            }
            else if (this.Faculty == Faculty.FRE)
            {
                switch (newSpeciality)
                {
                    case 1:
                        this.Speciality = "KIS";
                        break;
                    case 2:
                        this.Speciality = "NiNE";
                        break;
                    case 3:
                        this.Speciality = "Radio Informatics";
                        break;
                    case 4:
                        this.Speciality = "Radio Engineering";
                        break;
                    case 5:
                        this.Speciality = "Electronic Systems";
                        break;
                    case 6:
                        this.Speciality = "RZI";
                        break;
                    case 7:
                        this.Speciality = "Professional study";
                        break;
                }
            }
        }
        public bool PositiveAverageMark()
        {
            return (this.AvarageMark >= 4);
        }
        public override void SelectData(int intData)
        {
            switch (intData)
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
                    Console.WriteLine($" All data of student: \n Name: {Name} \n Surname: {Surname}" +
                        $" \n Age: {Age} \n Weight: {Weight} \n Height: {Height} \n Id: {PersonID}" +
                        $" \n Course: {Course} \n Faculty: {Faculty} \n Speciality: {Speciality}" +
                        $" \n Skipping hours: {SkippingHours} \n Avarage mark: {AvarageMark}" +
                        $" \n Live place: {Info.LivePlace} \n Study cost: {Info.StudyCost} \n Favorite subject: {Info.FavoriteSubject}");
                    break;
            }
        }
    }
}
