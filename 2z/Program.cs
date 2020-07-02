using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2z
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            
            Console.WriteLine("Введите кол-во новорождённых");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вероятность рождения мальчика");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во родившихся мальчиков");
            c = Convert.ToInt32(Console.ReadLine());
            d = a - c;
            f = 1 - b;
            int factorial = 1;
            int factorial1 = 1;
            int factorial2 = 1;

            for(int i = 2; i <= d; i++)
            {
                factorial = factorial * i;
            }
            for (int i = 2; i <= a; i++)
            {
                factorial1 = factorial1 * i;
            }
            for (int i = 2; i <= c; i++)
            {
                factorial2 = factorial2 * i;
            }
            
            e = (factorial1 / (factorial2 * factorial) * (Math.Pow(b, c)) * (Math.Pow(f, d)));

            Console.WriteLine("Вероятность рождения мальчика и девочки одинаково " + e);
            Console.ReadKey();
        }
    }
}
