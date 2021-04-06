using System;

namespace CSharp.Bonus.HomeWork.Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 7:
            //Write a program that will reverse the array {“a”,”b”,”c”,”d”}
            //so that the output is {“d”,“c”,“b”,“a”}.
            // -Do NOT use reverse array method:) 

            string[] myArray = new string[] { "a", "b", "c", "d" };
            string[] newArray = new string[4];



            for (int i = myArray.Length - 1; i >= 0; --i)
            { 
                Console.Write(myArray[i]+" ");
            }
     
            

            Console.ReadLine();
        }
    }
}
