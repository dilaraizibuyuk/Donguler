using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu_ornek11
{
    class Program
    {
        static void Main(string[] args)
        { //1-100 arası 3e ve 4e bölünebilen sayıları bulma

            for (int i = 1; i <= 100; i++)
            {
                if(i%3==0 && i%4==0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
