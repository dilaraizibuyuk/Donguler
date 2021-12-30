using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek4
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcının girdiği sayının 1'den o sayıya kadar olan sayılarını yazdıralım
            Console.WriteLine( "Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
