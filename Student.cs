using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Student
    {
        int id { get; set; }
        string name { get; set; }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
