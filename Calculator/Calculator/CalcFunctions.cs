using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcFunctions
    {
        public double answer;
        public void GrabNumbers()
        {
            Console.Write("Enter a number: ");
        }
        public void MoreMath()
        {
            Console.WriteLine("Would you like to do more math with this number? Yes or No");
        }
        public void AddNumbers(ref double x, ref double y)
        {
            answer = x += y;
        }

        public void SubtractNumbers(ref double x, ref double y)
        {
            answer =  x -= y;
        }
        public void MultiplyNumbers(ref double x, ref double y)
        {
            answer = x *= y;
        }
        public void DivideNumbers(ref double x, ref double y)
        {
            if (x == 0 || y == 0)
            {
                throw new Exception("Cannot divide by zero, mate.");
            }
            else
            {
                answer = x /= y;
            }
            
        }
        public void Exponential(ref double x, ref double y)
        {
            answer = Math.Pow(x, y);
        }
    }
}
