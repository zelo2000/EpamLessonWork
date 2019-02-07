using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            Rectangle rect = new Rectangle();
            rect.Draw(loger);
            Square square = new Square();
            square.Draw(loger);
        }
    }
}
