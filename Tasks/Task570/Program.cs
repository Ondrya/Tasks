using System;

namespace Task570
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Сколько чисел Мерсенна вывести (макс. 64): ");
            var _n = Console.ReadLine();
            try
            {
                var N = ulong.Parse(_n);
                if (N >= 65) throw new ArgumentException("Число слишком большое. MaxValue: 64");
                ВывестиЧислаМерсенна(N);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Вывести на консоль последовательность первых N чисел Мерсенна
        /// </summary>
        /// <param name="N"></param>
        private static void ВывестиЧислаМерсенна(ulong N)
        {
            GetMersennePrime(N);
        }

        /// <summary>
        /// Output to console Mersonne prime
        /// </summary>
        /// <param name="N"></param>
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
