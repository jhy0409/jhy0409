using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHwaCSharp
{
    class Dog : Animal
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("멍멍 챱챱챱");
            // 구현 안됐다는 에러 띄움
            // throw new NotImplementedException();
        }
    }
}
