using adressTest0218.control;
using adressTest0218.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218 // mvp모델, 기능별, 컴포넌트별
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
                    case Menu.MENU_MAIN_ADD:    // 1
                        sc.addItem();
                        break;
                    case Menu.MENU_MAIN_VIEW:   // 2
                        sc.viewItem();
                        break;
                    case Menu.MENU_MAIN_RANDOM_ADD: // 3
                        sc.randData(100);
                        break;
                    case Menu.MENU_MAIN_DELETE: // 4
                        sc.delItem(m.delMenu());
                        break;
                    case Menu.MENU_MAIN_DELETE_ALL: // 5
                        sc.delItemAll();
                        break;
                   
                    case Menu.MENU_MAIN_UPDATE:     // 6
                        sc.updateItem(m.updateMenu());
                        break;
                    case Menu.MENU_MAIN_EXIT:       // 7
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    case Menu.MENU_MAIN_FORMAT_ERROR: // 8
                        Console.WriteLine("잘못된 숫자를 입력하였습니다.");
                        Console.WriteLine("메뉴를 다시 입력하세요\n\n");
                        break;
                    default:
                        Console.WriteLine("[default] 잘못된 메뉴 선택입니다.");
                        Console.WriteLine("[default] 다시 입력해주세요.");
                        break;
                }
            }
        }
    }
}

/* MVC / 모델-뷰-컨트롤    : 웹
 * MVP / 모델-뷰-프리젠트  : 뷰로 입력 <-
 * M.V.VM / 모델-뷰-뷰모델
 */