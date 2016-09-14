//Create a method named "Double" to calculate and return an integer 
//number doubled. For example. Double(7) should return 14.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeProblems_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int userInputNumber;
            int doubledNumber;

            //ask user for a number to be doubled.
            Console.WriteLine("Please provide a number to be doubled.");
            userInputNumber = int.Parse(Console.ReadLine());

            //calls the Double method and prints it's return value
            doubledNumber = Double(userInputNumber);
            Console.WriteLine(doubledNumber);
        }

        //method to double provided number.
        static int Double(int originalNumber)
        {
            int doubled;
            int multiplier = 2;

            doubled = originalNumber * multiplier;
            return doubled;
        }
    }
}
