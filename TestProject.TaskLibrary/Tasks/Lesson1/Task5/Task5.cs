using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task5 : IRunnable
    {
        public void Run(ILog loger)
        {
            ComplexNumber n1 = new ComplexNumber(2, 3);
            ComplexNumber n2 = new ComplexNumber(4, 5);
            ComplexNumber n3 = n1 * n2;
            loger.Write(string.Format("Multiplication of two complex number: {0} + {1}i\n", n3.Real, n3.Imaginary));
            ComplexNumber n4 = n1 / n2;
            loger.Write(string.Format("Division of two complex number: {0} + {1}i\n", n4.Real, n4.Imaginary));
        }
    }
}
