using System;

namespace GradeCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score (0-100):");
            string input = Console.ReadLine();
            int score;

            if (int.TryParse(input, out score) && score >= 0 && score <= 100)
            {
                string grade = CalculateGrade(score);
                Console.WriteLine($"Your grade is: {grade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string CalculateGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80 && score <= 89)
                return "B";
            else if (score >= 70 && score <= 79)
                return "C";
            else if (score >= 60 && score <= 69)
                return "D";
            else
                return "F";
        }
    }
}