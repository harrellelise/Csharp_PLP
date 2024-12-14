// See https://aka.ms/new-console-template for more information
using System;

namespace app
{
    class Variables
    {
        static void Main(string[] args)
        {
            int num_class; //variables don't always need a value
            string myName = "Elise Harrell";
            bool current_student = true;
            double gpa = 3.87;
            int credits = 84, cred_per_class = 4; //can declare multiple variables of the same type in one line
            num_class = credits / cred_per_class;

            Console.WriteLine("Name: " + myName + " GPA: " + gpa);
            Console.WriteLine("Current Student: " + current_student);
            Console.WriteLine("Number of Classes Taken: " + num_class);

            List <string> classes = new List<string> ();
            classes.Add("CS 110");
            classes.Add("CS 112");
            classes.Add("CS 235");
            classes.Add("CS 330");
            // classes.Add(5);
            Console.WriteLine("Classes:");
            for(int i=0;i<classes.Count;i++)
            {
            Console.WriteLine(classes[i]);
            }

            int fun_num= 20;
            double unfun_num=3.0;
            double num= fun_num/ unfun_num;
            Console.WriteLine("num: " + num);
        }
    }
}
