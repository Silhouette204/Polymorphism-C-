using System;

namespace Polymorphism 
{
    public class Student
    {
        private string name, location;
        private int age, year, average;

        public Student(string name, string location, int age, int year, int average){
          this.name = name;
          this.age = age;
          this.location = location;
          this.year = year;
          this.average = average;
        }

      public string getName(){
        return name;
      }

      public string getlocation(){
        return location;  
      }

      public int getAge(){
        return age;
      }

      public int getYear(){
        return year;
      }

      public int getAverage(){
        return average;
      }

        virtual public void displayInfo() // virtual is like the main input and taga link sa mga iinherit nyang class and override is babaguhin yung input nya sa kanyang class or magiging independent na siya hindi na siya tulad kay parent class XD
        {
            Console.WriteLine("==========New Information==========");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Average: " + average);
        }
    }
}


