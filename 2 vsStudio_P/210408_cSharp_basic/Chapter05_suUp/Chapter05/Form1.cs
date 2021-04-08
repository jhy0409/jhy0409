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
        Random r = new Random();
        List<LottoN> lottoNumNIndex = new List<LottoN>();
        double[] joncheHwaklyul = { 9.3, 8.7, 8.7, 9.3,  8.4,
                                        8.4, 8.4, 8.4, 7, 9,
                                        8.6, 9.2, 9.3, 8.7, 8.4,

                                        8.4, 9.3, 8.9, 8.5, 9,
                                        8.5, 7.1, 7.5, 8.6, 8,
                                        8.8, 9.5, 7.7, 7.4, 8.3,

                                        8.7, 7.7, 9.1, 9.4, 8.2,
                                        8.4, 8.6, 8.9, 9.1, 8.9,
                                        7.6, 8.3, 10, 8.3, 8.5};
        int[] goodLuck = new int[7];

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("hellow World");

            button_test.Text = "바밥밥";
            iplyok();



        }
        public void makeLotto()
        {
            for (int i = 0; i < 7; i++)
            {
                goodLuck[i] = r.Next(1, 46);
                Console.WriteLine($"현재번호 : {goodLuck[i]}");

                if (i < 5 && hwaklyul(goodLuck[i]) < 9) // 5번째 숫자까지는 번호당 확률 70%이상
                {
                    i--;
                }

                if(i>=5) // 마지막 번호 2개는 랜덤
                {
                    goodLuck[i] = r.Next(1, 46);
                }
                for (int j = 0; j < i; j++)
                {
                    if (goodLuck[i] == goodLuck[j])
                    {
                        i--;
                        Console.WriteLine($"{j + 1}번째 값 중복발생 : {goodLuck[j]}");
                    }
                }
            }
        }
        public void iplyok()
        {
            // 1~957회차 전체번호(1~45)별 확률 (로또 홈페이지 자료 참고)
            for (int i = 0; i < 45; i++)
            {
                lottoNumNIndex.Add(new LottoN((i + 1), joncheHwaklyul[i]));
            }
        }

        public double hwaklyul(int lotto)
        {
            int index = 0;
            for (int i = 0; i < lottoNumNIndex.Count; i++)
            {
                if (lottoNumNIndex[i].Num == lotto)
                {
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            return lottoNumNIndex[index].NumOfPercent;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hellow World");


            //0이상 10미만의 숫자 하나 출력
            //MessageBox.Show(r.Next(10).ToString());

            //1이상 46미만의 숫자 하나 출력
            //MessageBox.Show(r.Next(1,46).ToString());

            //MessageBox.Show의 괄호 안에는 string 타입만 들어감.
            makeLotto();

            label_num1.Text = goodLuck[0].ToString();
            thisPcent_1.Text = ((hwaklyul(goodLuck[0])) * 10).ToString() + "%";

            label_num2.Text = goodLuck[1].ToString();
            thisPcent_2.Text = ((hwaklyul(goodLuck[1])) * 10).ToString() + "%";

            label_num3.Text = goodLuck[2].ToString();
            thisPcent_3.Text = ((hwaklyul(goodLuck[2])) * 10).ToString() + "%";

            label_num4.Text = goodLuck[3].ToString();
            thisPcent_4.Text = ((hwaklyul(goodLuck[3])) * 10).ToString() + "%";

            label_num5.Text = goodLuck[4].ToString();
            thisPcent_5.Text = ((hwaklyul(goodLuck[4])) * 10).ToString() + "%";

            label_num6.Text = goodLuck[5].ToString();
            thisPcent_6.Text = ((hwaklyul(goodLuck[5])) * 10).ToString() + "%";

            label_num7.Text = goodLuck[6].ToString();
            thisPcent_7.Text = ((hwaklyul(goodLuck[6])) * 10).ToString() + "%";

        }

    }
}
