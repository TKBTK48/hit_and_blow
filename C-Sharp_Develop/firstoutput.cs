using System;
using System.Collections.Generic;
using System.Linq;

namespace HitAndBlow
{
    public class firstoutput
    {

        public string Output(int ketasuu)
        {
            int[] num = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] number = num.OrderBy(i => Guid.NewGuid()).ToArray();
            //
            string outputnumber = "";
            for (int i = 0; i < ketasuu; i++)
            {
                outputnumber = outputnumber + number[i];
            }
            return outputnumber;
        }
    }
}
