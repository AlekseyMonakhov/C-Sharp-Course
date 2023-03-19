using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Aspirant : Student
    {
        public Aspirant(string firstName, string lastName, string group, double averageMark) : base(firstName, lastName, group, averageMark){}
        public override void GetScholarship()
        {
            if (this.averageMark == 5)
            {
                Console.WriteLine("2500 UAH");
            }
            else
            {
                Console.WriteLine("2200 UAH");
            }
        }
    }
}
