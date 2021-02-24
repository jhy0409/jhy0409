using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.view
{
    class Menu
    {
        public const int MAIN_MENU_FORMAT_ERROR = 0;

        public const int MAIN_MENU_ADD = 1;
        public const int MAIN_MENU_VIEW = 2;
        public const int MAIN_MENU_RANDOM_ADD = 3;
        public const int MAIN_MENU_DELETE = 4;
        public const int MAIN_MENU_DELETE_ALL = 5;
        public const int MAIN_MENU_UPDATE = 6;
        public const int MAIN_MENU_EXIT = 7;
        public int mainMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(" 0224 메인 메뉴 ");
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.전체 데이터 삭제");
            Console.WriteLine("6.주소록 정보 수정");
            Console.WriteLine("7.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"에러 메시지 : {e.Message}");
            }
            return menu;
        }

        public string delMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(" 0224 삭제 메뉴");
            Console.WriteLine("-----------------");
            Console.Write("삭제할 이름: ");
            /*string name = Console.ReadLine(); return name;*/
            return Console.ReadLine();
        }

        public int updateMenu()
        {
            return 0;
        }
    }

}
