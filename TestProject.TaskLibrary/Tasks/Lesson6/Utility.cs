using System;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Utility
    {
        public static Point InputPoint()
        {
            Point p = new Point();
            var line = Logger.Read().Split();
            p.X = Convert.ToInt32(line[0]);
            p.Y = Convert.ToInt32(line[1]);
            return p;
        }
    }
}
