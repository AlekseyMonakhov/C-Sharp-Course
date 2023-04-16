using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int BirthYear { get;private set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            BirthYear = DateTime.Now.Year - age;
        }

        public override string? ToString()
        {
            return string.Concat(Name, " ", Surname, " ", Age);
        }
    }
}
