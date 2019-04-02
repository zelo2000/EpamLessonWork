using System;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson3.Task_1;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Rectangle rect = new Rectangle();
            rect.Draw();
            Square square = new Square();
            square.Draw();
        }
    }
}
