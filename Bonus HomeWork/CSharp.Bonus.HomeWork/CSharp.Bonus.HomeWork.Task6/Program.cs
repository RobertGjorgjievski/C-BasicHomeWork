using System;

namespace CSharp.Bonus.HomeWork.Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 6:
            //Write a program that will find out the sum of all numbers that divide 5 in the range 1 - N(N is input from keyboard).

            Console.WriteLine("Enter number for the end of the range (from 1 to N)");
            bool isValitInput = int.TryParse(Console.ReadLine(), out int number);
            int sum = 0;

            if (isValitInput)
            {
                for (int i = 1; i <= number; i++)

                {
                    if (i % 5 != 0)
                    {
                        continue;
                    }
                    sum += i;

                    Console.WriteLine(i);
                }

                Console.WriteLine("The sum of all number divided 5 in range from 1 to {0} is {1}", number, sum);
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }





            Console.ReadLine();
        }
    }
}
