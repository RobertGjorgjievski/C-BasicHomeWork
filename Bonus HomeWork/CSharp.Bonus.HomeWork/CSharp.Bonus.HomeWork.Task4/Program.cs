using System;

namespace CSharp.Bonus.HomeWork.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 4:
            //Write a program that will find out the sum of all even numbers in the range 1 - N(N is input from keyboard).

            Console.WriteLine("Enter number for the end of the range (from 1 to N)");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            int sum = 0;

            if (isValid)
            {
                for(int i = 1; i <= number; i++)
                {
                    if(i % 2 != 0)
                    {
                        continue;
                    }
                     sum += i;
                   
                }
                Console.WriteLine("The sum of all even number in range from 1 to {0} is: {1} ",number,sum);
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }



         Console.ReadLine();
        }
    }
}
