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
    public partial class ViewForm : MaterialForm // :(c++) == extends(java)
    {
        public ViewForm()
        {
            InitializeComponent(); // 초기화
        }

        private void initListView()
        {
            string[] data = { "1", "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com" };
            listView.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i + 2).ToString(), "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"
                    }
                ));
            }
            setRowColor(listView, Color.White, Color.FromArgb(245, 246, 247));
            int index = listView.Items.Count - 1; //마지막 행 표시
            //listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
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
            for (int i = 0; i < 50; i++)
            {
                gridView.Rows.Add(new string[]
                    {
                        (i + 1).ToString(), "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com"
                    }
                );
            }
            int count = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = count;
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];

            /*string[] data = { "1", "홍길동", "010-1234-1234", "조선 옛날옛적 동네", "hong@naver.com" };
            gridView.Rows.Add(data);*/
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
