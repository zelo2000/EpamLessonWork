using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task1
{
    struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string AgeChecker(int n)
        {
            if (n > Age)
            {
                return $"{Name} {Surname}  younger than {n}\n";
            }
            else
            {
                return $"{Name} {Surname} older than {n}\n";
            }
        }
    }
}
