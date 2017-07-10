using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jnit.Training.Business.Entities
{
    public class Teacher
    {
        public long Id
        {
            get;
            set;
        }

        public string Name { get; set; }
        public string Grade { get; set; }
    }
}
