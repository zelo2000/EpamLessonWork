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
        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            double real = left.Real * right.Real - left.Imaginary * right.Imaginary;
            double img = left.Real * right.Imaginary + left.Imaginary * right.Real;
            return new ComplexNumber(real, img);
        }

        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            double real = (left.Real * right.Real + left.Imaginary * right.Imaginary) / (right.Real * right.Real + right.Imaginary * right.Imaginary);
            double img = (left.Imaginary * right.Real - left.Real * right.Imaginary) / (right.Real * right.Real + right.Imaginary * right.Imaginary);
            return new ComplexNumber(real, img);
        }
        #endregion
    }
}
