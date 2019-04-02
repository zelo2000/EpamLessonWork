using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task_4
{
    class Square : IDrawable
    {
        /// <summary>
        /// The method that displays the name of the class that implements.
        /// </summary>
        /// <param name="Logger"></param>
        public void Draw()
        {
            Logger.Write("Square\n");
        }
    }
}
