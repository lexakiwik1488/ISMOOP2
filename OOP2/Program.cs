using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOOP2;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Person person = new Person("Lexa", "Kozak", 34);
            //Console.WriteLine(person.ShowLastName());
            Console.Write("Вміст об'єкта классу Person: ");
            Console.WriteLine(person.ShowInfo());

            Matriculant matriculant = new Matriculant();
            Console.Write("Вміст об'єкта классу Marticulant: ");
            Console.WriteLine(matriculant.ShowInfo());
            //matriculant.ShowZnoPoints();

            Student student = new Student(18, 2, "14HT", "fiz-mat", "Zhytomyr");
            Console.Write("Вміст об'єкта классу Student: ");
            Console.WriteLine(student.ShowInfo());
            //Console.WriteLine(student.GetFirstName());

            Coucher coucher = new Coucher();
            Console.Write("Вміст об'єкта классу Coucher: ");
            Console.WriteLine(coucher.ShowInfo());

            LibraryUser libraryUser = new LibraryUser();
            Console.Write("Вміст об'єкта классу LibraryUser: ");
            Console.WriteLine(libraryUser.ShowInfo());
        }
    }
}
