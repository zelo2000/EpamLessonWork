using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            Figure fig = new Figure(0, 0);
            fig.Draw(logger);
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw(logger);
            Square square = new Square(2, 2);
            square.Draw(logger);
        }
    }
}
