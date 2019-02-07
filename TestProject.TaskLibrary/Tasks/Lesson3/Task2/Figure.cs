using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public abstract class Figure
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw(ILog loger);
    }
}
