using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var M1 = 50;
            var M2 = 225;
            var V1 = 33;
            var V2 = 24;

            var p1 = M1/V1;
            var p2 = M2/V2;

            Console.WriteLine("Плотность тела больше =  " + ((p1 > p2) ? "В первом теле" : "Во втором теле"));

            Console.ReadKey();
        }
    }
}
