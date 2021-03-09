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
    partial class DelForm : MaterialForm
    {
        StudentHandler sc;
        public DelForm()
        {
            InitializeComponent();
        }
        public DelForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetHeight(ListView LV, int height)
        {
            // listView 높이 지정
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;
        }

        private Boolean initListView()
        {
            //int size0 = sc.getList().Count;
            int size = sc.getList().Count;
            List<Student> list = sc.getList();

            for (int i = 0; i < size; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i + 1).ToString(), list[i].Name, list[i].Tel, list[i].Address, list[i].Email
                        //(i + 1).ToString(), "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"
                    }
                ));
            }
            setRowColor(listView, Color.White, Color.FromArgb(245, 246, 247));
            int index = listView.Items.Count - 1; //마지막 행 표시
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);

            SetHeight(listView, 24);

            return true;
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


        private void DelForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            List<Student> list = sc.getList();
            if (list.Count > 0)
            {
                int maxID = listView.Items.Count - 1;
                listView.Items[maxID].Selected = true;
                //listView.Items[maxID].Focused = true;
            }

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없음");
                return;
            }
            else
            {
                int n = listView.SelectedItems[0].Index;
                string id = list[n].Id;

                for (int i = 0; i < list.Count; i++)
                {
                    if (id.Equals(list[i].Id))
                    {
                        list.RemoveAt(i);
                    }
                }
                listView.SelectedItems[0].Remove();
            }
        }
    }
}
