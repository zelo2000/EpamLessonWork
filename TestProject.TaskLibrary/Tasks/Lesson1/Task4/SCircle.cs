using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public static class SCircle
    {
        private const double Pi = 3.14159;

        public static double GetLength(double r)
        {
            return 2 * Pi * r;
        }
        public static double GetSquare(double r)
        {
            return Pi * r * r;
        }
    }
}
