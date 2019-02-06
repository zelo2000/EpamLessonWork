using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    public class Task3 : IRunnable
    {
        public void Run(ILog loger)
        {
            Figure fig = new Figure(0, 0);
            fig.Draw(loger);
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw(loger);
            Square square = new Square(2, 2);
            square.Draw(loger);
        }
    }
}
