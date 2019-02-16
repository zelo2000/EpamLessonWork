using System;
using System.Threading.Tasks;
using TestProject.Common.Core.Displayers;
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
                new TestProject.TaskLibrary.Tasks.Lesson5.Task1(),
                new TestProject.TaskLibrary.Tasks.Lesson5.Task2(),
                new TestProject.TaskLibrary.Tasks.Lesson5.Task3(),
                //TO DO
            };

            ConsoleLogger consoleLogger = new ConsoleLogger();

            foreach (var task in tasks)
            {
                task.Run(consoleLogger);
            }

            consoleLogger.ReadKey();
        }
    }
}
