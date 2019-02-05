using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            //Rectangle with auto property
            RectangleWithProperty rect = new RectangleWithProperty(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0));
            Console.WriteLine("Perimetr: " + rect.Perimeter);
            Console.WriteLine("Square: " + rect.Square);
        }
    }
}
