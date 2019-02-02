using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        #region initialization
        public ComplexNumber() { }
        public ComplexNumber(double real, double img)
        {
            Real = real;
            Imaginary = img;
        }
        #endregion

        #region overloaded operators
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
            double img = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return new ComplexNumber(real, img);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary);
            double img = (a.Imaginary * b.Real - a.Real * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary);
            return new ComplexNumber(real, img);
        }
        #endregion
    }
}
