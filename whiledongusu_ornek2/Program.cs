using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledongusu_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {   //100den geriye çift sayıları yazdırma

            int y = 100;
            while (y>=0)
            {
                Console.WriteLine(y);
                y -= 2;
            }
            Console.ReadLine();
        }
    }
}
