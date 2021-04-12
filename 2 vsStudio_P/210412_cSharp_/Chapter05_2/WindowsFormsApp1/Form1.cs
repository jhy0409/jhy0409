using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        static Random r = new Random();
        int rndMun1 = r.Next(3) + 1;
        int comRCP;
        int userRCP;

        const string GAWI = "가위";
        const string BAWI = "바위";
        const string BO = "보";

        const string COM_WIN = "컴퓨터 이김";
        const string PRSN_WIN = "사람 이김";
        const string RCP_BIGIM = "비겼습니다.";

        List<int> munje4 = new List<int>();
        List<string> rndMunjang = new List<string>();

        public MainForm()
        {
            InitializeComponent();


            rndMunjang.Add("랜덤 내용입니다 1");
            rndMunjang.Add("랜덤 내용입니다 2");
            rndMunjang.Add("랜덤 내용입니다 3");
            rndMunjang.Add("랜덤 내용입니다 4");
        }

        // 문제 1
        private void ok_btn1_Click(object sender, EventArgs e)
        {
            int bigyo = int.Parse(ansMun1.Text);

            if (bigyo == rndMun1)
            {
                MessageBox.Show("정답입니다.\n랜덤수가 다시 생성됩니다.");
                ansMun1.Text = string.Empty;
                rndMun1 = r.Next(3) + 1;
            }
            else if (bigyo > rndMun1)
            {
                MessageBox.Show("랜덤수가 더 작습니다.");
                ansMun1.Text = string.Empty;
            }
            else if (bigyo < rndMun1)
            {
                MessageBox.Show("랜덤수가 더 큽니다.");
                ansMun1.Text = string.Empty;
            }
        }

        private void btn_m2_gawi_Click(object sender, EventArgs e)
        {
            comRCP = r.Next(3);
            userRCP = 0;
            label4.Text = $"{GAWI} & 0";
            mun2_RCPResult(userRCP, comRCP);
        }

        private void btn_m2_bawi_Click(object sender, EventArgs e)
        {
            comRCP = r.Next(3);
            userRCP = 1;
            label4.Text = $"{BAWI} & 1";
            mun2_RCPResult(userRCP, comRCP);
        }

        private void btn_m2_bo_Click(object sender, EventArgs e)
        {
            comRCP = r.Next(3);
            userRCP = 2;
            label4.Text = $"{BO} & 2";
            mun2_RCPResult(userRCP, comRCP);
        }

        public void mun2_RCPResult(int userRCP, int comRCP)
        {
            Button[] btn = { btn_m2_Comgawi, btn_m2_Combawi, btn_m2_Combo };

            for (int i = 0; i < btn.Length; i++)
            {
                if (comRCP == i)
                {
                    btn[i].BackColor = Color.FromArgb(115,130,50);
                    if (i == 0)
                    {
                        label1.Text = $"{GAWI} & {i}";
                    }
                    else if (i == 1)
                    {
                        label1.Text = $"{BAWI} & {i}";
                    }
                    else if (i == 2)
                    {
                        label1.Text = $"{BO} & {i}";
                    }
                }
            }
            
            switch (userRCP)
            {
                case 0: // 사용자 : 가위
                    switch (comRCP)
                    {
                        case 0: //컴 : 가위
                            rcpResult.Text = RCP_BIGIM;
                            break;
                        case 1: //컴 : 바위
                            rcpResult.Text = COM_WIN;
                            break;
                        case 2: //컴 : 보
                            rcpResult.Text = PRSN_WIN;
                            break;
                    }
                    break;

                case 1: // 사용자 : 바위
                    switch (comRCP)
                    {
                        case 0: //컴 : 가위
                            rcpResult.Text = PRSN_WIN;
                            break;
                        case 1: //컴 : 바위
                            rcpResult.Text = RCP_BIGIM;
                            break;
                        case 2: //컴 : 보
                            rcpResult.Text = COM_WIN;
                            break;
                    }
                    break;

                case 2: // 사용자 : 보
                    switch (comRCP)
                    {
                        case 0: //컴 : 가위
                            rcpResult.Text = COM_WIN;
                            break;
                        case 1: //컴 : 바위
                            rcpResult.Text = PRSN_WIN;
                            break;
                        case 2: //컴 : 보
                            rcpResult.Text = RCP_BIGIM;
                            break;
                    }
                    break;
            }
            
            for (int i = 0; i < btn.Length; i++)
            {
                if (comRCP == i)
                {
                    btn[i].BackColor = Color.FromArgb(130, 203, 226);
                }
                else
                {
                    btn[i].BackColor = Color.FromArgb(240, 240, 240);
                }
            }
        }

        private void addString_11_Click(object sender, EventArgs e)
        {
            munje4.Add(11);
            chulyok(munje4);
        }

        private void addString_22_Click(object sender, EventArgs e)
        {
            munje4.Add(22);
            chulyok(munje4);
        }

        private void addString_33_Click(object sender, EventArgs e)
        {
            munje4.Add(33);
            chulyok(munje4);
        }

        private void delString_11_Click(object sender, EventArgs e)
        {
            sakje(munje4, 11);
            chulyok(munje4);
        }


        private void delString_22_Click(object sender, EventArgs e)
        {
            sakje(munje4, 22);
            chulyok(munje4);
        }

        private void delString_33_Click(object sender, EventArgs e)
        {
            sakje(munje4, 33);
            chulyok(munje4);
        }


        public void chulyok(List<int> list)
        {
            viewList.Text = string.Empty;
            string temp = "";
            for (int i = 0; i < list.Count; i++)
            {
                temp += list[i].ToString() + "  ";
            }
            viewList.Text = temp;
        }

        public void sakje(List<int> list, int Num)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Num==list[i])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private void ok_btn3_Click(object sender, EventArgs e)
        {
            viewList3.Text = rndMunjang[r.Next(rndMunjang.Count-1)];
        }
    }
}
