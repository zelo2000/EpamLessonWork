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
                new TestProject.TaskLibrary.Tasks.Lesson4.Task1(),
                new TestProject.TaskLibrary.Tasks.Lesson4.Task2(),
                new TestProject.TaskLibrary.Tasks.Lesson4.Task3(),
                new TestProject.TaskLibrary.Tasks.Lesson4.Task4(),
                new TestProject.TaskLibrary.Tasks.Lesson4.Task5(),
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
