using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek8
{
    class Program
    {
        static void Main(string[] args)
        {   // kullanıcıdan 10 tane sayı alıp toplattırıp yazdır
            int toplam, sayi, i;
            toplam = 0;
            for (i = 1; i <= 10; i++)
            {
            Console.WriteLine("{0}. sayıyı giriniz",i);
            sayi = Convert.ToInt32(Console.ReadLine());
            toplam = toplam + sayi;
            }
            Console.WriteLine("Yazdığınız sayıların toplamı={0}",toplam);
            Console.ReadLine();

        }
    }
    }

