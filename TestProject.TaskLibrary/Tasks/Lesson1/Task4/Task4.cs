using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            //Static circle
            Console.WriteLine("Circle:");
            Console.WriteLine("Length: "+SCircle.Length(3));
            Console.WriteLine("Square: " + SCircle.Square(3));
            //Static rectangle
            Console.WriteLine("Rectangle:");
            Console.WriteLine("Perimetr: " + SRectangle.Perimeter(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0)));
            Console.WriteLine("Square: " + SRectangle.Square(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0)));
        }
    }
}
