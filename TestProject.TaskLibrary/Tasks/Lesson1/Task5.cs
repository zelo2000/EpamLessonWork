using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            var n1 = new ComplexNumber(2, 3);
            var n2 = new ComplexNumber(4, 5);
            ComplexNumber n3 = n1 * n2;
            Logger.Write($"Multiplication of two complex number: {n3.Real} + {n3.Imaginary}i\n");
            ComplexNumber n4 = n1 / n2;
            Logger.Write($"Division of two complex number: {n4.Real} + {n4.Imaginary}i\n");
        }
    }
}
