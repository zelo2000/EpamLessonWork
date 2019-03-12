using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            logger.Write("Input catalog name: ");
            string root = logger.Read();
            InputItems(root, 0, logger);
            string[] subDirectory = Directory.GetDirectories(root);
            foreach (var dir in subDirectory)
            {
                logger.Write($"- {dir}\n");
                InputItems(dir, 1, logger);
                InputDirectories(dir, 1, logger);
            }
        }

        private void InputItems(string root, int depth, ILog logger)
        {
            string[] items = Directory.GetFiles(root);
            string result = "";

            foreach (var item in items)
            {
                for (var i = 0; i < depth; i++)
                {
                    result += "\t";
                }
                result += $"* {item}\n";
                logger.Write(result);
                result = "";
            }
        }

        private void InputDirectories(string root, int depth, ILog logger)
        {
            string[] items = Directory.GetDirectories(root);
            string result = "";

            foreach (var item in items)
            {
                for (var i = 0; i < depth; i++)
                {
                    result += "\t";
                }
                result += $"- {item}\n";
                logger.Write(result);
                result = "";
            }
        }
    }
}
