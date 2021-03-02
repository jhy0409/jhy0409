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
        public MainForm()
        {
            InitializeComponent(); //컴포넌트 초기화
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void addrView_Click(object sender, EventArgs e)
        {

        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {

        }

        private void addrDel_Click(object sender, EventArgs e)
        {

        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {

        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
