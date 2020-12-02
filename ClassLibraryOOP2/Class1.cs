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

        private int age;
        protected int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    Console.WriteLine("Введіть коректний вік...");
            }
        }
        public Person()
        {
            firstname = "Oleksii";
            lastname = "Kozak";
            age=18;
        }
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public Person(int age)
        {
            firstname = "Oleksii";
            lastname = "Kozak";
            this.age = age;
        }

        public void SetFirstName(string firstname)
        {
            this.firstname = firstname;
        }
        public void SetLasName(string lastname)
        {
            this.lastname = lastname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetLastName()
        {
            return LastName;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public int GetAge()
        {
            return Age;
        }

        public string ShowFirstName()
        {
            return $"{firstname}";
        }
        public string ShowLastName()
        {
            return $"{lastname}";
        }
        public string ShowAge()
        {
            return $"{age}";
        }

        public  string ShowInfo()
        {
            return $"{firstname} {lastname} {age}";
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
        public Matriculant(string firtname, string lastname, int age, int znoPoints, 
            int educationPoints, string secondarySchoolName)
            : base(firtname, lastname, age)
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
            return $"{FirstName} {LastName} {Age} {znoPoints} {educationPoints} {secondarySchoolName}";
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

        public Student(int age, int course, string group, string faculty, string educationPlace)
            :base(age)
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
        public Coucher(string firstname,string lastname,int age,
            string position,string cathedra,string educatioplace)
            :base(firstname,lastname,age)
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
            return $"{FirstName} {LastName} {Age} {Position} {Cathedra} {EducationPlace}";
        }
    }

    public class LibraryUser : Person
    {
        protected int id { get; set; }
        protected string issueDate { get; set; }
        protected double mounthFee { get; set; }

        public LibraryUser()
            :base()
        {
            id = 1;
            issueDate = "01.12.2020";
            mounthFee = 120;
        }

        public LibraryUser(string firstname,string lastname,
            int age,int id,string issuedate,double mounthfee)
            :base(firstname,lastname,age)
        {
            this.id = id;
            issueDate = issuedate;
            mounthFee = mounthfee;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetIssueDate(string issueDate)
        {
            this.issueDate = issueDate;
        }
        public void SetMounthFee(double mounthFee)
        {
            this.mounthFee = mounthFee;
        }

        public int GetId() { return id; }
        public string GetIssueDate() { return issueDate; }
        public double GetMounthFee() { return mounthFee; }

        public new string ShowInfo()
        {
            return $"{FirstName} {LastName} {Age} {id} {issueDate} {mounthFee}";
        }

    }
}
