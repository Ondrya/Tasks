using System;

namespace Task570
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Сколько чисел Мерссена вывести: ");
            var _n = Console.ReadLine();
            try
            {
                var N = ulong.Parse(_n);
                if (N >= 65) throw new ArgumentException("Число слишком большое. MaxValue: 64");
                GetMersennePrime(N);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetMersennePrime(ulong N)
        {
            ulong n = 0;
            ulong m = 0;
            while (n<N)
            {
                n++;
                m++;
                m = m * 2 - 1;
                Console.WriteLine($"{n}:\t{m}");
            }
        }
    }
}
