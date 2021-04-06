using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mun1_sibiji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Uri fileUri = new Uri(System.Windows.Forms.Application.StartupPath + "\\resource\\byline.PNG");
        //byline_image1.Source = new BitmapImage(fileUri);


        private void input_btn_Click(object sender, EventArgs e)
        {

            /*Console.Write("태어난년도 입력 :");
            int sibiji = (int.Parse(Console.ReadLine())) % 12;*/
            try
            {
                int sibiji = int.Parse(birthYear.Text) % 12;

                /*자(쥐)      축(소)    인(호랑이)
                  묘(토끼)    진(용)    사(뱀)
                  오(말)      미(양)    신(원숭이) 
                  유(닭)      술(개)    해(돼지)*/

                string birthTTi = "";

                switch (sibiji)
                {
                    case 0:
                        Console.WriteLine("원숭이");
                        pictureBox1.Load(@".\img\mnk.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "원숭이띠";

                        break;
                    case 1:
                        Console.WriteLine("닭띠");
                        pictureBox1.Load(@".\img\chk.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "닭띠";
                        break;
                    case 2:
                        Console.WriteLine("개띠");
                        pictureBox1.Load(@".\img\dog.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "개띠";
                        break;
                    case 3:
                        Console.WriteLine("돼지띠");
                        pictureBox1.Load(@".\img\pig.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "돼지띠";
                        break;

                    case 4:
                        Console.WriteLine("쥐띠");
                        pictureBox1.Load(@".\img\mouse.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "쥐띠";
                        break;
                    case 5:
                        Console.WriteLine("소띠");
                        pictureBox1.Load(@".\img\cow.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "소띠";
                        break;
                    case 6:
                        Console.WriteLine("호랑이띠");
                        pictureBox1.Load(@".\img\horang.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "호랑이띠";
                        break;
                    case 7:
                        Console.WriteLine("토끼");
                        pictureBox1.Load(@".\img\rabb.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "토끼";
                        break;

                    case 8:
                        Console.WriteLine("용띠");
                        pictureBox1.Load(@".\img\drg.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "용띠";
                        break;
                    case 9:
                        Console.WriteLine("뱀띠");
                        pictureBox1.Load(@".\img\snk.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "뱀띠";
                        break;
                    case 10:
                        Console.WriteLine("말띠");
                        pictureBox1.Load(@".\img\hrs.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "말띠";
                        break;
                    case 11:
                        Console.WriteLine("양띠");
                        pictureBox1.Load(@".\img\shp.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        birthTTi = "양띠";
                        break;
                }
                resultText.Text = birthTTi + "입니다.";
            }
            catch (FormatException)
            {
                if (birthYear.Text.Trim().Length == 0)
                {
                    MessageBox.Show("값을 입력하세요.");
                }
                else
                {
                    MessageBox.Show("유효하지 않은 값입니다.");
                }
            }

        }
    }
}
