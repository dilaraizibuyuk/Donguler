using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a =1; a<=10; a++)
            {
                if (a==7)
                {
                    break;
                }
                Console.WriteLine("a'nın değeri:"+a);
            }
            Console.ReadLine();
        }
    }
}
