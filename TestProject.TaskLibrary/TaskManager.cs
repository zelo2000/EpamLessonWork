using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary
{
    public class TaskManager
    {
        public SortedDictionary<string, SortedDictionary<string, IRunnable>> GetTasks()
        {
            var taskList = new List<IRunnable>();
            var findedType = typeof(IRunnable);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => findedType.IsAssignableFrom(p));

            foreach (var t in types)
            {
                if (t.IsClass)
                {
                    taskList.Add((IRunnable)Activator.CreateInstance(t));
                }
            }

            var taskDictionary = new SortedDictionary<string, SortedDictionary<string, IRunnable>>();

            foreach (var task in taskList)
            {
                var taskType = task.GetType().ToString().Split('.');
                var lessonName = taskType[taskType.Length - 2];
                var taskName = taskType.Last();
                if (taskDictionary.Keys.Contains(lessonName))
                {
                    taskDictionary[lessonName].Add(taskName, task);
                }
                else
                {
                    taskDictionary.Add(lessonName, new SortedDictionary<string, IRunnable>());
                    taskDictionary[lessonName].Add(taskName, task);
                }
            }

            return taskDictionary;
        }
    }
}
