using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HitAndBlow
{
    public class Check
    {
        public int checkFlg = 1;
        public string Checkresult(string inputword,int ketasuu)
        {
            string mes = "";
            if (inputword.Length > ketasuu|| inputword.Length < ketasuu)
            {
                mes = "桁数に過ちがあります";
                checkFlg = 1;
            }
            else
            {
                char[] input = inputword.ToCharArray();
                int[] inputnumber = new int[ketasuu];
                try
                {
                    checkFlg = 0;
                    for (int i0 = 0; i0 < ketasuu; i0++)
                    {
                        inputnumber[i0] = int.Parse(input[i0].ToString());
                    }
                    //
                    for (int i1 = 0; i1 < ketasuu; i1++)
                    {
                        for (int i2 = i1 + 1; i2 < ketasuu; i2++)
                        {
                            if (input[i1] == input[i2])
                            {
                                mes = "重複している値があります";
                                checkFlg = 1;
                                break;
                            }
                        }
                    }
                }
                //
                catch
                {
                    mes = "数値ではありません";
                    checkFlg = 1;
                }
            }

            return mes;
        }
    }
}
