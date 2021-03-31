using System;

namespace CSharp.HomeWork.Class03.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 SumOfEvents
            //## Task 1
            //            Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:
            //*Test Data:
            //            *Enter integer no.1:
            //    *4
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *7
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *2
            //  * Enter integer no.1:
            //    *8
            //* Expected Output:
            //            *The result is: 14
            #endregion

            int[] intArray = new int[6];
            int sumOfEven = 0;

            Console.WriteLine("Enter integer no.1: ");
             string input1 = Console.ReadLine();
             bool isParsed1 =   int.TryParse(input1 , out int parsedInput1);

            if (isParsed1)
            {
                intArray[0] = parsedInput1; 
            }

            Console.WriteLine("Enter integer no.2:");
             string input2 = Console.ReadLine();
             bool isParsed2 = int.TryParse(input2, out int parsedInput2);

            if (isParsed2)
            {
                intArray[1] = parsedInput2;
            }

            Console.WriteLine("Enter integer no.3: ");
            string input3 = Console.ReadLine();
            bool isParsed3 = int.TryParse(input3, out int parsedInput3);

            if (isParsed3)
            {
                intArray[2] = parsedInput3;
            }

            Console.WriteLine("Enter integer no.4: ");
            string input4 = Console.ReadLine();
            bool isParsed4 = int.TryParse(input4, out int parsedInput4);
            if (isParsed4)
            {
                intArray[3] = parsedInput4;
            }

            Console.WriteLine("Enter integr no.5: ");
            string input5 = Console.ReadLine();
            bool isParsed5 = int.TryParse(input5, out int parsedInput5);
            if (isParsed5)
            {
                intArray[4] = parsedInput5;
            }

            Console.WriteLine("Enter integer no.6: ");
            string input6 = Console.ReadLine();
            bool isParsed6 = int.TryParse(input6, out int parsedInput6);
            if (isParsed6)
            {
                intArray[5] = parsedInput6;
            }

             for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sumOfEven = sumOfEven + intArray[i];
                }
            }
            Console.WriteLine("Sum of even numbers  is {0}",sumOfEven);
            
            Console.ReadLine();
        }
    }
}
