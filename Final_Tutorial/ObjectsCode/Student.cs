// In your programming language, do the following (or explain why it can’t be done as described):

// Create an object (a simple Person or Date object is fine)
// Give the object class attributes (aka instance variables)
// Give the object functions
// Create an object that inherits from the first object (e.g., Student or Appointment) with some attributes and functions of its own
// Test how to instantiate both types of objects, call their functions, and modify their variables.

using System.Security.Cryptography;

namespace app
{
    class Student : Person 
    {
        public string school;
        public int grade;
        public Student(string name, double age, string s, int g):base(name, age)
        {
            school = s;
            grade = g;
        }
    }
}

            

