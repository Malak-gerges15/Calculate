using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator_project
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator clsCalculator = new Calculator();

            clsCalculator.Add(100);
            clsCalculator.PrintResult();

            clsCalculator.Subtract(50);
            clsCalculator.PrintResult();

            clsCalculator.Multiply(2);
            clsCalculator.PrintResult();

            clsCalculator.Divide(0);
            clsCalculator.PrintResult();

            clsCalculator.Modulo(50);
            clsCalculator.PrintResult();

            clsCalculator.GetFinalResult();



            Console.ReadKey();
        }
    }
}
