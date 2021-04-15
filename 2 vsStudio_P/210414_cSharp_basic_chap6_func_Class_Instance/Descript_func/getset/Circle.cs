using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Circle
    {
        private int r;
        public int R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        public int radius { get; set; } // 표준
                                        // 참고. {get; set;}없어도 잘 써옴
                                        // 나중에 그리드 뷰 할 때는 {get; set;}이 필요함
                                        // public 변수 만들 땐 {get; set;}을 쓰기

        public int radi
        {
            get { return this.r; }
            set // 의 매개변수 value
            {
                if (value < 0)
                    this.r = 0;
                else
                {
                    this.r = value;
                }
            }
        }

    }
}
