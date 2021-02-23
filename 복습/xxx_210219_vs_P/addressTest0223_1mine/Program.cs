using addressTest0223_1mine.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressTest0223_1mine
{
    class Program //0219일자 1org와 대조
    {
        static List<Student> addrList = new List<Student>();
        const int ERROR_MENUNUM = 0;

        const int MENU_ADD_ITEM = 1;
        const int MENU_VIEW_ITEM = 2;
        const int MENU_RAND_ITEM = 3;
        const int MENU_DEL_ITEM = 4;
        const int MENU_EDIT_ITEM = 5;

        const int MENU_DELALL_ITEM = 6;
        const int MENU_SYS_DOWN = 7;
        static void Main(string[] args)
        {
            switch (getMenu())
            {
                case ERROR_MENUNUM:
                    Console.WriteLine("숫자로 입력하시오");
                    break;

                case MENU_ADD_ITEM: // 1
                    addItem();
                    break;
                case MENU_VIEW_ITEM: // 2
                    viewItem();
                    break;
                case MENU_RAND_ITEM: // 3 
                    break;
                case MENU_DEL_ITEM: // 4
                    break;
                case MENU_EDIT_ITEM: //5번
                    break;

                case MENU_DELALL_ITEM: // 6
                    break;
                case MENU_SYS_DOWN: // 7
                    break;
                default:
                    Console.WriteLine("[default] 잘못된 숫자 입력");
                    break;
            }

        }
        public static void viewItem() // <-------------------------------- ★ 여기부터
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.Write($"- 아이디 : {addrList[i].Id}");
                Console.Write($"- 이름   : {addrList[i].Name}");
                Console.Write($"- 전화   : {addrList[i].Tel}");
                Console.Write($"- 주소   : {addrList[i].Address}");
                Console.Write($"- 이메일 : {addrList[i].Email}");
            }
        }

        public static void addItem() // 1
        {
            Console.Write("- 아이디 : ");
            string id = Console.ReadLine();
            Console.Write("- 이름   : ");
            string name = Console.ReadLine();
            Console.Write("- 전화   : ");
            string tel = Console.ReadLine();
            Console.Write("- 주소   : ");
            string address = Console.ReadLine();
            Console.Write("- 이메일 : ");
            string email = Console.ReadLine();

            addrList.Add(new Student(id, name, tel,address,email));
            Console.WriteLine("[안내] 정상입력 완료");
        }

        public static int getMenu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("[메뉴] 주소록 관리");
            Console.WriteLine("=============================");
            Console.WriteLine("- 1. 주소록 추가");
            Console.WriteLine("- 2. 주소록 보기");
            Console.WriteLine("- 3. 주소록 랜덤 추가");
            Console.WriteLine("- 4. 주소록 삭제");
            Console.WriteLine("- 5. 주소록 수정");
            Console.WriteLine("- 6. 주소록 전체삭제");
            Console.WriteLine("- 7. 종료");
            Console.WriteLine("-----------------------------");
            Console.Write("- 메뉴선택 : ");
            Console.WriteLine("-----------------------------\n");
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                //Console.WriteLine(e.Message);
            }

            return menu;
        }
    }
}
