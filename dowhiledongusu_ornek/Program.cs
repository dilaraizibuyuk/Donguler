using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhiledongusu_ornek
{
    class Program
    {
        static void Main(string[] args)
        { //1den 100e kadar olan sayıların toplamı
             int sayac=1;
             int toplam = 0;
            do
            {
                toplam += sayac;

                sayac++;
               


            } while (sayac<=100);
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı:{0}",toplam);


            Console.ReadLine();
        }
    }
}
