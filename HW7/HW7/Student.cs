using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Student: InterfaceStudent
    {
       public Student(string firstName, string lastName, string group, double averageMark) 
        {
            this.firstName = firstName;
            this.lastName  = lastName;
            this.group  = group;
            this.averageMark = averageMark;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string group { get; set; }
        public double averageMark { get; set; }

        virtual public void getScholarship()
        {
            if(this.averageMark == 5)
            {
                Console.WriteLine("2000 UAH");
            }
            else
            {
                Console.WriteLine("1900 UAH");
            }
            
        }
    }
}
