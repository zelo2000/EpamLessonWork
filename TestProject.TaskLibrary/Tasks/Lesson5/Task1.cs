using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            var people = new List<Person>
            {
                new Person("Oleksandr", 18, new List<string>{ "098","095"}),
                new Person("Pavlo", 17, new List<string>{ "097","095"}),
                new Person("Maks", 20, new List<string>{ "063","095"}),
                new Person("Yarya", 19, new List<string>{ "098","066"}),
                new Person("Romko", 19, new List<string>{ "067","095"}),
            };

            foreach(var person in people)
            {
                Logger.Write($"name: {person.Name}, age: {person.Age}\n");
            }
        }
    }
}
