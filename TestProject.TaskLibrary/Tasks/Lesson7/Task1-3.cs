using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using System.Linq;
namespace TestProject.TaskLibrary.Tasks.Lesson7
{
    public class Task1_3 : IRunnable
    {
        public void Run(ILog logger)
        {
            var people = new List<Person>
            {
                new Person("Oleksandr", 18, new List<string>{ "098","095"}),
                new Person("Pavlo", 17, new List<string>{ "097","095"}),
                new Person("Maks", 20, new List<string>{ "063","095"}),
                new Person("Yarya", 19, new List<string>{ "098","066"}),
                new Person("Romko", 21, new List<string>{ "067","095"}),
            };

            Console.WriteLine("Name and Age of people:");
            Console.WriteLine(string.Join("\n", people.Select(x => x.Name + " " + x.Age)));

            people.AddRange(new List<Person>
            {
                new Person("Petro", 15, new List<string> { "097", "095" }),
                new Person("Nadia", 32, new List<string> { "097", "095" })
            });
            var numbers = people.SelectMany(x => x.PhoneNumbers);
            Console.WriteLine("Phone numbeer of all people:");
            Console.WriteLine(string.Join("\n", numbers));

            Console.WriteLine("Phone numbeer of people which age less than 20:");
            var olderThan = people.Where(x => x.Age < 20).SelectMany(x => x.PhoneNumbers);
            Console.WriteLine(string.Join("\n", olderThan));
        }
    }
}
