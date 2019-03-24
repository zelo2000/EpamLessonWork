using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson3.Task_4;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{
    public class Task4 : IRunnable
    {
        public void DrawAll(params IDrawable[] array)
        {
            foreach (var figure in array)
            {
                figure.Draw();
            }
        }

        public void Run()
        {
            DrawAll(new Square(), new Rectangle(), new Rectangle(), new Rectangle(), new Square());
        }
    }
}
