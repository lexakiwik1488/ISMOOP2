using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP2
{
    public class Person
    {
        private string  firstname;
        protected string FirstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
            }
        }
        private string lastname;
        protected string LastName
        {
            get { return lastname;}
            set { lastname = value; }
        }
        protected string Date;
        public Person()
        {
            firstname = "Oleksii";
            lastname = "Kozak";
            Date = "03.12.2020";
        }
        public Person(string firstname, string lastname, string date)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            Date = date;
        }
        public Person(string date)
        {
            firstname = "Oleksii";
            lastname = "Kozak";
            Date = date;
        }

        public void SetFirstName(string firstname)
        {
            this.firstname = firstname;
        }
        public void SetLasName(string lastname)
        {
            this.lastname = lastname;
        }
        public void SetDate(string date)
        {
            Date = date;
        }

        public string GetLastName()
        {
            return LastName;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetDate()
        {
            return Date;
        }

        public string ShowFirstName()
        {
            return $"{firstname}";
        }
        public string ShowLastName()
        {
            return $"{lastname}";
        }
        public string ShowDate()
        {
            return $"{Date}";
        }

        public  string ShowInfo()
        {
            return $"{firstname} {lastname} {Date}";
        }
    }

    public class Matriculant : Person
    {
        private int znoPoints;
        protected int ZnoPoints
        {
            get { return znoPoints; }
            set
            {
                if (value > 0 && value <= 200)
                    znoPoints = value;
                else
                    Console.WriteLine("Ввідеть коректний бал...");
            }
        }
        private int educationPoints;
        protected int EducationPoints
        {
            get { return educationPoints; }
            set
            {
                if (value <= 12 && value > 0)
                    educationPoints = value;
                else
                    Console.WriteLine("Ввідеть коректний бал...");
            }
        }

        private string secondarySchoolName;
        public string SecondarySchoolName
        {
            get { return secondarySchoolName; }
            set { secondarySchoolName = value; }
        }

        public Matriculant()
            :base()
        {
            znoPoints = 200;
            educationPoints = 12;
            secondarySchoolName = "Киевская школа 93";
        }
        public Matriculant(string firtname, string lastname, string date, int znoPoints, 
            int educationPoints, string secondarySchoolName)
            : base(firtname, lastname, date)
        {
            this.znoPoints = znoPoints;
            this.educationPoints = educationPoints;
            this.secondarySchoolName = secondarySchoolName;
        }

        public void SetZnoPoints(int znoPoints)
        {
            this.znoPoints = znoPoints;
        }
        public void SetEducationPoints(int educationPoints)
        {
            this.educationPoints = educationPoints;
        }
        public void SetSchoolName(string schoolName)
        {
            secondarySchoolName = schoolName;
        }

        public int GetZnoPoints()
        {
            return znoPoints;
        }
        public int GetEducationPoints()
        {
            return educationPoints;
        }
        public string GetSchoolname()
        {
            return secondarySchoolName;
        }

        public void ShowZnoPoints()
        {
            Console.WriteLine($"{ZnoPoints}");
        }
        public void ShowEducationPoints()
        {
            Console.WriteLine($"{EducationPoints}");
        }
        public void ShowSchoolName()
        {
            Console.WriteLine($"{secondarySchoolName}");
        }
        public new string ShowInfo()
        {
            return $"{FirstName} {LastName} {Date} {znoPoints} {educationPoints} {secondarySchoolName}";
        }
    }

    public class Student : Person
    {
        private int course;
        public int Course
        {
            get { return course; }
            set
            {
                if (value <= 5 && value > 0)
                    course = value;
                else
                    Console.WriteLine("Введіть коректний курс...");
            }
        }
        private string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        private string faculty;
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        private string educationPlace;
        public string EduccationPlace
        {
            get { return educationPlace; }
            set { educationPlace = value; }
        }

        public Student()
            :base()
        {
            course = 2;
            Group = "15БД-ПОкпт";
            faculty = "Фіз-мат";
            educationPlace = "ЖДУ";
        }

        public Student(string date, int course, string group, string faculty, string educationPlace)
            :base(date)
        {
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.educationPlace = educationPlace;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }
        public void SetGroup(string group)
        {
            this.group = group;
        }
        public void SetFaculty(string faculty)
        {
            this.faculty = faculty;
        }
        public void SetPlace(string educationPlace)
        {
            this.educationPlace = educationPlace;
        }

        public int GetCourse()
        {
            return course;
        }
        public string GetGroup()
        {
            return group;
        }
        public string GetFaculty()
        {
            return faculty;
        }
        public string GetPlace()
        {
            return educationPlace;
        }

        public new string ShowInfo()
        {
            return $"{FirstName} {LastName} {Course} {Group} {Faculty} {EduccationPlace}";
        }
    }
    public class Coucher : Person
    {
        protected string Position { get; set; }
        protected string Cathedra { get; set; }
        protected string EducationPlace { get; set; }

        public Coucher()
            :base()
        {
            Position = "Декан";
            Cathedra = "Фізико-математична";
            EducationPlace = "ЖДУ Франка";
        }
        public Coucher(string firstname,string lastname,string date,
            string position,string cathedra,string educatioplace)
            :base(firstname,lastname,date)
        {
            Position = position;
            Cathedra = cathedra;
            EducationPlace = educatioplace;
        }

        public void SetPosition(string position) { Position = position; }
        public void SetCathedra(string cathedra) { Cathedra = cathedra; }
        public void SetEducationPlace(string place) { EducationPlace = place; }

        public string GetPosition() { return Position; }
        public string GetCathedra() { return Cathedra; }
        public string GetEducationPlace() { return EducationPlace; }

        public new string ShowInfo()
        {
            return $"{FirstName} {LastName} {Date} {Position} {Cathedra} {EducationPlace}";
        }
    }

    public class LibraryUser : Person
    {
        protected int Id { get; set; }
        protected string IssueDate { get; set; }
        protected double MounthFee { get; set; }

        public LibraryUser()
            :base()
        {
            Id = 1;
            IssueDate = "01.12.2020";
            MounthFee = 120;
        }

        public LibraryUser(string firstname,string lastname,
            string date,int id,string issuedate,double mounthfee)
            :base(firstname,lastname,date)
        {
            this.Id = id;
            IssueDate = issuedate;
            MounthFee = mounthfee;
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public void SetIssueDate(string issueDate)
        {
            IssueDate = issueDate;
        }
        public void SetMounthFee(double mounthFee)
        {
            MounthFee = mounthFee;
        }

        public int GetId() { return Id; }
        public string GetIssueDate() { return IssueDate; }
        public double GetMounthFee() { return MounthFee; }

        public new string ShowInfo()
        {
            return $"{FirstName} {LastName} {Date} {Id} {IssueDate} {MounthFee}";
        }

    }
}
