using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(ILog logger)
        {
            var line = logger.Read().Split();
            X = Convert.ToInt32(line[0]);
            Y = Convert.ToInt32(line[1]);
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
