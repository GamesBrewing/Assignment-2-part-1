using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Code below is from https://learn.microsoft.com/en-us/training/modules/visual-studio-test-tools/3-exercise-write-test
  This code was used so I can complete the tutorial at this site on how to create automated tests.*/

namespace LearnMyCalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
        if (y == 0)
            {
                Console.WriteLine("Can't divide by zero.");
                return null;
            }
            else
            {
                return x / y;
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            int x = 0;
            int y = 0;

            Calculator calculator = new Calculator();

        }
    }
}
