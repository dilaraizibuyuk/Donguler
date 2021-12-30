using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {       //1-50 arasında 5 adet rastgele sayı oluşturalım
            Random rastgele_sayi = new Random();
            for (int i = 0; i < 5; i++)
            {
                int sayi = rastgele_sayi.Next(1, 50);
                Console.WriteLine(sayi.ToString());
            }
            Console.ReadLine();

        }
    }
}
