using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek9
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcının ismini öğrenelim. ismini söylüyor. bu ismi 5 kere yazdırıyoruz fakat başında da numaralandırma olacak.

            Console.WriteLine("İsminizi öğrenebilir miyim?");
            string isim = Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}.{1}",i,isim);
            }
            Console.ReadKey();
        }
    }
}
