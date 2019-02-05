using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Enums.Task1
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Console.Write("Input month number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 12 && n >= 1)
            {
                Console.WriteLine(Enum.GetName(typeof(Months), n));
            }
            else
            {
                Console.WriteLine("Wrong output");
            }
        }
    }
}