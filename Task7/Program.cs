using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 45;

            double a = 55;

            var volumeR = 3.14 * r * r;
            var volumeA = a * a;

            Console.WriteLine("Площадь тела больше =  " + ((volumeR > volumeA) ? "круга" : "квадрата"));

            Console.ReadKey();
        }
    }
}
