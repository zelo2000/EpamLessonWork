using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task1
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            Person person1 = new Person();

            Logger.Write("Input name: ");
            person1.Name = Logger.Read();
            Logger.Write("Input surname: ");
            person1.Surname = Logger.Read();
            Logger.Write("Input age: ");
            person1.Age = Convert.ToInt32(Logger.Read());

            Logger.Write(person1.AgeCheck(12));
            Logger.Write(person1.AgeCheck(9));
        }
    }
}
