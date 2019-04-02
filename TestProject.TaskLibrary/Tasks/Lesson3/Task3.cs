using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson3.Task_3;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            Figure fig = new Figure(0, 0);
            fig.Draw();
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw();
            Square square = new Square(2, 2);
            square.Draw();
        }
    }
}
