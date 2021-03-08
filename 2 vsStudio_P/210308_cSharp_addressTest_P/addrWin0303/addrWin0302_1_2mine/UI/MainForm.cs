using addrWin0302.UI;
using adressTest0218.control;
using adressTest0218.util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302
{
    public partial class MainForm : MaterialForm
    {// 기본생성자, '[현재] : [부모 폼]'이 상속, 창에서 f7

        MyMenu mm = new MyMenu();
        StudentHandler sc = new StudentHandler();
        public MainForm()
        {
            InitializeComponent(); //컴포넌트 초기화(화면ui)
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Environment.Exit(0);
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년 3월 2일 이름");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            //sc.addItem(); // 싱글톤 남발하기보다 매개변수(객체전달)로 연습 주로할 것★
            new AddForm().ShowDialog();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            if (StudentHandler.getInst().getList().Count!=0)
            {
                StudentHandler.getInst().viewItem();
                new ViewForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("주소록 정보가 없습니다. \n추가하거나 랜덤데이터를 생성하세요");
                return;
            }
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 갯수를 입력", "0");
            if (cnt == "") return; // void시 함수 탈출
            StudentHandler.getInst().randData(Convert.ToInt32(cnt));
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            StudentHandler.getInst().delItem();
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            StudentHandler.getInst().delItemAll();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            StudentHandler.getInst().updateItem();
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }
    }
}
