// In your programming language, do the following (or explain why it can’t be done as described):

// Create an object (a simple Person or Date object is fine) **
// Give the object class attributes (aka instance variables) **
// Give the object functions **
// Create an object that inherits from the first object (e.g., Student or Appointment) with some attributes and functions of its own
// Test how to instantiate both types of objects, call their functions, and modify their variables.

using System.Security.Cryptography.X509Certificates;

namespace app
{    class Person
    {
        // private string name;
        // public string Name{
        // get { return name; }
        // set { name = value; }
        // }
    
        // private double age; 
        // public double Age{
        // get { return age; }
        // set { age = value; }    
        // }
        public double age; 
        public string name;
        public Person(string n, double a){
            name=n;
            age=a;
        }
        public void Birthday(){
            Console.WriteLine("You turn 21 in: " + (21-age) +" Years!");
            Console.WriteLine("Congrats " + name +"!");
        }
        public void AgeUp(){
            age+=1;
            Console.WriteLine("Hi " + name + ", you are now " + age + " years old.");
        }

        public void Print(){
            Console.WriteLine( name + " " + age);
        }
    }
}

            

