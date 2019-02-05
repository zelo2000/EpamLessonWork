using System;
using System.Threading.Tasks;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of .NetLab Tasks
            var tasks = new IRunnable[]
            {
                //struct tasks
                new TaskLibrary.Tasks.Lesson2.Struct.Task1.Task1(),
                new TaskLibrary.Tasks.Lesson2.Struct.Task2.Task2(),
                //enum tasks
                new TaskLibrary.Tasks.Lesson2.Enums.Task1.Task1(),
                new TaskLibrary.Tasks.Lesson2.Enums.Task2.Task2(),
                new TaskLibrary.Tasks.Lesson2.Enums.Task3.Task3(),
        };

            foreach (var task in tasks)
            {
                task.Run();
            }
            Console.ReadLine();
        }
    }
}
