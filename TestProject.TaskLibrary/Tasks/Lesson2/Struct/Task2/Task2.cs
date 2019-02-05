using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task2
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            Rectangle rect = new Rectangle();
            rect.Height = 2;
            rect.Width = 3;
            Console.WriteLine(rect.Perimeter());
        }
    }
}
