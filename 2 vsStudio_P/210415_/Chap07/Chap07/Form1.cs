using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap07
{
    public partial class Form1 : Form
    {
        List<Dog> Dogs = new List<Dog>()
            { new Dog(), new Dog()};

        List<Cat> Cats = new List<Cat>()
            { new Cat(), new Cat()};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Meow();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (false)
            {
                NewCat c = new NewCat();
                c.Eat();
                c.name = "캔따개";
                c.breedName = "사람";
                NewDog d = new NewDog();
                d.Eat();
            }
            

            // 다형성 = 다양한 형태를 가짐
            List<Animal> Animals = new List<Animal>()
            {
                new NewDog(), new NewCat(),new NewDog(), new NewCat() // 서로간 형변환 가능
            };

            // 자식 클래스로 형변화 (A(NewDog) is B(Animal))
            //(Animals[0] as NewDog).breedName = "말티즈";

            foreach (var item in Animals)
            {
                item.Eat();
                var dog = item as NewDog;
                if(dog != null)
                {
                    dog.Bark();
                }

                var cat = item as NewCat;
                if (cat != null)
                {
                    cat.Meow();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Animal a = new Animal();
             NewDog d = new NewDog();
             NewCat c = new NewCat();

             a.Fight();
             d.Fight();
             c.Fight();

            // 오버로딩 (파라미터로 구분)
            // 오버라이딩 (override) == 재정의

            a.name = "사람이름";
            a.age = 20;

            d.name = "니니";
            d.age = 17;

            MessageBox.Show(a.ToString());
            MessageBox.Show(d.ToString());*/

            Cat oldcat = new Cat();
            oldcat.name = "나옹";
            oldcat.age = 25;
            MessageBox.Show(oldcat.ToString());
        }
    }
}
