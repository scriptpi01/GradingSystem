namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string input = Console.ReadLine();
            Grading.GradeCalculator(input);
        }
    }
}
