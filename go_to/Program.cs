using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace go_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int value=3;
            switch (value)
            {
                case 1:
                    Console.WriteLine("value 1");
                    break;
                case 2:
                    Console.WriteLine("value 2");
                    break;

                case 3:
                    Console.WriteLine("value 3");
                    goto case 1;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            Console.ReadLine();
        }
    }
}
