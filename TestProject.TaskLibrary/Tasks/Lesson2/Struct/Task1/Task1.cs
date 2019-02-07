﻿using System;
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
            person1.Name = Console.ReadLine();
            logger.Write("Input surname: ");
            person1.Surname = Console.ReadLine();
            logger.Write("Input age: ");
            person1.Age = Convert.ToInt32(Console.ReadLine());

            logger.Write(person1.AgeChecker(12));
            logger.Write(person1.AgeChecker(9));
        }
    }
}
