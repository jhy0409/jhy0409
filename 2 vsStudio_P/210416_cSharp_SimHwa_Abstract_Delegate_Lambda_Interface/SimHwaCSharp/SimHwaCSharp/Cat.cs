using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHwaCSharp
{
    // 추상클래스
    class Cat : Animal, IRunnable, IFight
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("국이 짜구나 애비야옹");
            // 구현 안됐다는 에러 띄움
            // throw new NotImplementedException();
        }

    }
}
