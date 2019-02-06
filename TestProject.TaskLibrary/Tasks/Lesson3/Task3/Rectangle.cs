using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y) { }

        public override void Draw(ILog loger)
        {
            loger.Write("Rectangle " + X + " " + Y + "\n");
        }
    }
}
