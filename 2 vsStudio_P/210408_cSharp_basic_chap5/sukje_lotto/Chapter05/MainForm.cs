﻿using Chapter05.cont;
using System;
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
    public partial class MainForm : Form
    {
        Handler hd = new Handler();
        public MainForm()
        {
            InitializeComponent();
            initLabelText();
            showHelp();
        }


        private void button_test_Click(object sender, EventArgs e)
        {
            try
            {

                if (makeRandTxtBox.Text == "확률무시 랜덤생성 수")
                {
                    makeRandTxtBox.Text = "0";
                }

                int makeR = int.Parse(makeRandTxtBox.Text);
                if (makeR > 7 || makeR < 0)
                {
                    MessageBox.Show("0~7사이의 값을 입력하세요\n 0으로 다시 초기화합니다.");
                    makeRandTxtBox.Text = "0";
                    return;
                }
                hd.makeLotto(makeR);
            }
            catch (FormatException)
            {
                MessageBox.Show("유효하지 않은 값입니다.");
                makeRandTxtBox.Text = "0";
                return;
            }

            int[] gluck = hd.GoodLuck;
            label_num1.Text = gluck[0].ToString();
            thisPcent_1.Text = ((hd.hwaklyul(gluck[0])) * 10).ToString() + "%";

            label_num2.Text = gluck[1].ToString();
            thisPcent_2.Text = ((hd.hwaklyul(gluck[1])) * 10).ToString() + "%";

            label_num3.Text = gluck[2].ToString();
            thisPcent_3.Text = ((hd.hwaklyul(gluck[2])) * 10).ToString() + "%";

            label_num4.Text = gluck[3].ToString();
            thisPcent_4.Text = ((hd.hwaklyul(gluck[3])) * 10).ToString() + "%";

            label_num5.Text = gluck[4].ToString();
            thisPcent_5.Text = ((hd.hwaklyul(gluck[4])) * 10).ToString() + "%";

            label_num6.Text = gluck[5].ToString();
            thisPcent_6.Text = ((hd.hwaklyul(gluck[5])) * 10).ToString() + "%";

            label_num7.Text = gluck[6].ToString();
            thisPcent_7.Text = ((hd.hwaklyul(gluck[6])) * 10).ToString() + "%";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label_num1.Text = "1";
            thisPcent_1.Text = "-";
            label_num2.Text = "2";
            thisPcent_2.Text = "-";
            label_num3.Text = "3";
            thisPcent_3.Text = "-";

            label_num4.Text = "4";
            thisPcent_4.Text = "-";
            label_num5.Text = "5";
            thisPcent_5.Text = "-";
            label_num6.Text = "6";
            thisPcent_6.Text = "-";
            label_num7.Text = "7";
            thisPcent_7.Text = "-";


            if (makeRandTxtBox.Text == "")
            {
                makeRandTxtBox.Text = "확률무시 랜덤생성 수";
                makeRandTxtBox.ForeColor = Color.Gray;
            }
        }

        private void makeRandTxtBox_Enter(object sender, EventArgs e)
        {
            if (makeRandTxtBox.Text.Length > 0)
            {
                makeRandTxtBox.Text = string.Empty;
                makeRandTxtBox.ForeColor = Color.Black;
            }
        }

        private void initLabelText()
        {
            var pos1 = this.PointToScreen(label_num1.Location); // 스택오버플로우 참고.. 라벨텍스트 배경색 투명으로
            pos1 = gongImg_1.PointToClient(pos1);
            label_num1.Parent = gongImg_1;
            label_num1.Location = pos1;
            label_num1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label_num2.Location);
            pos2 = gongImg_2.PointToClient(pos2);
            label_num2.Parent = gongImg_2;
            label_num2.Location = pos2;
            label_num2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label_num3.Location);
            pos3 = gongImg_3.PointToClient(pos3);
            label_num3.Parent = gongImg_3;
            label_num3.Location = pos3;
            label_num3.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label_num4.Location);
            pos4 = gongImg_4.PointToClient(pos4);
            label_num4.Parent = gongImg_4;
            label_num4.Location = pos4;
            label_num4.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(label_num5.Location);
            pos5 = gongImg_5.PointToClient(pos5);
            label_num5.Parent = gongImg_5;
            label_num5.Location = pos5;
            label_num5.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(label_num6.Location);
            pos6 = gongImg_6.PointToClient(pos6);
            label_num6.Parent = gongImg_6;
            label_num6.Location = pos6;
            label_num6.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(label_num7.Location);
            pos7 = gongImg_7.PointToClient(pos7);
            label_num7.Parent = gongImg_7;
            label_num7.Location = pos7;
            label_num7.BackColor = Color.Transparent;
        }

        private void showHelp()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip tTip = new ToolTip();

            // Set up the delays for the ToolTip.
            tTip.AutoPopDelay = 6000;
            tTip.InitialDelay = 500;
            tTip.ReshowDelay = 10000;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tTip.ShowAlways = false;


            // Set up the ToolTip text for the Button and Checkbox.
            tTip.SetToolTip(this.HelpLabelTxt, "[사용법]\n1. 랜덤생성할 수를 1~7사이의 값을 입력하세요.\n\n2. 유효하지 않은 값 입력시 자동으로 랜덤생성 수는 0으로 초기화(문자나 공백 등)\n\n* 랜덤수가 0일때 기본값으로 전체회차의 90%이상 당첨번호가 랜덤생성 됩니다.");
        }


    }
}
