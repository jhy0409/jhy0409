﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.cont
{
    class Handler
    {
        static Random r = new Random();
        public Handler()
        {
            iplyok();

        }

        List<LottoN> lottoNumNIndex = new List<LottoN>();
        double[] joncheHwaklyul = { 9.3, 8.7, 8.7, 9.3,  8.4,
                                        8.4, 8.4, 8.4, 7, 9,
                                        8.6, 9.2, 9.3, 8.7, 8.4,

                                        8.4, 9.3, 8.9, 8.5, 9,
                                        8.5, 7.1, 7.5, 8.6, 8,
                                        8.8, 9.5, 7.7, 7.4, 8.3,

                                        8.7, 7.7, 9.1, 9.4, 8.2,
                                        8.4, 8.6, 8.9, 9.1, 8.9,
                                        7.6, 8.3, 10, 8.3, 8.5};
        int[] goodLuck = new int[7];


        public int[] GoodLuck { get => goodLuck; set => goodLuck = value; }

        public void makeLotto(int randNum)
        {
            for (int i = 0; i < goodLuck.Length; i++)
            {
                goodLuck[i] = r.Next(1, 46);
                Console.WriteLine($"현재번호 : {goodLuck[i]}");

                if (i < (goodLuck.Length - randNum) && hwaklyul(goodLuck[i]) < 9) // (7 - randNum)번째 숫자까지는 번호당 확률 70%이상
                {
                    i--;
                }

                if (i >= (goodLuck.Length - randNum)) // 마지막 번호 randNum개는 랜덤
                {
                    goodLuck[i] = r.Next(1, 46);
                }
                for (int j = 0; j < i; j++)
                {
                    if (goodLuck[i] == goodLuck[j])
                    {
                        i--;
                        Console.WriteLine($"{j + 1}번째 값 중복발생 : {goodLuck[j]}");
                    }
                }
            }
        }


        public void iplyok()
        {
            // 1~957회차 전체번호(1~45)별 확률 (로또 홈페이지 자료 참고)
            for (int i = 0; i < 45; i++)
            {
                lottoNumNIndex.Add(new LottoN((i + 1), joncheHwaklyul[i]));
            }
        }

        public double hwaklyul(int lotto)
        {
            int index = 0;
            for (int i = 0; i < lottoNumNIndex.Count; i++)
            {
                if (lottoNumNIndex[i].Num == lotto)
                {
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            return lottoNumNIndex[index].NumOfPercent;
        }
    }
}
