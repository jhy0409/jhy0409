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
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void showList()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                upList.Items.Add(new ListViewItem(
                    new string[] {
                        (i+1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email
                    }
                ));
            }
            setRowColor(upList, Color.White, Color.LightGray);
            int index = upList.Items.Count - 1;
            upList.Items[index].Focused = true;
            upList.EnsureVisible(index);
        }

        private void setRowColor(ListView list,
            Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
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

        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            List<Student> list = sc.getList();

            if (upList.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
            else //선택 항목이 있음
            {
                int n = upList.SelectedItems[0].Index;
                string id = list[n].Id;

                if (upName.Text.Any(x => char.IsWhiteSpace(x) == true)) // 공백있을 시 텍스트박스, 선택된 항목 값 초기화
                {
                    MessageBox.Show("공백을 포함할 수 없음");
                    upName.Text = string.Empty;
                    upTel.Text = string.Empty;
                    upAddr.Text = string.Empty;
                    upEmail.Text = string.Empty;

                    upList.Items[n].Selected = false;
                    upList.Items[n].Focused = false;

                    return;
                }
                else // 이름에 공백값이 없음
                {
                    for (int i = 0; i < list.Count; i++) // 사람 수 만큼 일치 id조회
                    {
                        if (id.Equals(list[i].Id)) // 1. 선택항목의 아이디, list의 아이디가 같고
                        {
                            if (list[i].Name != upName.Text) // 3. 문자 값이 기존과 다르면 설정한다. -------------- 이름
                            {
                                list[i].Name = upName.Text;
                                upList.SelectedItems[0].SubItems[1].Text = upName.Text;
                            }

                            if (list[i].Tel != upTel.Text) // 3. 문자 값이 기존과 다르면 설정한다. ---------------- 전화
                            {
                                list[i].Tel = upTel.Text;
                                upList.SelectedItems[0].SubItems[2].Text = upTel.Text;
                            }

                            if (list[i].Address != upAddr.Text) // 3. 문자 값이 기존과 다르면 설정한다. ----------- 주소
                            {
                                list[i].Address = upAddr.Text;
                                upList.SelectedItems[0].SubItems[3].Text = upAddr.Text;
                            }

                            if (list[i].Email != upEmail.Text) // 3. 문자 값이 기존과 다르면 설정한다. ------------- 메일
                            {
                                list[i].Email = upEmail.Text;
                                upList.SelectedItems[0].SubItems[4].Text = upEmail.Text;
                            }
                        }
                    }
                }
            }
        }
    }
}
