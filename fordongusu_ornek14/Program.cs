using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek14
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcı başlangıç bitiş sayısı girecek başlangıç bitişten büyük olmadurumunu da al başlangıç bitişten küçükse aralıktaki 2ye bölünenleri yazdır
            //başlangıç bitişe eşitse aynı şeyi yazdır başlangıç bitişten küçükse aralıktaki 2ye bölünwnlwei yazdır

            Console.WriteLine("Bir sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                for (int i = sayi1; i >= sayi2; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (sayi2 > sayi1)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
                Console.WriteLine("Girdiğiniz sayılar eşittir.");
            Console.ReadLine();
        }
    }
}
