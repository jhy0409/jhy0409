using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이름 1", grade = 1 });

            Student s = new Student() { name = "이름 2", grade = 2 };
            students.Add(s);

            Student ss = new Student();
            ss.name = "이름 3";
            ss.grade = 3;
            students.Add(ss);

            students.Add(new Student() { name = "이름 4", grade = 4 });
            students.Add(new Student() { name = "이름 5", grade = 1 });
            students.Add(new Student() { name = "이름 6", grade = 2 });

            string names = "";
            for (int i = 0; i < students.Count; i++)
            {
                names += students[i].name + ", "+students[i].grade+" \n";
            }
            MessageBox.Show(names);
        }
    }
}
