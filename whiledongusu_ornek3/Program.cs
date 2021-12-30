using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledongusu_ornek3
{
    class Program
    {
        static void Main(string[] args)
        { //10dan 1e kadar sayıları yazdırma işlemini yapalım

            int sayac = 10;
            do
            {
                Console.WriteLine(sayac);
                sayac--;
            } while (sayac>1);

            Console.ReadLine();
        }
    }
}
