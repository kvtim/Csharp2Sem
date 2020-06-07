using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    delegate bool AvarageMark(StudentSecialty student);
    delegate void Add(ref StudentSecialty[] person);
    delegate void AddMessage(string newStudent);

    class StudentSecialty : Student, IEquatable<StudentSecialty>, IActionsWithStudents
    {
        public event AddMessage AddStudent;

        private StudentInfo Info = new StudentInfo();
        public string Speciality { get; set; }
        public int SkippingHours { get; set; }
        public double AvarageMark { get; set; }
        public StudentSecialty(int age, string name, string surname, int weight,
          int height, int course, Faculty Faculty, string speciality, int skippingHours, double avarageMark,
          string livePlace, int studyCost, string favoriteSubject)
          : base(age, name, surname, weight, height, course, Faculty)
        {
            this.Speciality = speciality;
            this.SkippingHours = skippingHours;
            this.AvarageMark = avarageMark;
            this.Info.LivePlace = livePlace;
            this.Info.StudyCost = studyCost;
            this.Info.FavoriteSubject = favoriteSubject;
        }

       static public AvarageMark allAvarageMark = (StudentSecialty student) => student.AvarageMark > 4;

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
            ShowOrTransfer transfer = new ShowOrTransfer(NewSpeciality);

            if (this.Faculty == Faculty.KSIS)
            {
                switch (newSpeciality)
                {
                    case 1:
                        transfer.Invoke("POIT");
                        break;
                    case 2:
                        transfer.Invoke("IiTP");
                        break;
                    case 3:
                        transfer.Invoke("VMSiS");
                        break;
                    case 4:
                        transfer.Invoke("EVS");
                        break;
                }
            }
            else if (this.Faculty == Faculty.FITY)
            {
                switch (newSpeciality)
                {
                    case 1:
                        transfer.Invoke("ASOI");
                        break;
                    case 2:
                        transfer.Invoke("II");
                        break;
                    case 3:
                        transfer.Invoke("ITiYTS");
                        break;
                    case 4:
                        transfer.Invoke("PE");
                        break;
                    case 5:
                        transfer.Invoke("Game Industry");
                        break;
                }
            }
            else if (this.Faculty == Faculty.IEF)
            {
                switch (newSpeciality)
                {
                    case 1:
                        transfer.Invoke("Logistics");
                        break;
                    case 2:
                        transfer.Invoke("Economy");
                        break;
                    case 3:
                        transfer.Invoke("Business");
                        break;
                    case 4:
                        transfer.Invoke("Marketing");
                        break;
                }
            }
            else if (this.Faculty == Faculty.FKP)
            {
                switch (newSpeciality)
                {
                    case 1:
                        transfer.Invoke("I-POiT");
                        break;
                    case 2:
                        transfer.Invoke("ISiTOPB");
                        break;
                    case 3:
                        transfer.Invoke("Med Electronic");
                        break;
                    case 4:
                        transfer.Invoke("MiKPRS");
                        break;
                    case 5:
                        transfer.Invoke("PMS");
                        break;
                    case 6:
                        transfer.Invoke("ESB");
                        break;
                }
            }
            else if (this.Faculty == Faculty.FRE)
            {
                switch (newSpeciality)
                {
                    case 1:
                        transfer.Invoke("KIS");
                        break;
                    case 2:
                        transfer.Invoke("NiNE");
                        break;
                    case 3:
                        transfer.Invoke("Radio Informatics");
                        break;
                    case 4:
                        transfer.Invoke("Radio Engineering");
                        break;
                    case 5:
                        transfer.Invoke("Electronic Systems");
                        break;
                    case 6:
                        transfer.Invoke("RZI");
                        break;
                    case 7:
                        transfer.Invoke("Professional study");
                        break;
                }
            }
        }
        public void NewSpeciality(string newSpeciality)
        {
            this.Speciality = newSpeciality;
        }
        public override void SelectData(int intData, ShowOrTransfer info)
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
                case 4:
                    info(string.Format($" Course: {Course}"));
                    break;
                case 5:
                    info(string.Format($" Faculty: {Faculty} "));
                    break;
                case 6:
                    info(string.Format($" Speciality: {Speciality} "));
                    break;
                case 7:
                    info(string.Format($" Skipping hours: {SkippingHours} "));
                    break;
                case 8:
                    info(string.Format($" Avarage mark: {AvarageMark} "));
                    break;
                case 9:
                    info(string.Format($" Live place: {Info.LivePlace} "));
                    break;
                case 10:
                    info(string.Format($" Study cost: {Info.StudyCost} "));
                    break;
                case 11:
                    info(string.Format($" Favorite subject: {Info.FavoriteSubject} "));
                    break;
                case 12:
                    info(string.Format($" All data of student: \n Name: {Name} \n Surname: {Surname}" +
                        $" \n Age: {Age} \n Weight: {Weight} \n Height: {Height} \n Id: {PersonID}" +
                        $" \n Course: {Course} \n Faculty: {Faculty} \n Speciality: {Speciality}" +
                        $" \n Skipping hours: {SkippingHours} \n Avarage mark: {AvarageMark}" +
                        $" \n Live place: {Info.LivePlace} \n Study cost: {Info.StudyCost} \n Favorite subject: {Info.FavoriteSubject}"));
                    break;
            }
        }
        public void DoAdding(string message)
        {
            if (AddStudent != null)
                AddStudent(message);
        }
    }
}
