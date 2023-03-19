using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public interface InterfaceStudent
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string group { get; set; }
        public double averageMark { get; set; }

        public void GetScholarship();

    }
}
