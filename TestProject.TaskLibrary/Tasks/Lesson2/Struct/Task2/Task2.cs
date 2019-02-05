using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task2
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            Rectangle rect = new Rectangle
            {
                Height = 2,
                Width = 3
            };
            loger.Write(rect.Perimeter() + "\n");
        }
    }
}
