using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class CalculatorCreator
    {
        /// <summary>
        /// Create concrete calculator
        /// </summary>
        /// <typeparam name="T">Calculator type</typeparam>
        /// <returns>Calculator</returns>
        public ICalculator<T> Create<T>()
        {
            if (typeof(T) == typeof(int))
            {
                return (ICalculator<T>)(new IntCalculator());
            }
            else if (typeof(T) == typeof(int[]))
            {
                return (ICalculator<T>)(new IntArrayCalculator());
            }
            else
            {
                throw new InvalidCastException("Invalid cast exeption");
            }
        }

    }
}
