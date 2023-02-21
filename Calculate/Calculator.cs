using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Calculator
    {

        public static Func<int, int, int> Add = (int1, int2) => int1 + int2;
        public static Func<int, int, int> Subtract = (int1, int2) => int1 - int2;
        public static Func<int, int, int> Multiply = (int1, int2) => int1 * int2;
        public static Func<int, int, int> Divide = (int1, int2) => int1 / int2;

        public static IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations { get; } = new Dictionary<char, Func<int, int, int>>()
        {
            { '+', Add },
            { '-', Subtract },
            { '*', Multiply },
            { '/', Divide }

        };

        public static bool TryCalculate(char input, out int result)
        {
            bool TorF = false;
            result = 0;
            Calculator calculator = new();
            char[] validOps =
            {
                '+', '-', '*', '/'
            };
            string[] ints = input.ToString().Split(' ');
            if (ints.Length < 3 )
            {
                return TorF;
            }
            int int1, int2;
            char op;

            if (!Calculator.MathematicalOperations.TryGetValue(op, out var operation))
            {
                return false;
            }

            result = operation(int1, int2);
            return TorF;

        }

    }
}
