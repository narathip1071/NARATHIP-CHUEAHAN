using System;

namespace ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;

            do
            {
                if (x < y)
                {
                    x = x + a;

                }
                if( x > y)
                {
                    y = y + b;
                }
            } while (x != y);

            Console.Write("{0}", x);
        }
    }
}
