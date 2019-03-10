using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            Person person1 = new Person();

            logger.Write("Input name: ");
            person1.Name = logger.Read();
            logger.Write("Input surname: ");
            person1.Surname = logger.Read();
            logger.Write("Input age: ");
            person1.Age = Convert.ToInt32(logger.Read());

            logger.Write(person1.AgeCheck(12));
            logger.Write(person1.AgeCheck(9));
        }
    }
}
