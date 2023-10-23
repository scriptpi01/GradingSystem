using System;

namespace GradingSystem
{
    public class Grading
    {
        public static void GradeCalculator(string input)
        {
            if (int.TryParse(input, out int score))
            {
                if (score < 0)
                {
                    Console.WriteLine($"Error: Score is lower than zero ({input})");
                }
                else if (score > 100)
                {
                    Console.WriteLine($"Error: Score is over than hundred ({input})");
                }
                else if (score >= 80 && score <= 100)
                {
                    Console.WriteLine("Grade: A (" + score + ")");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Grade: B (" + score + ")");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Grade: C (" + score + ")");
                }
                else if (score >= 50)
                {
                    Console.WriteLine("Grade: D (" + score + ")");
                }
                else
                {
                    Console.WriteLine("Grade: F (" + score + ")");
                }
            }
            else
            {
                Console.WriteLine($"Error: Score should be in digit only ({input})");
            }
        }
    }
}
