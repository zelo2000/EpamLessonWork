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
                new TestProject.TaskLibrary.Tasks.Lesson3.Task1.Task1(),
                new TestProject.TaskLibrary.Tasks.Lesson3.Task2.Task2(),
                new TestProject.TaskLibrary.Tasks.Lesson3.Task3.Task3(),
                new TestProject.TaskLibrary.Tasks.Lesson3.Task4.Task4(),
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
