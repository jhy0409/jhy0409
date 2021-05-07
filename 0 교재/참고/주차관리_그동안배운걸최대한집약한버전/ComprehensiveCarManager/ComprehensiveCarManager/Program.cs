using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprehensiveCarManager
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //호출 스택 : ctrl + alt + c
                //https://m.blog.naver.com/PostView.nhn?blogId=forenty&logNo=30157089907&proxyReferer=https:%2F%2Fwww.google.com%2F
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ManagerParkingCar());
            }
            catch (Exception ee)
            {
                //Cars 리스트에 아무 것도 없는 상태에서 주차공간 추가하고 gridview 클릭하면 
                //인덱스가 -1이 없다? 이런 말이 나왔다.
                //1차 해결방안으로 catch 부분에 run을 한 번 더 호출해줬다. 이렇게해도 해결은 된다.
                //2차 해결방안은 ManagerParkingCar.cs에 있다.
                //Cars 길이가 0이면 datagridview에 아무것도 넣지 않는 것이다. 
                //그리고 cellclick할 때도 Cars 길이가 0이면 클릭을 해도 그냥 아무 처리를 안 하도록 하는 것이다.
                //Application.Run(new ManagerParkingCar()); //1차 해결방안대로 하려면 이거 주석해제해야 함
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
        }
    }
}
