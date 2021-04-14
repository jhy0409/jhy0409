using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap05_Answer_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textList = new List<string>();
            textList.Add("김가가");
            textList.Add("김라마");
            textList.Add("바사아");
            textList.Add("자차카");

            label1.Text = "";
            label1.Text = textList[new Random().Next(textList.Count)];

        }
    }
}
