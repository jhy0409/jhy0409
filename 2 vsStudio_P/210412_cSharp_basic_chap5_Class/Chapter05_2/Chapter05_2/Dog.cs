using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_2
{
    class Dog
    {
        public string name = "이름";
        public int age = 33;
        public static int theNumberOfDog = 0; // 클래스변수 : 고정값이나 공통사용시 선언
        // 프로그램 시작 시점에 메모리에 먼저 올라감
        // 인스턴스 = 선언시점에 메모리에 올라감

        // 생성자
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;

            theNumberOfDog++;
        }
    }
}
