using Chapter05.cont;
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

            label_num1.Text = "번호 1";
            thisPcent_1.Text = "-";
            label_num2.Text = "번호 2";
            thisPcent_2.Text = "-";
            label_num3.Text = "번호 3";
            thisPcent_3.Text = "-";

            label_num4.Text = "번호 4";
            thisPcent_4.Text = "-";
            label_num5.Text = "번호 5";
            thisPcent_5.Text = "-";
            label_num6.Text = "번호 6";
            thisPcent_6.Text = "-";
            label_num7.Text = "번호 7";
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
    }
}
