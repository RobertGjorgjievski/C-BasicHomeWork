using System;

namespace CSharp.HomeWork.Class2.Zadaca3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*## Task 3:
            Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so
            that the first variable has the second value and the second variable the first value.

          Please find example below:
            *Test Data:
            *Input the First Number: 5
            * Input the Second Number: 8
            * Expected Output:
            *After Swapping:
            *First Number: 8
            * Second Number: 5
            b b */

            Console.Write("Enter the first number: ");
                 string inputOne = Console.ReadLine();

            Console.Write("Enter the second number:  ");
                 string inputTwo = Console.ReadLine();

            string temp = inputOne;
            inputOne = inputTwo;
            inputTwo = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + inputOne);
            Console.WriteLine("Second Number: " + inputTwo);
                
            Console.ReadLine();
        }
    }
}
