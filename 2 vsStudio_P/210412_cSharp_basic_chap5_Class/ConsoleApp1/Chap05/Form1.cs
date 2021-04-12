using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap05
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[] randomNumbers = new int[6];
        public Form1() // 4/8
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 숫자 순서 정렬 방법1
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(200)+1;
            }

            Label[] label = { label1, label2, label3, label4, label5, label6 };

            /*int j = 0;
            Array.Sort(randomNumbers);
            foreach (var item in randomNumbers)
            {
                Console.Write($"{j + 1}번째 : {item}   ");
                label[j].Text = item.ToString();
                j++;
            }*/


            // 숫자 순서 정렬 방법2 (버블정렬)
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                for (int j = 0; j < randomNumbers.Length - 1; j++)
                {
                    if (randomNumbers[j] > randomNumbers[j + 1])
                    {
                        int temp = randomNumbers[j];
                        randomNumbers[j] = randomNumbers[j + 1];
                        randomNumbers[j + 1] = temp;
                    }
                }
            }
            int k = 0;
            foreach (var item in randomNumbers)
            {
                Console.Write($"{k + 1}번째 : {item}   ");
                label[k].Text = item.ToString();
                k++;
            }
        }
    }
}