using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Static circle
            Logger.Write("Circle:\n");
            Logger.Write($"Length: {SCircle.GetLength(3)}\n");
            Logger.Write($"Square: {SCircle.GetSquare(3)}\n");
            //Static rectangle
            var x = new Tuple<double, double>(0, 2);
            var y = new Tuple<double, double>(2, 0);
            Logger.Write("Rectangle:\n");
            Logger.Write($"Perimetr: {SRectangle.GetPerimeter(x, y)}\n");
            Logger.Write($"Square: {SRectangle.GetSquare(x, y)}\n");
        }
    }
}
