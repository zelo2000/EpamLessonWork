using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            ComplexNumber n1 = new ComplexNumber(2, 3);
            ComplexNumber n2 = new ComplexNumber(4, 5);
            ComplexNumber n3 = n1 * n2;
            Console.WriteLine("Multiplication of two complex number: " + n3.Real + " + " + n3.Imaginary + "i");
            ComplexNumber n4 = n1 / n2;
            Console.WriteLine("Division of two complex number:" + n4.Real + " + " + n4.Imaginary + "i");
        }
    }
}
