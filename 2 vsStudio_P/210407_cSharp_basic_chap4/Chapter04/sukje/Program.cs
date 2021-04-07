using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukje
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "--------------------------------------------";
            /*Console.WriteLine($"문제1. 숫자 5개입력 > 최소, 최대숫자 출력 \n{line}\n숫자 5개를 입력하세요");
            string[] nBunjje = { "첫", "두", "세", "네", "다섯" };
            int[] number = new int[5];


            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{nBunjje[i]}번째 숫자\t: ");
                number[i] = int.Parse(Console.ReadLine());

            }
            int minNum = number[0];
            int maxNum = number[0];

            for (int i = 0; i < number.Length; i++)
            {

                if (minNum > number[i]) { minNum = number[i]; }
                if (maxNum < number[i]) { maxNum = number[i]; }
            }

            Console.WriteLine($"{line}\n최소 : {minNum}");
            Console.WriteLine($"최대 : {maxNum}");



            Console.WriteLine($"\n문제2. 개미수열, 1부터시작 20번째 숫자를 만들어 찾기 \n{line}");



            Console.WriteLine($"\n문제3. 입력숫자 *묶음 교차출력 \n{line}");
            Console.Write($"*문자 교차출력 수? : ");
            int byul = int.Parse(Console.ReadLine());
            int molugetta = 0;
            if (byul % 2 == 1)
            {
                molugetta = (byul / 2) + 1;
            }
            else
            {
                molugetta = (byul / 2);
            }

            int namuji = byul - molugetta;
            for (int i = 0; i < byul; i++)
            {
                for (int j = 0; j < molugetta; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write(" ");
                for (int k = 0; k < namuji; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine($"---- {i + 1}번째 출력 -----");
            }
            */

            Console.WriteLine($"\n문제4. 설탕공장 \n{line}");
            /*
               [ 알고리즘 ] 5kg로 나눈 나머지를 3kg 묶음로 계산
               
               [ 조건 ]
               딱 안 떨어지면 -1 반환
               입력 값으로는 사탕공장에서 요구하는 설탕 수
               출력 값은 최소 묶음 수를 출력.
             */

            Console.Write("주문할 설탕 kg수? : ");
            int sugarJumun = int.Parse(Console.ReadLine());
            int[] podaeSu = new int[3];
            string[] whakKg = { "5kg", "3kg", "5kg + 3kg" };
            string minusOutput = "";

            /*
             * podaeSu[0] = 5kg만 계산
             * podaeSu[1] = 3kg만 계산
             * podaeSu[2] = (kg%5)/3 계산
             */
            if (sugarJumun % 5 == 0)
            {
                podaeSu[0] = sugarJumun / 5;
            } else
            {
                podaeSu[0] = sugarJumun / 5+1;
            }
            if (sugarJumun % 3 == 0)
            {
                podaeSu[1] = sugarJumun / 3;
            }

            if ((sugarJumun % 5) / 3 == 0) // 5kg 3kg 혼용시 나머지 0일 때 포대 수
            {
                podaeSu[2] = (sugarJumun / 5) + 1;
            }
            else                         // 5kg 3kg 혼용시 나머지 0이 아닐 때 포대 수
            {
                podaeSu[2] = (sugarJumun / 5) + 2;
            }

            if (sugarJumun % 5 != 0 && sugarJumun % 3 != 0)
            {
                minusOutput = "-1";
            }

            for (int i = 0; i < podaeSu.Length; i++)
            {
                Console.WriteLine(podaeSu[i]);
            }
            // 최소, 최대 구하기
            int min2 = podaeSu[0];
            string mukum = whakKg[0];
            for (int i = 0; i < podaeSu.Length; i++)
            {
                for (int j = 0; j < podaeSu.Length; j++)
                {
                    if (min2 > podaeSu[j])
                    {
                        min2 = podaeSu[j];
                        mukum = whakKg[j];
                    }
                }
            }
            Console.WriteLine($"4. 최소 묶음 수: {min2}포대, ({mukum}사용)");

        }
    }
}
