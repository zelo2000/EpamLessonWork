using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public class Task2 : IRunnable
    {
        public void Run(ILog loger)
        {
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw(loger);
            Square square = new Square(0, 0);
            square.Draw(loger);
        }
    }
}
