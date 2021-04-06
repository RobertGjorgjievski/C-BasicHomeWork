using System;

namespace CSharp.Bonus.HomeWork.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //    ## Task 2:
            //Write a program that will print out all numbers in the range 1 - N(N is input from keyboard, N > 5) that divide 2 and 3.

            Console.WriteLine("Enter a number for the end of the range (1 to N)");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int parsedInput);

            if (isValidInput)
            {
                if(parsedInput > 5) 
                {
                    Console.WriteLine("The numbers divided with 2 and 3 in range from 1 to {0} are: ", parsedInput);
                     for(int i = 1; i <= parsedInput; i++)
                {
                    if(i % 2 == 0 && i % 3 == 0)
                    {
                            Console.WriteLine(i);
                    }
                }
                }
                else
                {
                    Console.WriteLine("Please enter bigger number then 5");
                }
              
            }
            else
            {
                Console.WriteLine("Please enter a number");
            }


         Console.ReadLine();
        }
    }
}
