using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //a)
            for (int i=20; i<=35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 50));

            //b)

            Console.WriteLine("Введите число b");
            int b= Int32.Parse(Console.ReadLine());
            while (b<=10)
            {
                Console.WriteLine("Число b должно быть больше 10");
                b = Int32.Parse(Console.ReadLine());
                
            }

            for(int i=10; i<=b; i++)
            {
              
                
               Console.WriteLine(i * i);
                
            }

            //c)

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Введите число a");
            int a = Int32.Parse(Console.ReadLine());
            while (a >= 50)
            {
                Console.WriteLine("Число a должно быть меньше 50");
                a = Int32.Parse(Console.ReadLine());

            }

            for (int i = a; i <=50; i++)
            {

                Console.WriteLine(i *i*i);
            }

            //d)

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Введите число a");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = Int32.Parse(Console.ReadLine());

            while (a > b)
            {
                Console.WriteLine("Число a должно быть меньше b");
                Console.WriteLine("Введите число a");
                a = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Все целые числ от а до b");
            for (int i = a; i <= b; i++)
            {
                
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        
    }
}
