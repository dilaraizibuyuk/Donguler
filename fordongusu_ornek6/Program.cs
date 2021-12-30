using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek6
{
    class Program
    {
        static void Main(string[] args)
        { //başlangıç 3 bitiş 20 ekrana yazdırıcaz
            Console.WriteLine("Başlangıç değerini giriniz:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değerini giriniz:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            for (int i = basla; i <= bitis; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
