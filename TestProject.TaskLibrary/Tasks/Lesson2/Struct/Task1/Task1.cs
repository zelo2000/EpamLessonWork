using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog loger)
        {
            Person person1 = new Person();

            loger.Write("Input name: ");
            person1.Name = Console.ReadLine();
            loger.Write("Input surname: ");
            person1.Surname = Console.ReadLine();
            loger.Write("Input age: ");
            person1.Age = Convert.ToInt32(Console.ReadLine());

            loger.Write(person1.AgeChecker(12) + "\n");
            loger.Write(person1.AgeChecker(9) + "\n");
        }
    }
}
