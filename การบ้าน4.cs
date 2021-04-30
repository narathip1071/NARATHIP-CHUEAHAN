using System;

namespace การบ้าน4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, c;
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                do
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                    n = int.Parse(Console.ReadLine());
                } while (n < 0);
            }


            for (i = 0; i <= n; i++)
            {
                for (c = 0; c <= i; c++)
                {
                    Console.Write("{0} ", factorial(i) / (factorial(c) * factorial(i - c)));
                }
                Console.WriteLine();
            }
            return;

        }
        static long factorial(int n)
        {
            int c;
            long result = 1;

            for (c = 1; c <= n; c++)
                result = result * c;
            return result;
        }
    }
}
