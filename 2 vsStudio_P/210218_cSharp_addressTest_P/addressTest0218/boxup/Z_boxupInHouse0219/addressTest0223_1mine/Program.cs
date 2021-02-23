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
        const int ERROR_MENUNUM = 0;

        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RAND_ADD = 3;
        const int MENU_DEL = 4;
        const int MENU_EDIT_ITEM = 5;

        const int MENU_DELETE_ALL = 6;
        const int MENU_EXIT = 7;

        static List<Student> addrList = new List<Student>();
        static Random r = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                switch (getMenu())
                {
                    case ERROR_MENUNUM:
                        Console.WriteLine("숫자로 입력하시오");
                        break;

                    case MENU_ADD: // 1
                        addItem();
                        break;
                    case MENU_VIEW: // 2
                        viewItem();
                        break;
                    case MENU_RAND_ADD: // 3 
                        randData();
                        break;
                    case MENU_DEL: // 4
                        delItem();
                        break;
                    //case MENU_EDIT_ITEM: //5번
                    //    break;

                    case MENU_DELETE_ALL: // 6
                        delItemAll();
                        break;
                    case MENU_EXIT: // 7
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("[default] 잘못된 숫자 입력");
                        break;
                }
            }
        }
        public static void randData()
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] address = { "1 대구시 동구 신암4동", "2 서울시 동구 신암4동", "3 부산시 동구 신암4동", "4 인천시 동구 신암4동", "5 광주시 동구 신암4동" };
            string[] email = { "1_hong@test.com", "2_kim@test.com", "3Lee@test.com", "4Park@test.com", "5CHOI@test.com" };

            Console.Write("랜덤생성 개수 : ");
            int make = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < make; i++)
            {
                addrList.Add(new Student(getID(), name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], email[r.Next(0, 5)]));
            }
        }

        public static void addItem() // 1
        {
            Console.WriteLine("\n-----------------------------");
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

            addrList.Add(new Student(id, name, tel, address, email));
            Console.WriteLine("[안내] 정상입력 완료");
        }

        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"{i + 1}번째 학생");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"- 아이디 : {addrList[i].Id}");
                Console.WriteLine($"- 이름   : {addrList[i].Name}");
                Console.WriteLine($"- 전화   : {addrList[i].Tel}");
                Console.WriteLine($"- 주소   : {addrList[i].Address}");
                Console.WriteLine($"- 이메일 : {addrList[i].Email}");
            }
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


        public static void delItem()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine(" 주소록 정보 삭제");
            Console.WriteLine("-----------------------------");
            Console.Write("- 삭제할 이름\t: ");
            string name = Console.ReadLine();
            Console.Write("- 삭제할 아이디\t: ");
            string id = Console.ReadLine();

            /*for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Id.Equals(id) && addrList[i].Name.Equals(name))
                {
                    addrList.RemoveAt(i--);
                }
            }*/

            int cnt = 0;
            while (cnt < addrList.Count)
            {
                if (name.Equals(addrList[cnt].Name) && id.Equals(addrList[cnt].Id))
                {
                    addrList.RemoveAt(cnt);
                }
                else
                {
                    cnt++;
                }
            }
        }

        public static void delItemAll()
        {
            addrList.Clear();
        }

        public static string getID()
        {
            string rdata = "0123456789";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return rs.ToString();
        }

    }
}
