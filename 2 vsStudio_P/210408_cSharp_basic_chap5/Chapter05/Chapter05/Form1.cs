﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_test.Text = "점심먹으러가시죠";
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");

            Random r = new Random();
            //0이상 10미만의 숫자 하나 출력 Next(10)
            //1이상 46미만의 숫자 하나 출력 Next(1,46)
            MessageBox.Show(r.Next(1,46).ToString());
            //MessageBox.Show의 괄호 안에는 string 타입만 들어감.

            label_num1.Text = r.Next(10).ToString();
            label_num2.Text = r.Next(10).ToString();
            label_num3.Text = r.Next(10).ToString(); 
            label_num4.Text = r.Next(10).ToString();
            label_num5.Text = r.Next(10).ToString();
            label_num6.Text = r.Next(10).ToString();
        }
    }
}
