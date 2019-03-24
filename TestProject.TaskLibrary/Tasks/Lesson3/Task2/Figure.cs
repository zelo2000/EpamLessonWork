using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task_2
{
    public abstract class Figure
    {
        /// <summary>
        /// Coordinate X of the top right corner
        /// </summary>
        public double X { get; private set; }
        /// <summary>
        /// Coordinate Y of the top right corner
        /// </summary>
        public double Y { get; private set; }

        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// The method that displays the name of the class that implements.
        /// </summary>
        /// <param name="Logger"></param>
        public abstract void Draw();
    }
}
