using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek7
{
    class Program
    {
        static void Main(string[] args)
        {       //a'dan z'ye harflerimizi yazdırma
            char karakter;
            for (karakter = 'a'; karakter <='z' ; karakter++)
            {
                Console.WriteLine(karakter);
            }
            Console.ReadKey();
        }
    }
}
