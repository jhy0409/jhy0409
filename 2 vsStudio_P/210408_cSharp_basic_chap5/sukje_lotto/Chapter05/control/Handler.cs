using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.control
{
    class Handler
    {
        private List<LottoN> lottoNumNIndex;
        double[] joncheHwaklyul = { 9.3, 8.7, 8.7, 9.3,  8.4,
                                    8.4, 8.4, 8.4, 7,   9,
                                    8.6, 9.2, 9.3, 8.7, 8.4,

                                    8.4, 9.3, 8.9, 8.5, 9,
                                    8.5, 7.1, 7.5, 8.6, 8,
                                    8.8, 9.5, 7.7, 7.4, 8.3,

                                    8.7, 7.7, 9.1, 9.4, 8.2,
                                    8.4, 8.6, 8.9, 9.1, 8.9,
                                    7.6, 8.3, 10,  8.3, 8.5};

        public Handler()
        {
            List<LottoN> lottoNumNIndex = new List<LottoN>();
            iplyok();
        }

        private void iplyok()
        {
            // 1~957회차 전체번호(1~45)별 확률 (로또 홈페이지 자료 참고)
            for (int i = 0; i < 45; i++)
            {
                lottoNumNIndex.Add(new LottoN((i + 1), joncheHwaklyul[i]));
            }
        }

        public List<LottoN> getList()
        {
            return lottoNumNIndex;
        }

    }
}
