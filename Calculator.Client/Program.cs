using Calculator.Core;
using System;
using TestProject.Common.Core;
using TestProject.Common.Core.Displayers;

namespace Calculator.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.SetLogger(new ConsoleLogger());

            CalculatorCreator calculatorCreator = new CalculatorCreator();

            Logger.Write("Type: ");
            string type = Logger.Read();
            try
            {
                if (type == "int")
                {
                    var calculator = calculatorCreator.Create<int>();
                    Logger.Write("First: ");
                    int a = Convert.ToInt32(Logger.Read());
                    Logger.Write("Sign: ");
                    string sign = Logger.Read();
                    Logger.Write("Second: ");
                    int b = Convert.ToInt32(Logger.Read());

                    switch (sign)
                    {
                        case "+":
                            Logger.Write(calculator.Sum(a, b) + "\n");
                            break;
                        case "-":
                            Logger.Write(calculator.Sub(a, b) + "\n");
                            break;
                        case "*":
                            Logger.Write(calculator.Mul(a, b) + "\n");
                            break;
                        case "/":
                            Logger.Write(calculator.Div(a, b) + "\n");
                            break;
                    }
                }
                else if (type == "int array")
                {
                    var calculator = calculatorCreator.Create<int[]>();
                    Logger.Write("First: ");

                    string[] line = Logger.Read().Split();
                    int[] a = new int[line.Length];
                    for (var i = 0; i < line.Length; i++)
                    {
                        a[i] = Convert.ToInt32(line[i]);
                    }

                    Logger.Write("Sign: ");
                    string sign = Logger.Read();

                    Logger.Write("Second: ");
                    line = Logger.Read().Split();
                    int[] b = new int[line.Length];
                    for (var i = 0; i < line.Length; i++)
                    {
                        b[i] = Convert.ToInt32(line[i]);
                    }

                    switch (sign)
                    {
                        case "+":
                            foreach (var element in calculator.Sum(a, b))
                            {
                                Logger.Write(element + "\n");
                            }
                            break;
                        case "-":
                            foreach (var element in calculator.Sub(a, b))
                            {
                                Logger.Write(element + "\n");
                            }
                            break;
                        case "*":
                            foreach (var element in calculator.Mul(a, b))
                            {
                                Logger.Write(element + "\n");
                            }
                            break;
                        case "/":
                            foreach (var element in calculator.Div(a, b))
                            {
                                Logger.Write(element + "\n");
                            }
                            break;
                    }
                }
                else
                {
                    Logger.Write("Invalid type\n");
                }
            }
            catch (DivideByZeroException e)
            {
                Logger.Write(e.Message + " from " + e.InnerException.Source + "\n");
            }
            catch (NullReferenceException e)
            {
                Logger.Write(e.Message + " from " + e.InnerException.Source + "\n");
            }
            catch (IndexOutOfRangeException e)
            {
                Logger.Write(e.Message + " from " + e.InnerException.Source + "\n");
            }
            catch (InvalidCastException e)
            {
                Logger.Write(e.Message + " from " + e.InnerException.Source + "\n");
            }

            Logger.Read();
        }
    }
}
