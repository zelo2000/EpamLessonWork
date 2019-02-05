using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task4 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Static circle
            loger.Write("Circle:\n");
            loger.Write("Length: " + SCircle.Length(3) + "\n");
            loger.Write("Square: " + SCircle.Square(3) + "\n");
            //Static rectangle
            loger.Write("Rectangle:\n");
            loger.Write("Perimetr: " + SRectangle.Perimeter(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0)) + "\n");
            loger.Write("Square: " + SRectangle.Square(new Tuple<double, double>(0, 2), new Tuple<double, double>(2, 0)) + "\n");
        }
    }
}
