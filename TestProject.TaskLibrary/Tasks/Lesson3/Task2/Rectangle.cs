using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task_2
{
    class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y) { }
        /// <summary>
        /// The method that displays the name of the class that implements and coordinate of the top right corner.
        /// </summary>
        /// <param name="Logger"></param>
        public override void Draw()
        {
            Logger.Write($"Rectangle ({X}, {Y})\n");
        }
    }
}
