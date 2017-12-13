using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine("А или B = " + (A || B));
            Console.WriteLine("А и B = " + (A && B));
            Console.WriteLine("B или C = " + (B || C));

            Console.ReadKey();
        }
    }
}
