using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    public class Figure
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw(ILog loger)
        {
            loger.Write("Figure " + X + " " + Y + "\n");
        }
    }
}
