using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ic_ice_for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {   //sayılardan piramit yapma
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
