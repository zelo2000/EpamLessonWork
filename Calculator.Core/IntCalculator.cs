using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class IntCalculator : ICalculator<int>
    {
        /// <summary>
        /// Get number division
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Number division</returns>
        public int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException($"{a}/{b} = infinity", e);
            }
        }
        /// <summary>
        /// Get number multiplication
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Number multiplication</returns>
        public int Mul(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Get number subtraction
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Number subtraction</returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Get number addition
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Number addition</returns>
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
