using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Circle
    {
        private const double Pi = 3.14159;

        public Circle() { }

        public double GetLength(double r)
        {
            return 2 * Pi * r;
        }
        public double GetSquare(double r)
        {
            return Pi * r * r;
        }
    }
}
