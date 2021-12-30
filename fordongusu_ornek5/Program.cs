using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek5
{
    class Program
    {
        static void Main(string[] args)
        { //10defa girilen metin yazdırılacak
            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadLine();
        }
    }
}
