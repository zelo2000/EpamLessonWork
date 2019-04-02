using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public static class Utility
    {
        public static int[] ReadArray()
        {
            var line = Logger.Read().Split();
            int[] array = new int[line.Length];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(line[i]);
            }

            return array;
        }
    }
}
