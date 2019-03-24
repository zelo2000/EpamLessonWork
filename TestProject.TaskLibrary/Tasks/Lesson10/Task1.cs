using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Logger.Write("Input catalog name: ");
            string root = Logger.Read();
            InputItems(root, 0);
            string[] subDirectory = Directory.GetDirectories(root);
            foreach (var dir in subDirectory)
            {
                Logger.Write($"- {dir}\n");
                InputItems(dir, 1);
                InputDirectories(dir, 1);
            }
        }

        private void InputItems(string root, int depth)
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
                Logger.Write(result);
                result = "";
            }
        }

        private void InputDirectories(string root, int depth)
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
                Logger.Write(result);
                result = "";
            }
        }
    }
}
