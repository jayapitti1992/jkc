using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    public class Student
    {

        public long Id
        {
            get;
            set;
        }
        
        public string Name { get; set; }


        public byte Age
        {
            get; set;
        }
        
        public Dictionary<string, double> Grades { get; set; }


        
    }
}


