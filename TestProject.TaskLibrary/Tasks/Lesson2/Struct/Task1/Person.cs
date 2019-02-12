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

        /// <summary>
        /// A method that compares age.
        /// </summary>
        /// <param name="n">The age with which the person's age will be compared</param>
        /// <returns>formatеed string {Name} {Surname}  younger than {n} or {Name} {Surname} older than {n}</returns>
        public string AgeCheck(int n)
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
