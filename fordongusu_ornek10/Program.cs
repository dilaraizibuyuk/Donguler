using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek10
{
    class Program
    {
        static void Main(string[] args)
        { //1-100 arasında 3e bölünebilen sayıları yazdıralım

            for (int i = 1; i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
