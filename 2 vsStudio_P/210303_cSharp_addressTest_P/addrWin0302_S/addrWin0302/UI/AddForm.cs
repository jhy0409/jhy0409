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
    //public partial class AddForm : MaterialForm
    partial class AddForm : MaterialForm
    {
        StudentHandler sc;        

        public AddForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            if (addName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }

            if (addTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }

            if (addAddress.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }

            if (addEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }

            Random r = new Random();
            sc.getList().Add(
                new Student(sc.getId(),
                addName.Text, 
                addTel.Text, addAddress.Text, 
                addEmail.Text));
            Close();
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
