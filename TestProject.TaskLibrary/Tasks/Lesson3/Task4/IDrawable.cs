using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public interface IDrawable
    {
        /// <summary>
        /// The method that displays the name of the class that implements.
        /// </summary>
        /// <param name="logger"></param>
        void Draw(ILog logger);
    }
}
