using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            //Rectangle with methods
            var x = new Tuple<double, double>(0, 2);
            var y = new Tuple<double, double>(2, 0);

            RectangleWithMethod rect = new RectangleWithMethod(x, y);
            Logger.Write($"Perimetr: {rect.GetPerimeter()}\n");
            Logger.Write($"Square: {rect.GetSquare()}\n");
        }
    }
}
