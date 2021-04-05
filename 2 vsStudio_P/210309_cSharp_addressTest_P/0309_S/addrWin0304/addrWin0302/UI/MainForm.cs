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
    {
        MyMenu menu = new MyMenu();
        StudentHandler sc = new StudentHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년3월2일 by hack4ork");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            //sc.addItem();
            new AddForm().ShowDialog();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            //sc.viewItem();
            new ViewForm(sc).ShowDialog();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터 생성",
                "랜덤하게 데이터를 생성할 갯수를 입력하세요",
                "0");
            if (cnt == "") return;
            sc.randData(Convert.ToInt32(cnt));
        }

        private void addDel_Click(object sender, EventArgs e)
        {
            sc.delItem();
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            new UpdateForm(sc).ShowDialog();
        }

        private string myInputBox(string title, 
            string body, string prompt)
        {
            string input = Microsoft.VisualBasic.
                Interaction.InputBox(title, body, prompt,
                    -1, -1);
            return input;
        }
    }
}
