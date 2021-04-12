using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListManager
{
    class Student
    {
        public string name;
        public int grade;
        public Student()
        {

        }
        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }
}
