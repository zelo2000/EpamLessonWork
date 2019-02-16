using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public static class SRectangle
    {
        public static double GetPerimeter(Tuple<double, double> leftTop, Tuple<double, double> rightDown)
        {
            return (rightDown.Item1 - leftTop.Item1) * 2 + (leftTop.Item2 - rightDown.Item2) * 2;
        }

        public static double GetSquare(Tuple<double, double> leftTop, Tuple<double, double> rightDown)
        {
            return (rightDown.Item1 - leftTop.Item1) * (leftTop.Item2 - rightDown.Item2);
        }
    }
}
