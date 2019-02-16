using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Task4 : IRunnable
    {
        public void DrawAll(ILog logger, params IDrawable[] array)
        {
            foreach (var figure in array)
            {
                figure.Draw(logger);
            }
        }

        public void Run(ILog logger)
        {
            DrawAll(logger, new Square(), new Rectangle(), new Rectangle(), new Rectangle(), new Square());
        }
    }
}
