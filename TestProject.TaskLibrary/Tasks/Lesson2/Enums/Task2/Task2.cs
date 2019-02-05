using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task2
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            SortedColors.Sort();
        }
    }
}
