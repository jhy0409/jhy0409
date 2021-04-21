using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamProject
{
    public partial class DrugCompInfo_Form : Form
    {
        public DrugCompInfo_Form()
        {
            InitializeComponent();
            drugComp_dtGridView.DataSource = DataManager.Comps;

        }

        private void drugComp_dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_DrugComp_Add_Click(object sender, EventArgs e)
        {
            if (compName_txtBox.Text.Trim() == "" || compTel_txtBox.Text.Trim() == "" || 
                compAddr_txtBox.Text.Trim() == "" || compEmail_txtBox.Text.Trim() == "")
            {
                MessageBox.Show("모든 내용을 입력해주세요");
            }
            else
            {
                try
                {
                    Entp entp = DataManager.Comps.Single
                        ((x) => x.entpName.ToString() == compName_txtBox.Text);

                    /*string msg = "";
                    if (entp.entpName.Trim() != "") 
                    {
                        msg = "정보가 저장되어 있습니다.";
                        MessageBox.Show(msg + " " + entp.entpName + "번 주차공간");
                        writeLog(msg + " " + entp.entpName + "번 주차공간");
                    }
                    else // 아직 정보가 없음*/
                    {
                        entp.entpName = compName_txtBox.Text;
                        entp.entpTel = compTel_txtBox.Text;
                        entp.entpAddr = compAddr_txtBox.Text;
                        entp.entpEmail = compEmail_txtBox.Text;

                        drugComp_dtGridView.DataSource = null; 
                        drugComp_dtGridView.DataSource = DataManager.Comps; 
                        DataManager.Save();

                        string contens = $"주차공간 {compName_txtBox.Text}에 {compTel_txtBox.Text}차를 주차함";
                        MessageBox.Show(contens);
                        writeLog(contens, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch (Exception ex)
                {
                    string contents = $"주차할 수 없습니다. " + compName_txtBox.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }
        }

        private void writeLog(string contents)
        {
            // int a = 1; // MessageBox.Show(a.ToString("00"));  // 01이라고 출력됨. 3자리이상 입력시 그대로 출력
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] " +
                $"{contents}";

            // 옛날것이 가장 위에 올라가는 방식 새로운 내용이 뒤에 추가 되어, 새내용 보려면 밑으로 내려가야함
            // listBox1.Items.Add(logContents);
            // 새로운 것이 가장 위에 올라가는 방식 새 내용이 가장 앞에 있음
            //listBox1.Items.Insert(0, logContents); // 지정위치에 삽입
            //List<int> list = new List<int>();
            //list.Insert(0, 1);
            DataManager.printLog(logContents);
        }

        // writeLog 함수 오버로딩
        private void writeLog(string contents, string date)
        {
            // int a = 1; // MessageBox.Show(a.ToString("00"));  // 01이라고 출력됨. 3자리이상 입력시 그대로 출력
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] " +
                $"{contents}";

            //listBox1.Items.Insert(0, logContents); // 지정위치에 삽입
            DataManager.printLog(logContents, date);
        }


    }
}
