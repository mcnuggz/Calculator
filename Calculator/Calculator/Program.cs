using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            SimpleCalc sc = new SimpleCalc();
            FormulaCalc fc = new FormulaCalc();

            Console.WriteLine("Press 1 to do simple calculations or 2 to enter a formula");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    sc.SimpleCalculator();
                    break;
                case 2:
                    Console.Clear();
                    fc.AdvancedCalculator();
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }



        }

    }
}
