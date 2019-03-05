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
                //new TaskLibrary.Tasks.Lesson8.Task1_4()
                new TaskLibrary.Tasks.Lesson8.Task5()
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
