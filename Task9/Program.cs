using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var R1 = 45;
            var R2 = 24;
            var U1 = 33;
            var U2 = 32;

            var I1 = U1 / R1;
            var I2 = U2 / R2;


            Console.WriteLine("Меньший ток течет по цепи =  " + ((I1 < I2) ? "По первой" : "По второй"));

            Console.ReadKey();

        }
    }
}
