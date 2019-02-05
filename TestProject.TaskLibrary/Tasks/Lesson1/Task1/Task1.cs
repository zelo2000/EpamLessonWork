using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Rectangle with methods
            RectangleWithMethod rect = new RectangleWithMethod(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0));
            loger.Write("Perimetr: " + rect.Perimeter() + "\n");
            loger.Write("Square: " + rect.Square() + "\n");
        }
    }
}
