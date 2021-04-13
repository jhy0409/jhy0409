using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs();
        }
        private void bs()
        {
            MessageBox.Show("이름1");
        }

        private void bs(string name)
        {
            MessageBox.Show(name);
        }

        private void bs(string name, string name2)
        {
            MessageBox.Show(name+name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs(button2.Text, button1.Text);
        }

        // 오버로딩, 오버라이딩
        // 매개변수 숫자나 타입 다르면 같은 함수명 재사용 가능
    }
}
