using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HitAndBlow
{
    public class HitAndBlow
    {
        public static void Main(string[] args)
        {
            int ketasu1 = 0;
            while (true)
            {
                Console.WriteLine("何桁の数字で開始しますか？（1 ～ 9)");
                string keta = Console.ReadLine();
                var ketacheck1 = new ketacheck();
                Console.WriteLine(ketacheck1.ketachecker(keta));
                if(ketacheck1.trueFlg == 0)
                {
                    ketasu1 = ketacheck1.ketasu;
                    break;
                }
            }
            //
            var output = new firstoutput();
            string outdata = output.Output(ketasu1);
            Console.WriteLine(outdata);
            int kaisuu = 1;
            while (true)
            {
                Console.WriteLine($"{kaisuu}回目の回答");
                string x1 = Console.ReadLine();
                var check = new Check();
                
                string checkmessage = check.Checkresult(x1, ketasu1);
                if (check.checkFlg == 1)
                {
                    Console.WriteLine(checkmessage);
                    while (check.checkFlg == 1)
                    {
                        Console.WriteLine("入力しなおしてください");
                        x1 = Console.ReadLine();
                        check = new Check();
                        checkmessage = check.Checkresult(x1, ketasu1);
                        Console.WriteLine(checkmessage);
                    }
                }

                //hitandblow

                var hitandblowcheck1 = new hitandblowcheck();
                Console.WriteLine($"{x1} {hitandblowcheck1.handbcheck(outdata, x1,ketasu1)}");
                if (hitandblowcheck1.hit == ketasu1)
                {
                    Console.WriteLine($"{kaisuu}回でクリア");
                    break;
                }
                kaisuu = kaisuu + 1;
            }

        }
    }
}
