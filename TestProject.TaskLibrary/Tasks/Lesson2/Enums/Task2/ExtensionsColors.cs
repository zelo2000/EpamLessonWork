using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public static class SortedColors
    {
        /// <summary>
        /// A method that sort the enum.
        /// </summary>
        /// <returns>Sorted array of enum values</returns>
        public static Array Sort()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Array.Sort(colors);
            return colors;
        }
    }
}
