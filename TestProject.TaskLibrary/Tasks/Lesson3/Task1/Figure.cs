using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    public abstract class Figure
    {
        /// <summary>
        /// The method that displays the name of the class that implements.
        /// </summary>
        /// <param name="logger"></param>
        public abstract void Draw(ILog logger);
    }
}
