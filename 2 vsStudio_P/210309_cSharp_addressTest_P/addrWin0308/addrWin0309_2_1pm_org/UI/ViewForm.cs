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
    partial class ViewForm : MaterialForm // :(c++) == extends(java)
    {
        public ViewForm()
        {
            InitializeComponent(); // 초기화
        }

        StudentHandler sc;
        public ViewForm(StudentHandler sc)
        {
            InitializeComponent(); // 초기화
            this.sc = sc;
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


        private void ViewForm_Load(object sender, EventArgs e) // 폼로드시 동작, 안정적 (생성자가 더 빠름)
        {
            initListView();
            initGridView();
        }

        private void initGridView()
        {
            int size = sc.getList().Count;
            for (int i = 0; i < size; i++)
            {
                List<Student> list = sc.getList();
                gridView.Rows.Add(new string[]
                   {
                        (i + 1).ToString(),
                        list[i].Name, list[i].Tel, list[i].Address, list[i].Email

                        /*(i + 1).ToString(), 
                       "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"*/
                   }
               );
            }

            int count = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = count;
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void listView_SelectedIndexChanged_1(object sender, EventArgs e) // 선택시 이벤트 발생
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name = listView.Items[n].SubItems[1].Text;
                string tel = listView.Items[n].SubItems[1].Text;
                string addr = listView.Items[n].SubItems[1].Text;
                string email = listView.Items[n].SubItems[1].Text;

                //Console.WriteLine("이름 : {0}", name);
                Console.WriteLine($"이름 : {name}");
                Console.WriteLine($"전화 : {tel}");
                Console.WriteLine($"주소 : {addr}");
                Console.WriteLine($"이메일 : {email}");
                Console.WriteLine("--------------------------");
                //listView.Items.RemoveAt(n);

            }
        }
    }
}
