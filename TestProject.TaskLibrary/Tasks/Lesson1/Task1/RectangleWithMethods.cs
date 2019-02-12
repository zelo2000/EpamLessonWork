using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class RectangleWithMethod
    {
        private readonly Tuple<double, double> leftTop;
        private readonly Tuple<double, double> rightDown;

        public RectangleWithMethod(Tuple<double, double> leftTop, Tuple<double, double> rightDown)
        {
            this.leftTop = leftTop;
            this.rightDown = rightDown;
        }

        public double GetPerimeter()
        {
            return (rightDown.Item1 - leftTop.Item1) * 2 + (leftTop.Item2 - rightDown.Item2) * 2;
        }

        public double GetSquare()
        {
            return (rightDown.Item1 - leftTop.Item1) * (leftTop.Item2 - rightDown.Item2);
        }
    }
}
