using System;

namespace CSharp.Bonus.HomeWork.Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 8:
            //Write a program that will read two arrays from console input.Then the program has to make a comparison of the arrays and determine whether they are equal or not.
            //{ 1, 2, 3, 4 } == { 1, 2, 3, 4 }
            //{ 1, 2, 3, 4 } != { 2, 1, 3, 4 }

            Console.WriteLine("Enter how large the  first  array should be: ");
            bool isValidFirstInput = int.TryParse(Console.ReadLine(), out int arrLarge1);

            Console.WriteLine("Enter how large  the second  array should be: ");
            bool isValidSecondInput = int.TryParse(Console.ReadLine(), out int arrLarge2);

            if (isValidFirstInput && isValidSecondInput) 
            {
                 int[] firstArry = new int[arrLarge1];
                 int[] secondArry = new int[arrLarge2];

                Console.WriteLine("Enter a value for the indices  of first array: ");
                for (int i =0; i< firstArry.Length; i++)
                {
                    int valueForIndices = int.Parse(Console.ReadLine());
                    firstArry[i] = valueForIndices;
                    
                }

                Console.WriteLine("Enter a value for the indices of second array: ");
                for (int i =0; i< secondArry.Length; i++)
                {
                    int valueForIndices = int.Parse(Console.ReadLine());
                    secondArry[i] = valueForIndices;
                }


                if (arrLarge1 == arrLarge2)
                {
                    for(int i = 0; i < firstArry.Length; i++)
                    {
                        if (firstArry[i] == secondArry[i])
                        {
                            Console.WriteLine("The arrays are eqaul");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The arrays are not eqaul");
                            break;
                        }
                    }
                    
                }else
                {
                    Console.WriteLine("The Arrays are not equal");
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
