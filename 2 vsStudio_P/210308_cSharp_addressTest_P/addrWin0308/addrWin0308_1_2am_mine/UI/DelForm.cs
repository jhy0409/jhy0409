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
    public partial class DelForm : MaterialForm
    {
        List<Student> list = StudentHandler.getInst().getList();
        public DelForm()
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
                        (i + 1).ToString(), list[i].Id,list[i].Name, list[i].Tel, list[i].Address, list[i].Email
                        //(i + 1).ToString(), "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"
                    }
                ));
            }
            setRowColor(listView, Color.White, Color.FromArgb(245, 246, 247));
            int index = listView.Items.Count - 1; //마지막 행 표시
            //listView.Items[0].Focused = true;

            listView.Items[0].Selected = true;
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

        private void delForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void addCancle_Click(object sender, EventArgs e)
        {
            listView.Update();
            Close();
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            

            if (listView.Items.Count <= 0) // 지울 개수가 없을 때 
            {
                MessageBox.Show("항목이 없습니다.");
                return;
            }

            if (list.Count != 0)
            {
                // 선택이 없을 때
                int index = listView.FocusedItem.Index;
                string id = list[index].Id;

                if (listView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("선택항목이 없습니다.");
                    return;
                }
                else
                {
                    for (int i = 0; i < list.Count; i++) // 원본 리스트에서도 삭제
                    {
                        if (id.Equals(list[i].Id))
                            list.RemoveAt(i);
                    }
                    listView.SelectedItems[0].Remove(); // 뷰에서 지우고
                }
            }
        }
    }
}
