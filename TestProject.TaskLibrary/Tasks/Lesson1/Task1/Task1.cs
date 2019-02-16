using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Rectangle with methods
            var x = new Tuple<double, double>(0, 2);
            var y = new Tuple<double, double>(2, 0);

            RectangleWithMethod rect = new RectangleWithMethod(x, y);
            logger.Write($"Perimetr: {rect.GetPerimeter()}\n");
            logger.Write($"Square: {rect.GetSquare()}\n");
        }
    }
}
