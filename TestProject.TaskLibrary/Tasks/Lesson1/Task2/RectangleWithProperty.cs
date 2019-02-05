using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class RectangleWithProperty
    {
        private readonly Tuple<double, double> leftTop;
        private readonly Tuple<double, double> rightDown;
        public double Perimeter { get; }
        public double Square { get; }

        public RectangleWithProperty(Tuple<double, double> leftTop, Tuple<double, double> rightDown)
        {
            this.leftTop = leftTop;
            this.rightDown = rightDown;
            Perimeter = (rightDown.Item1 - leftTop.Item1) * 2 + (leftTop.Item2 - rightDown.Item2) * 2;
            Square = (rightDown.Item1 - leftTop.Item1) * (leftTop.Item2 - rightDown.Item2);
        }
    }
}
