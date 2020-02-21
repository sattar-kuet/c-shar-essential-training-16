using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int sum = a + b;
            int subtraction = a - b;
            float division = (float) a / b; 
            int multiplication = a * b;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(division);
            Console.WriteLine(multiplication);

        }
    }
}
