using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06
{
    struct Account // int, string처럼 변수가 값 저장함 [재선언 시 값이 복사됨], Class = 주소지 저장
    {
        public int myMoney; // 멤버변수
        public string name;

        public Account(int money, string name)
        {
            myMoney = money;
            this.name = name;
        }

        // 입금
        public void deposit(int money)
        {
            myMoney += money;
        }

        // 출금
        public void withdraw(int money)
        {
            myMoney -= money;
        }
    }
}
