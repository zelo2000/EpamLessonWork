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
                //TO DO
            };

            ConsoleLoger consoleLoger = new ConsoleLoger();

            foreach (var task in tasks)
            {
                task.Run(consoleLoger);
            }

            consoleLoger.ReadKey();
        }
    }
}
