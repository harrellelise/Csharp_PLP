using System;

namespace app
{
    class PerChiProgram
    {
        static void Main(string[] args)
        {
            Person myPerson= new Person("Elise", 16);
            myPerson.Birthday();
            myPerson.AgeUp();
            myPerson.name="Liam";
            myPerson.age=24;
            myPerson.AgeUp();

            Student myStudent= new Student("Harry", 12, "Academy", 5);
            myStudent.Birthday();
            myStudent.AgeUp();
            myStudent.name="Colin";
            myStudent.age=14;
            myStudent.AgeUp();

        }
    }
}