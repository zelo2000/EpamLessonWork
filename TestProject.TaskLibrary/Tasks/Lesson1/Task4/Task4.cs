using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Static circle
            logger.Write("Circle:\n");
            logger.Write($"Length: {SCircle.GetLength(3)}\n");
            logger.Write($"Square: {SCircle.GetSquare(3)}\n");
            //Static rectangle
            var x = new Tuple<double, double>(0, 2);
            var y = new Tuple<double, double>(2, 0);
            logger.Write("Rectangle:\n");
            logger.Write($"Perimetr: {SRectangle.GetPerimeter(x, y)}\n");
            logger.Write($"Square: {SRectangle.GetSquare(x, y)}\n");
        }
    }
}
