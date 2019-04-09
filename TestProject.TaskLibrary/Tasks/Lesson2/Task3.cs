using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task3;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            Logger.Write($"Long is in [ {(long)LongRange.Min}, {(long)LongRange.Max} ]");
        }
    }
}

