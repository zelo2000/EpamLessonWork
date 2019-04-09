using System;
using Microsoft.Extensions.Configuration.Xml;
using System.Configuration;
using TestProject.Common.Core;
using TestProject.Common.Core.Displayers;
using TestProject.TaskLibrary;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.SetLogger(new ConsoleLogger());

            TaskManager taskManager = new TaskManager();
            var allTasks = taskManager.GetTasks();

            string lessonNumber = ConfigurationManager.AppSettings["lesson"];
            string taskNumber = ConfigurationManager.AppSettings["task"];
            allTasks[lessonNumber][taskNumber].Run();

            Console.ReadKey();
        }
    }
}
