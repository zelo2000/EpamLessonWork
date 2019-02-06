using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    class Square : Figure
    {
        public Square(double x, double y) : base(x, y) { }

        public override void Draw(ILog loger)
        {
            loger.Write("Square " + X + " " + Y + "\n");
        }
    }
}
