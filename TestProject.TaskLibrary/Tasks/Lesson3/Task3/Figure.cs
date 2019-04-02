using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task_3
{
    public class Figure
    {
        /// <summary>
        /// Coordinate X of the top right corner
        /// </summary>
        public double X { get; private set; }
        /// <summary>
        /// Coordinate Y of the top right corner
        /// </summary>
        public double Y { get; private set; }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// The method that displays the name of the class that implements and coordinate of the top right corner.
        /// </summary>
        /// <param name="Logger"></param>
        public virtual void Draw()
        {
            Logger.Write($"Figure ({X}, {Y})\n");
        }
    }
}
