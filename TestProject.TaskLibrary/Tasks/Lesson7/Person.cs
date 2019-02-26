using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }

        public Person(string name, int age, IEnumerable<string> pn)
        {
            Name = name;
            Age = age;
            PhoneNumbers = pn;
        }
    }
}
