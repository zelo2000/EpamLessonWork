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

            string lessonNumber = ConfigurationManager.AppSettings["lesson"];
            string taskNumber = ConfigurationManager.AppSettings["task"];

            TaskManager taskManager = new TaskManager();
            taskManager.GetTasks()[lessonNumber][taskNumber].Run();

            Console.ReadKey();
        }
    }
}
