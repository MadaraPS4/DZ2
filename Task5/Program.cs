using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 46;

            int sum = number % 10 + number / 10;
            int multiply = (number % 10) * (number / 10);

            Console.WriteLine("Число единиц = " + number%10);
            Console.WriteLine("Число десятков = " + number/10);

            Console.WriteLine("Сумма его цифр= " + sum);
            Console.WriteLine("Произведение его цифр " + multiply);

            Console.ReadKey();
        }
    }
}
