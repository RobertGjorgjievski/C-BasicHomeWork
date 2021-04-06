using System;

namespace CSharp.Bonus.HomeWork.Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 3:
            //Write a program, which will be calculating the product of the digits of an input number.

            Console.WriteLine("Enter any  number");
            bool isValid = int.TryParse(Console.ReadLine(), out int parsedInput);

            int product = 1;

            if (isValid)
            {
                if(parsedInput == 0)
                {
                    product = 0;
                }

                while(parsedInput != 0)
                {
                    product = product * (parsedInput % 10);
                    parsedInput = parsedInput / 10;
                }
                Console.Write("The product of digits is: " + product);
            }
            else 
            {
                Console.WriteLine("Please enter a number");
            }


         Console.ReadLine();
        }
    }
}
