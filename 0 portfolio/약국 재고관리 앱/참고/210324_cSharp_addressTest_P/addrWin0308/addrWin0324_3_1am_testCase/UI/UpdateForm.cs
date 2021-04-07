using adressTest0218;
using adressTest0218.control;
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

namespace addrWin0302.UI
{
     partial class UpdateForm : MaterialForm
    {
        StudentHandler sc;
        MainForm form;

        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        public UpdateForm(StudentHandler sc, MainForm form)
        {
            InitializeComponent();
            this.sc = sc;
            this.form = form;
        }

        private void showList()
        {
            form.commShowList(upList);
        }

       

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void upList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (upList.SelectedItems.Count != 0)
            {
                int n = upList.SelectedItems[0].Index;
                string name = upList.Items[n].SubItems[1].Text;
                string tel = upList.Items[n].SubItems[2].Text;
                string addr = upList.Items[n].SubItems[3].Text;
                string email = upList.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0}", name);
                Console.WriteLine("전화: {0}", tel);
                Console.WriteLine("주소: {0}", addr);
                Console.WriteLine("메일: {0}", email);
                Console.WriteLine("--------------------");
                upName.Text = name;
                upTel.Text = tel;
                upAddr.Text = addr;
                upEmail.Text = email;
            }
        }
    }
}
