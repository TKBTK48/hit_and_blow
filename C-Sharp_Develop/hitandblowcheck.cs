using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitAndBlow
{
    public class hitandblowcheck
    {
        public int hit = 0;
        public string handbcheck(string outputword, string inputword,int ketasuu)
        {
            char[] outputchar = outputword.ToCharArray();
            char[] inputchar = inputword.ToCharArray();
            int blow = 0;
            for (int i1 = 0; i1 < ketasuu; i1++)
            {
                if (outputchar[i1] == inputchar[i1])
                {
                    hit = hit + 1;
                }
            }
            for (int i2 = 0; i2 < ketasuu; i2++)
            {
                for (int i3 = 0; i3 < ketasuu; i3++)
                {
                    if (outputchar[i2] == inputchar[i3])
                    {
                        blow = blow + 1;
                    }
                }
            }
            blow = blow - hit;
            string message = $"( {hit}Hit: {blow}Blow)";
            return message;
        }
    }
}
