using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            //Rectangle with auto property
            var x = new Tuple<double, double>(0, 2);
            var y = new Tuple<double, double>(2, 0);

            RectangleWithProperty rect = new RectangleWithProperty(x, y);
            Logger.Write($"Perimetr: {rect.Perimeter}\n");
            Logger.Write($"Square: {rect.Square}\n");
        }
    }
}
