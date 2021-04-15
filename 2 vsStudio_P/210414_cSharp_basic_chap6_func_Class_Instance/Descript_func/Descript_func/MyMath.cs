using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descript_func
{
    class MyMath
    {
        int number;
        int end;

        public MyMath(int number)
        {
            this.number = number;
        }
        public MyMath(int number, int end)
        {
            this.number = number;
            this.end = end;
        }
        public MyMath()
        {
        }

        public int power(int input) // 1번
        {
            return input * input;
        }

        public static int power(int input, int count) // 2번
        {
            //int result = power(input);
            for (int i = 0; i < count; i++)
            {
                
            }
            return input;
        }

        public int sumAll(int input) // 3번
        {
            int sum = 0;
            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }


        public int sumAll(int input, int end) // 4번
        {
            int sum = 0;
            for (int i = input; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
