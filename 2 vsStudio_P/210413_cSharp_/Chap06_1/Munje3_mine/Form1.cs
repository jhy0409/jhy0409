using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munje3_mine
{
    public partial class Form1 : Form
    {
        const double PI = 3.14;
        const double CHANGE_POUND = 2.20462262;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // -------------------------------------
        {
            if (time >= 3)
            {
                MessageBox.Show("실패");
                time = 0;
                return;
            }
            mun1_resLabel.Text = inchToCm(int.Parse(mun1_insTxtBox.Text))+" cm"; 
        }

        private void button2_Click(object sender, EventArgs e)
        { mun2_resLabel.Text = kgToPound(int.Parse(mun2_insTxtBox.Text))+" pound"; }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] calc = circleCalc(int.Parse(mun3_insTxtBox.Text));
            if (calc[0] == -1)
            {
                MessageBox.Show("양수값을 입력하세요");
                mun3_insTxtBox.Text = "";
                return;
            }
                
            mun3_resLabel.Text = $"원둘레 : {calc[0]}cm\n원넓이 : {calc[1]}cm";
        }

        private double inchToCm(int inch)
        { return (double)inch * 2.54; }

        private double kgToPound(int kg)
        { return kg * CHANGE_POUND; }

        private double[] circleCalc(int R)
        {
            double[] circleCalc = new double[2];
            if (R <= 0)
            {
                circleCalc[0] = -1;
                return circleCalc;
            }
            circleCalc[0] = 2 * PI * R;
            circleCalc[1] = PI * R * R;
            return circleCalc;
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label5.Text = time+"초 경과했습니다.";
        }
    }
}
