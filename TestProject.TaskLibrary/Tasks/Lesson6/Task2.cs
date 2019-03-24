using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            double radius = Convert.ToDouble(Logger.Read());
            Point center = Utility.InputPoint();
            Circle circle1 = new Circle(center, radius);
            circle1.Draw();

            circle1.Move(new Tuple<int, int>(5, 5));
            circle1.Draw();

            circle1.Resize(2);
            circle1.Draw();
        }
    }
}
