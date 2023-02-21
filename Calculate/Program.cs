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

        public static Main(string[] args)
        {
            Program program = new Program();

            Calculator calculator = new();

            

        }


    }

}