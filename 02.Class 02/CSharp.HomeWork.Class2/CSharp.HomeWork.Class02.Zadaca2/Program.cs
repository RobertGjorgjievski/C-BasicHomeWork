using System;

namespace CSharp.HomeWork.Class02.Zadaca2
{
    class Program
    {
        static void Main(string[] args)
        {


            /*## Task 2
                        Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            *Test Data:
                        *Enter the First number: 10
                       * Enter the Second number: 15
                       * Enter the third number: 20
                       * Enter the four number: 30
                     * Expected Output:
                        *The average of 10, 15, 20 and 30 is: 18*/

            Console.Write("Enter the first number: ");
            string inputFirstNumber = Console.ReadLine();
                int.TryParse(inputFirstNumber, out int firsNumber);
    
            Console.Write("Enter the second number: ");
            string inputSecondNumber = Console.ReadLine();
                int.TryParse(inputSecondNumber, out int secondNumber);

            Console.Write("Enter the third number: ");
            string inputThirdNumber = Console.ReadLine();
                int.TryParse(inputThirdNumber, out int thirdNumber);

            Console.Write("Enter the four number: ");
            string inputFourNumber = Console.ReadLine();
                int.TryParse(inputFourNumber, out int fourNumber);

            int averageNumber = (firsNumber + secondNumber + thirdNumber + fourNumber) / 4;
            Console.WriteLine("The average of " + firsNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourNumber + " is: " + averageNumber);






            Console.ReadLine();
        }
    }
}
