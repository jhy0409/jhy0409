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
    {// 기본생성자, ':'이 상속, 창에서 f7

        MyMenu mm = new MyMenu();
        StudentHandler sc = new StudentHandler();
        public MainForm()
        {
            InitializeComponent(); //컴포넌트 초기화(화면ui)
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Environment.Exit(0);
            //sc.addItem();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년 3월 2일 이름");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            //sc.addItem();
            new AddForm(sc).ShowDialog();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            sc.viewItem();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            sc.randData();
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            sc.delItem();
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            sc.updateItem();
        }
    }
}
