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
    public partial class EditForm : MaterialForm
    {
        List<Student> list = StudentHandler.getInst().getList(); // list배열 가져옴
        public EditForm()
        {
            InitializeComponent();
        }

        private void initListView()
        {
            int size = StudentHandler.getInst().getList().Count;
            List<Student> list = StudentHandler.getInst().getList();

            for (int i = 0; i < size; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i + 1).ToString(), list[i].Id, list[i].Name, list[i].Tel, list[i].Address, list[i].Email
                        //(i + 1).ToString(), "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"
                    }
                ));
            }
            setRowColor(listView, Color.White, Color.FromArgb(245, 246, 247));
            int index = listView.Items.Count - 1; //마지막 행 표시
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);

            SetHeight(listView, 24);
        }
        private void SetHeight(ListView LV, int height)
        {
            // listView 높이 지정
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;
        }

        private void setRowColor(ListView list, Color color1, Color color2) // 표 배경 교차채색
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
        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void addOk_Click(object sender, EventArgs e)
        {
            if (EditName.Text.Trim().Length == 0 && EditTel.Text.Trim().Length == 0
                && EditAddr.Text.Trim().Length == 0 && EditEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("입력한 데이터가 없습니다.");
                return;
            }
            int index = listView.FocusedItem.Index; // 리스트뷰에서 선택된 인덱스 *
            string id = list[index].Id; // *의 아이디

            if (EditName.Text.Trim().Length != 0) // 이름
            {
                listView.SelectedItems[0].SubItems[2].Text = EditName.Text; // 리스트 뷰에서 수정
                for (int i = 0; i < list.Count; i++)
                {
                    if (id.Equals(list[i].Id)) // (조건) 리스트아이디와 선택된 아이디가 같을때
                    {
                        list[i].Name = EditName.Text; // 리스트 이름 수정
                    }
                }
            }
            if (EditTel.Text.Trim().Length != 0) // 전화
            {
                listView.SelectedItems[0].SubItems[3].Text = EditTel.Text;
                for (int i = 0; i < list.Count; i++)
                {
                    if (id.Equals(list[i].Id))
                    {
                        list[i].Tel = EditTel.Text;
                    }
                }
            }
            if (EditAddr.Text.Trim().Length != 0) // 주소
            {
                listView.SelectedItems[0].SubItems[4].Text = EditAddr.Text;
                for (int i = 0; i < list.Count; i++)
                {
                    if (id.Equals(list[i].Id))
                    {
                        list[i].Address = EditAddr.Text;
                    }
                }
            }

            if (EditEmail.Text.Trim().Length != 0) // 메일
            {
                listView.SelectedItems[0].SubItems[5].Text = EditEmail.Text;
                for (int i = 0; i < list.Count; i++)
                {
                    if (id.Equals(list[i].Id))
                    {
                        list[i].Email = EditEmail.Text;
                    }
                }
            }

            EditName.Text = string.Empty;
            EditTel.Text = string.Empty;
            EditAddr.Text = string.Empty;
            EditEmail.Text = string.Empty;

        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

    }
}
