using System;

namespace CSharp.HomeWork.Class03.StudentGrup
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2
            //            *Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //*Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //* Test Data:
            //            *Enter student group: (there are 1 and 2 )
            //    *1
            //* Expected Output:
            //            *The Students in G1 are: 
            //  *Zdravko
            //  * Petko
            //  * Stanko
            //  * Branko
            //  * Trajko
            #endregion

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Darko", "Marko", "Sharko", "Stevko", "Ratko" };
            Console.WriteLine("Enter the student grup: (ther is 1 and 2 )");
            bool isParsed = int.TryParse(Console.ReadLine(),out int parsed);
            
            if (isParsed)
            {
                    if(parsed == 1)
                    {
                        Console.WriteLine("The students in G1 are: ");
                        for (int i = 0; i< studentsG1.Length; i++)
                        {
                            Console.WriteLine(studentsG1[i]);
                        }
                    }
                    else if (parsed == 2)
                    {
                        Console.WriteLine("The students in G1 are: ");
                        for (int i = 0; i< studentsG2.Length; i++)
                        {
                            Console.WriteLine(studentsG2[i]);
                        }
                    } else
                    {
                        Console.WriteLine("Pick 1 for G1 and  2 for G2");
                    }
            }
            else
            {
                Console.WriteLine("Enter number 1 or 2 ");
            }



            Console.ReadLine();
        }
    }
}
