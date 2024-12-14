using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace app
{
    class Loop
    {
        static void Main(string[] args)
        {
            // a one-condition if/else statement (i.e. "if x == true")
            int x=25;
            if (x<200)
            {
                Console.WriteLine("Hello..");  
            }
            else
            {
                Console.WriteLine("Bye..");
            }
            //example using shorthand
            string result=(x<200)? "Hello..":"Bye..";
            Console.WriteLine(result);
            
            
            
            
            // a multi-condition if/else statement (i.e. "if x>0 && y< 10)
            Console.WriteLine("Ugh oh, I broke a vase");
            bool momMad= true;
            bool dadMad= false;
            if (momMad && dadMad)
            {
                Console.WriteLine("Run dude, you're screwed");
            }
            else if (momMad)
            {
                Console.WriteLine("Maybe we can reason with Mom, she loves us, right??");
            }
            else if (dadMad)
            {
                Console.WriteLine("If they puppy eyes don't work on Dad, we are definetly grounded.");
            }
            else
            {
                Console.WriteLine("I'm saved!");
            }


            // if/elif/else statements
            double money = 241.23;
            Console.WriteLine("Do I have enough money to buy a Playstation 5?");
            if (money >= 449.99)
            {
                Console.WriteLine("You have enough money to buy a Playstation 5!");
            }
            else if (money >= 300.00)
            {
                Console.WriteLine("Keep working hard! You're so close!");
            }
            else {
                Console.WriteLine("Ummm.. I mean you aren't close but, im sure if you keep working hard you'll have enough.");
            }
            
            // short-circuit logic
            int numOfCats=12;
            int age=30;
            // int numOfCats=10;
            // int age=10;
            if (age>=35 && numOfCats>3)
            {
                Console.WriteLine("Ummm..You are gonna be an old cat lady.");
            }
            else if (age>=25 && numOfCats>5)
            {
                Console.WriteLine("Ummm.. you are a cat lady");
            }
            else if (age<20 && numOfCats/age>1)
            {
                Console.WriteLine("Ummm..You have more cats than years in your age? What are you doing you barely even old enough to have cats");
            }
            else
            {
                Console.WriteLine("Ummm.. not gonna be an old cat lady, yet at least.");
            }
            // a switch-case statement
            int timesIveMissedClass=2;
            switch(timesIveMissedClass) 
            {
                case 0:
                    Console.WriteLine("What a teacher's pet");
                    break;
                case 1:
                    Console.WriteLine("Wow what a good student!");
                    break;
                case 2:
                    Console.WriteLine("Not badddddd");
                    break;
                case 3:
                    Console.WriteLine("Better step it up");
                    break;
                default:
                    Console.WriteLine("Ummm.. you are a HORRIBLE STUDENT");
                    break;
            }
        }
    
    }
}
