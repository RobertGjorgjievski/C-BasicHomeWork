using System;

namespace CSharp.Bonus.HomeWork.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1: 
            //Write a program that will print out all numbers from the range 1 - N(N is input from keyboard, N > 2) that divide with 3.

            Console.WriteLine("Enter number for the  end of the range (1 to N )");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int parsedInput);
            if (isValidInput)
            {
               
                if (parsedInput > 2)
                    
                {
                    Console.WriteLine("The numbers divided with 3 in range from 1 to {0} are: ", parsedInput);
                    for (int i = 1; i <= parsedInput; i++)
                    {
                        if(i % 3 == 0)
                        {
                           
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please entre bigger number then 2");
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
