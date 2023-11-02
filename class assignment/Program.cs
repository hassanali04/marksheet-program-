// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Security.Cryptography.X509Certificates;

using System.Globalization;

namespace work
{
    class program
    {
        static void Main(string[] args)
        {
            
            int[,] marksSheet = new int[3, 4];

            for (int student = 0; student < 3; student++)
            {
                Console.WriteLine("Enter details for Student {0}:", student + 1);
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your roll no:");
                string roll = Console.ReadLine();
                Console.WriteLine("Enter your class:");
                string standard = Console.ReadLine();

                for (int subject = 0; subject < 4; subject++)
                {
                    Console.WriteLine("Enter marks for Subject {0}:", subject + 1);
                    marksSheet[student, subject] = int.Parse(Console.ReadLine());
                }

                int totalMarks = 0;
                for (int subject = 0; subject < 4; subject++)
                {
                    totalMarks += marksSheet[student, subject];
                }

                int percentage = totalMarks * 100 / 400;

                Console.WriteLine("\n------MARKSHEET-----");
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Roll No: {0}", roll);
                Console.WriteLine("Class: {0}", standard);
                Console.WriteLine("Total obtained marks: {0}", totalMarks);
                Console.WriteLine("Percentage: {0}", percentage);
                Console.WriteLine();

                Console.WriteLine("Subject-wise marks average:");

                for (int subject = 0; subject < 4; subject++)
                {
                    int avgMarks = marksSheet[student, subject] / 1;
                    Console.WriteLine("Subject {0}: {1}", subject + 1, avgMarks);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of per subject average marks for all students in percentage:");

            for (int subject = 0; subject < 4; subject++)
            {
                int sumAvgMarks = 0;
                for (int student = 0; student < 3; student++)
                {
                    sumAvgMarks += marksSheet[student, subject] / 1;
                }
                int totalAvgMarks = sumAvgMarks / 3;
                Console.WriteLine("Subject {0}: {1}", subject + 1, totalAvgMarks);
            }
        }
    }




}


    










