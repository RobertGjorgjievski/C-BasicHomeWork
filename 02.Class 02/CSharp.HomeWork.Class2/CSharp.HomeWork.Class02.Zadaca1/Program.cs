using System;

namespace CSharp.HomeWork.Class02.Zadaca1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*## Task 1
            Create new console application “RealCalculator” that takes two numbers
                from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
           * Test Data:
             *Enter the First number: 10
             * Enter the Second number: 15
             * Enter the Operation: +
             *Expected Output:
            *The result is: 25*/

            Console.Write("Enter the first number: ");
            string  inputNumber1= Console.ReadLine();
            int inputNumber1Parse;
            bool isConverted = int.TryParse(inputNumber1, out inputNumber1Parse);
            

            Console.Write("Enter the second number: ");
            string inputNumber2 = Console.ReadLine();
            bool isConverted2 = int.TryParse(inputNumber2, out int inputNumber2Parse);

            Console.Write("Enter the operator: ");
            string inputOperator = Console.ReadLine();

                if (inputOperator == "+")
            {
                int result = inputNumber1Parse + inputNumber2Parse;
                Console.WriteLine("The result is:  " + result);
            }
                else if (inputOperator == "-")
            {
                int result = inputNumber1Parse - inputNumber2Parse;
                Console.WriteLine("The result is: " + result);
            }
                else if(inputOperator == "*")
            {
                int result = inputNumber1Parse * inputNumber2Parse;
                Console.WriteLine("The result is: " + result);
            }
                else if (inputOperator == "/" && inputNumber2Parse != 0)
                {
                int result = inputNumber1Parse / inputNumber2Parse;
                Console.WriteLine("The result is: " + result);
            }
             
            else if (inputOperator == "/" && inputNumber2Parse == 0)
            {
                Console.WriteLine("It is not divisible by zero");
            }
                else
            {
                Console.WriteLine("Invalid Operator");
            }



            Console.ReadLine();
        }
    }
}
