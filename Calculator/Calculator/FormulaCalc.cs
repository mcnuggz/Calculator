using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator
{
    public class FormulaCalc
    {
        public void AdvancedCalculator()
        {
            DataTable dt = new DataTable();
            string s1 = "**";
            try
            {
                Console.WriteLine("Enter a formula to calculate");
                Console.WriteLine("Operator Reminder:\r\nAdd: + , Subtract: -, Multiply: *, Divide: / ");
                double answer = (double)dt.Compute(Console.ReadLine(), "");
                Console.WriteLine("Calculating...");

                Thread.Sleep(3000);
                Console.WriteLine(answer.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine( );
            }

        }
    }
}
