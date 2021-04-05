using adressTest0218.control;
using adressTest0218.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            StudentCtrl sc = new StudentCtrl();
            while (true)
            {
                switch (m.mainMenu())
                {
                    case Menu.MAIN_MENU_ADD:    // 1
                        sc.addItem();
                        break;
                    case Menu.MAIN_MENU_VIEW:   // 2
                        sc.viewItem();
                        break;
                    case Menu.MAIN_MENU_RANDOM_ADD: // 3
                        sc.randData(15);
                        break;
                    case Menu.MAIN_MENU_DELETE:  // 4
                        sc.delItem(m.delMenu());
                        break;
                    case Menu.MAIN_MENU_DELETE_ALL: // 5
                        sc.delItemAll();
                        break;

                    case Menu.MAIN_MENU_UPDATE: // 6
                        sc.updateItem(m.updateMenu());
                        break;
                    case Menu.MAIN_MENU_EXIT:   // 7
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    case Menu.MAIN_MENU_FORMAT_ERROR:   // 0
                        Console.WriteLine("잘못된 문자를 입력함");
                        Console.WriteLine("메뉴 다시입력\n\n");
                        break;
                    default:
                        Console.WriteLine("[default] 잘못된 메뉴선택");
                        Console.WriteLine("[default] 메뉴 다시입력\n\n");
                        break;
                }
            }
        }
    }
}
