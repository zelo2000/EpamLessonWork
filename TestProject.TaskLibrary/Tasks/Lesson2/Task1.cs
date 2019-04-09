using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task1;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Logger.Write("Input month number: ");
            int n = Convert.ToInt32(Logger.Read());
            if ((n <= 12) && (n >= 1))
            {
                Logger.Write(Enum.GetName(typeof(Months), n) + "\n");
            }
            else
            {
                Logger.Write("Wrong output\n");
            }
        }
    }
}