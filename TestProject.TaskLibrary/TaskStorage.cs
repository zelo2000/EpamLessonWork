using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary
{
    public static class TaskStorage
    {
        /// <summary>
        /// Lesson dictionary wich contains (lesson name, dictionary (task name, task))
        /// </summary>
        public static Dictionary<string, Dictionary<string, IRunnable>> Tasks = new Dictionary<string, Dictionary<string, IRunnable>>
        {
            { "Lesson1",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson1.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson1.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson1.Task3()},
                    { "Task4", new TaskLibrary.Tasks.Lesson1.Task4()},
                    { "Task5", new TaskLibrary.Tasks.Lesson1.Task5()}
                }
            },
            //TO DO
            { "Lesson2",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson2.Enums.Task1.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson2.Enums.Task2.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson2.Enums.Task3.Task3()},
                    { "Task4", new TaskLibrary.Tasks.Lesson2.Struct.Task1.Task1()},
                    { "Task5", new TaskLibrary.Tasks.Lesson2.Struct.Task2.Task2()}
                }
            },
            { "Lesson3",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson3.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson3.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson3.Task3()},
                    { "Task4", new TaskLibrary.Tasks.Lesson3.Task4()}
                }
            },
            { "Lesson4",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson4.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson4.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson4.Task3()},
                    { "Task4", new TaskLibrary.Tasks.Lesson4.Task4()},
                    { "Task5", new TaskLibrary.Tasks.Lesson4.Task5()}
                }
            },
            { "Lesson5",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson5.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson5.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson5.Task3()}
                }
            },
            { "Lesson6",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson6.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson6.Task2()}
                }
            },
            { "Lesson7",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1-3", new TaskLibrary.Tasks.Lesson7.Task1_3()},
                    { "Task4", new TaskLibrary.Tasks.Lesson7.Task4()}
                }
            },
            { "Lesson9",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1-4", new TaskLibrary.Tasks.Lesson9.Task1_4()},
                    { "Task5", new TaskLibrary.Tasks.Lesson9.Task5()}
                }
            },
            { "Lesson10",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson10.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson10.Task2()}
                }
            },
            { "Lesson11",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson11.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson11.Task2()},
                    { "Task3", new TaskLibrary.Tasks.Lesson11.Task3()}
                }
            },
            { "Lesson12",
                new Dictionary<string, IRunnable>()
                {
                    { "Task1", new TaskLibrary.Tasks.Lesson12.Task1()},
                    { "Task2", new TaskLibrary.Tasks.Lesson12.Task2()}
                }
            }
        };
    }
}
