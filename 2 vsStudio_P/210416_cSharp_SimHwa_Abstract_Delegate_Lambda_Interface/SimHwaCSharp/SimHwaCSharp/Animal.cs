using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHwaCSharp
{
    // IRunnable, IFight 인터페이스(규칙)
    // 1. 명시적
    // 2. 규칙부여 구현
    // 3. 다중상속 x, 인터페이스 여러개 붙일 수 있음

    // 클래스 순차정렬 ppt Chap9 IComparable,IDiposable
    abstract class Animal : IRunnable, IFight
    {
        public abstract void Eat();

        public void fight()
        {
            System.Windows.Forms.MessageBox.Show("퍽퍽");
        }

        public void Run()
        {
            System.Windows.Forms.MessageBox.Show("슝슝 달린다.");
        }

        // 추상클래스, 구현하지 않고 놔두는 거 
        // 상속받을 때는 구체적으로 구현해라
        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("드르렁 쿨쿨");
        }
    }
}
