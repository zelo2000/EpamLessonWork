using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public class Task2 : IRunnable
    {
        public void Run(ILog logger)
        {
            foreach (var color in SortedColors.Sort())
            {
                logger.Write(color.ToString() + "\n");
            }
            logger.Write("\n");
        }
    }
}
