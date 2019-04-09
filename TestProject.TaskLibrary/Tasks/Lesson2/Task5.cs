using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task2;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            Rectangle rect = new Rectangle
            {
                Height = 2,
                Width = 3
            };
            Logger.Write(rect.Perimeter() + "\n");
        }
    }
}
