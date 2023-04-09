using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Document
    {
        public string Name { get; set;}
        

        public Document() {
            this.Name = string.Empty;
        }   
        public Document(string fileName)
        {
            this.Name = fileName;
        }
    }
}
