using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            loger.Write("Input month number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 12 && n >= 1)
            {
                loger.Write(Enum.GetName(typeof(Months), n) + "\n");
            }
            else
            {
                loger.Write("Wrong output\n");
            }
        }
    }
}