using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public static class SortedColors
    {
        public static Array Sort()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Array.Sort(colors);
            return colors;
        }
    }
}
