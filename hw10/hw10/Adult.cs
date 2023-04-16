using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Adult
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Adult(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        } 
    }
}
