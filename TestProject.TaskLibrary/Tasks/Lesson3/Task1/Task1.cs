using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            Rectangle rect = new Rectangle();
            rect.Draw(logger);
            Square square = new Square();
            square.Draw(logger);
        }
    }
}
