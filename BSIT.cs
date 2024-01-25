using System;
namespace Polymorphism {
public class BSIT : Student  
{

   public BSIT(string name, string location, int age, int year, int average) // in creating a constructor use this. like in super class in java
            : base(name, location, age, year, average)
        { 
            // Additional initialization for BSIT class, if needed
       }
       
     override public void displayInfo(){  // override sa c# is mag kasama katabi ng methods unlike sa java magkahiwalay
      Console.WriteLine("==========Recent Information==========");
      Console.WriteLine("Name: John Lester Burce");
      Console.WriteLine("Age: 19");
      Console.WriteLine("Location: Caloocan");
      Console.WriteLine("Year: 2");
      Console.WriteLine("Average: 98");
      }
  
       }
}
 
