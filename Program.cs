using System;

namespace Polymorphism // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Student Input==========");

            String name, location;
            int age, year, average;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your location: ");
            location = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your average: ");
            average = Convert.ToInt32(Console.ReadLine());

              Student stud = new Student(name, location, age, year, average);// USING INHERITANCE

            stud.displayInfo();

            Student bsit = new BSIT("John Lester Burce", "Caloocan", 19, 2, 98); // in c# you have to put argurments no matter what
                                                                                 //using polymorphism
            
            bsit.displayInfo();
        }
    }
}
