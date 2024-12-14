// Write a function that takes in two numbers, multiplies them, and returns the output
// Write a recursive function (one that calculates a factorial is fine)
// Write a function that takes in a string (or your language's equivalent) and splits it into two strings, then returns both strings
// Call your functions and save the results of the function calls in variables.
// Write a function that tests whether your language is pass-by-reference or pass-by-value.

using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;

namespace app
{
    class Functions
    {
        static void Main(string[] args)
        {
            int num1=10;
            int num2=3;
            int result1 = Multiply(num1, num2);
            Console.WriteLine(num1 + " * " + num2 + " = " + result1);
            int result2 = Factorial(num1);
            Console.WriteLine("Factorial of " + num1+ " is " + result2);
            String line="HappyBirthday";
            var (result3, result4)=SplitString(line);
            Console.WriteLine("First: "+ result3 +" Second: " + result4);
            int num=5;
            Test(num);
            Console.WriteLine($"After Test: {num}");
        }

        private static int Multiply(int num1,int num2)
        {
            int num3 = num1 * num2;
            return(num3);
        }
        private static int Factorial(int num)
        {
            if (num<=1)
                return 1;
            return num*Factorial(num-1);
        }

        private static (string, string) SplitString(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return(string.Empty, string.Empty);
            }

            int midIndex = input.Length / 2;
            string first=input[..midIndex];
            string second=input[midIndex..];

            return(first, second);
        }
        private static void Test(int num)
        {
            num=20;
            Console.WriteLine($"Inside Test: {num}");
        }
    
    }
}

          
