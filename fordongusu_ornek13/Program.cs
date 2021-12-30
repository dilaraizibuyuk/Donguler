using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek13
{
    class Program
    {
        static void Main(string[] args)
        {   //1 ile 80 arasındaki tek ve çift sayıların ayrı ayrı toplamı
            int toplamtek = 0;
            int toplamcift = 0;
            for (int i = 1; i <=80; i++)
            {
                if (i % 2 == 0)
                {
                    toplamcift = toplamcift + i;
                    
                }

                else
                {
                    toplamtek = toplamtek + i;
                    
                }

            }
            Console.WriteLine("Çift Sayılar Toplamı = {0}", toplamcift);
            Console.WriteLine("Tek Sayılar Toplamı = {0}", toplamtek);
            Console.ReadKey();
        }
    }
}
