using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public interface ICalculator<T>
    {
        T Sum(T a, T b);
        T Sub(T a, T b);
        T Mul(T a, T b);
        T Div(T a, T b);
    }
}