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
    partial class AddForm : MaterialForm //pu pa
    {
        StudentHandler sc;

        public AddForm() // 싱글톤 일때 사용
        {
            InitializeComponent();
        }
        public AddForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            if (addName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요");
            }

            if (addTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요");
            }

            if (addAddr.Text == "")
            {
                MessageBox.Show("주소를 입력하세요");
            }

            if (addEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요");
            }
            else
            {
                //sc.getList().Add(new Student(sc.getId(), addName.Text, addTel.Text, addAddr.Text, addEmail.Text)); // 기존
                StudentHandler.getInst().getList().Add( // 싱글톤 사용
                    new Student(
                        StudentHandler.getInst().getId(), 
                        addName.Text, 
                        addTel.Text, addAddr.Text, 
                        addEmail.Text));
                MessageBox.Show("정보가 정상적으로 입력되었습니다.");
                Close();
            }
            
        }

        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
