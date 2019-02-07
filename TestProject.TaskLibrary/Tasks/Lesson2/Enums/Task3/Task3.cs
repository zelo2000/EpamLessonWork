using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task3
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            logger.Write($"Long is in [ {(long)LongRange.Min}, {(long)LongRange.Max} ]");
        }
    }
}

