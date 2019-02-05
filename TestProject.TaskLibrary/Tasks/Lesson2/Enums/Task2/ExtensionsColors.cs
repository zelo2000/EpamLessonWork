using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public static class SortedColors
    {
        public static void Sort()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Array.Sort(colors);

            foreach (var color in colors)
            {
                Console.WriteLine(Enum.GetName(typeof(Colors), (int)color) + " = " + (int)color);
            }
        }
    }
}
