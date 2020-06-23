using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitAndBlow
{
    public class ketacheck
    {
        public int trueFlg = 0;
        string mes = "";
        public int ketasu;
        public string ketachecker(string keta)
        {
            try
            {
                ketasu = int.Parse(keta);
                if (0 < ketasu && ketasu <= 9)
                {
                    mes = "コンピュータが数字を選んでいます。。。。";
                }
                else
                {
                    mes = "正しい数値を入力してください";
                    trueFlg = 1;
                }
            }
            catch
            {
                mes = "正しい数値を入力してください";
                trueFlg = 1;
            }
            return mes;
        }
    }
}
