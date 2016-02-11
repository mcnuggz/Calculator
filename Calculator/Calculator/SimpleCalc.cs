using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator
{
    public class SimpleCalc
    {
        public void SimpleCalculator()
        {
            CalcFunctions calFunctions = new CalcFunctions();
            bool menu = true;
            try
            {
                calFunctions.GrabNumbers();
                double userNumber1 = Convert.ToInt32(Console.ReadLine());
                while (menu == true)
                {
                Further:
                    calFunctions.GrabNumbers();
                    double userNumber2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Would you like to Add, Subtract, Multiply, Divide or Square these numbers?\r\nPress Q to quit.\r\n");
                    string userInput = Console.ReadLine().ToLower();

                    switch (userInput)
                    {
                        case "add":
                            calFunctions.AddNumbers(ref userNumber1, ref userNumber2);
                            Console.WriteLine(calFunctions.answer);
                            break;

                        case "subtract":
                            calFunctions.SubtractNumbers(ref userNumber1, ref userNumber2);
                            Console.WriteLine(calFunctions.answer);
                            break;

                        case "multiply":
                            calFunctions.MultiplyNumbers(ref userNumber1, ref userNumber2);
                            Console.WriteLine(calFunctions.answer);
                            break;

                        case "divide":
                            calFunctions.DivideNumbers(ref userNumber1, ref userNumber2);
                            Console.WriteLine(calFunctions.answer);
                            break;

                        case "square":
                            calFunctions.Exponential(ref userNumber1, ref userNumber2);
                            Console.WriteLine(calFunctions.answer);
                            break;

                        case "q":
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Not a valid option");
                            break;
                    }
                    calFunctions.MoreMath();
                    string secondAddInput = Console.ReadLine().ToLower();
                    if (secondAddInput == "yes")
                    {
                        calFunctions.answer = userNumber1;
                        Console.Clear();
                        goto Further;
                    }
                    else
                    {
                        Console.WriteLine("Thank you and have a good day! ");
                        Thread.Sleep(2000);
                        Environment.Exit(1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
