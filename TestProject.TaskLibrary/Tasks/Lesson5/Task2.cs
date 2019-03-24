using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task2 : IRunnable
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

            people.AddRange(new List<Person>
            {
                new Person("Petro", 15, new List<string> { "097", "095" }),
                new Person("Nadia", 16, new List<string> { "097", "095" })
            });

            foreach (var person in people)
            {
                foreach (var number in person.PhoneNumbers)
                {
                    Logger.Write($"{number} ");
                }
                Logger.Write("\n");
            }
        }
    }
}
