using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10
{
    public class Task2 : IRunnable
    {
        public void Run(ILog logger)
        {
            logger.Write("Input part of path: ");
            string root = logger.Read();
            logger.Write("Input part of file name: ");
            string name = logger.Read();
            List<string> files = Find(root, name);
            foreach (var file in files)
            {
                logger.Write(file + "\n");
            }
        }

        private List<string> Find(string root, string name)
        {
            List<string> result = new List<string>();
            foreach (var element in Directory.GetFiles(root))
            {
                if (element.Contains(name))
                {
                    result.Add(element);
                }
            }
            foreach (var element in Directory.GetDirectories(root))
            {
                var temp = Find(element, name);
                foreach (var item in temp)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
