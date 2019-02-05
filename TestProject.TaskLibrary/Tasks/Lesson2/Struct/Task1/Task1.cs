using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task1
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Person person1 = new Person();

            Console.Write("Input name: ");
            person1.Name = Console.ReadLine();
            Console.Write("Input surname: ");
            person1.Surname = Console.ReadLine();
            Console.Write("Input age: ");
            person1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(person1.AgeChecker(12));
            Console.WriteLine(person1.AgeChecker(9));
        }
    }
}
