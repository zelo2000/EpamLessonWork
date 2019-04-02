using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            foreach (var color in SortedColors.Sort())
            {
                Logger.Write(color.ToString() + "\n");
            }
            Logger.Write("\n");
        }
    }
}
