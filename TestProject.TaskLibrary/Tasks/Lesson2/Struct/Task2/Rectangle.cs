using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task2
{
    struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }
        public double Height { get; set; }
        /// <summary>
        /// X сoordinate of the right top vertex of a rectangle. 
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y сoordinate of the right top vertex of a rectangle. 
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// A method that calculate perimeter of rectangle.
        /// </summary>
        /// <returns>Perimeter of rectangle.</returns>
        public double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
