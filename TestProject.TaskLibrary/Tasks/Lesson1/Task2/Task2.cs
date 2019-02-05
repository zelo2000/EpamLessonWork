using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Rectangle with auto property
            RectangleWithProperty rect = new RectangleWithProperty(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0));
            loger.Write("Perimetr: " + rect.Perimeter + "\n");
            loger.Write("Square: " + rect.Square + "\n");
        }
    }
}
