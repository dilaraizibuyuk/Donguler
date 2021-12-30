using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek12
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcı 2 tane sayı girecek sayıların arasındaki 5'e bölünenleri yazdıralım

            Console.WriteLine("Bir sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayi daha giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if(i%5==0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
