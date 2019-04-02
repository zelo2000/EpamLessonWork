using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson3.Task_2;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw();
            Square square = new Square(0, 0);
            square.Draw();
        }
    }
}
