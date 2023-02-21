using System.ComponentModel;

namespace Calculate
{
    internal class Program
    {
        private int _WriteLine;
        private int _ReadLine;

        public int WriteLine
        {
            init
            {
                Console.WriteLine();
            }
        }

        public int ReadLine
        {
            init
            {
                Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            Calculator calculator = new();

            bool quit = false;

            
            while (quit == false)
            {
                Console.WriteLine("Please enter a function in the form: x operator y, or q to quit");

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(args[0]))
                {
                    Console.WriteLine("Invalid");
                }
                if (calculator.TryCalculate(input, out int result))
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

        }
    }

}