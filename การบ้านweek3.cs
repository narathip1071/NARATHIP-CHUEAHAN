using System;

namespace งานส่งวันศุกร์
{
    class Program
    {
        static void Main(string[] args)
        {
            string agency;
            int password, a, b, c, d, e, f;
            
            Console.Write("agency :");
            agency = Console.ReadLine();
            Console.Write("password :");
            password = int.Parse(Console.ReadLine());
          

            a = password / 100000;
            b = (password / 10000) % 10;
            c = (password / 1000) % 10;
            d = (password / 100) % 10;
            e = (password / 10) % 10;
            f = password % 10;
 
              
                if (agency == "CIA")
                {
                    if (f % 3 == 0 && e != 1 && e != 3 && e != 5 && c >= 6 && c != 8)
                        Console.WriteLine("TRUE");
                    else Console.WriteLine("FALSE");
                }
                if (agency == "FBI")
                {
                    if (a >= 4 && a <= 7 && d != 6 && d % 2 == 0 && b % 2 == 1)
                        Console.WriteLine("TRUE");
                    else Console.WriteLine("FALSE");
                }
                if (agency == "NSA")
                {
                    if (30 % f == 0 && d % 3 == 0 && d % 2 != 0 && (a == 7 || b == 7 || c == 7 || d == 7 || e == 7 || f == 7))
                        Console.WriteLine("TRUE");
                    else Console.WriteLine("FALSE");
                }

               if (agency != "CIA" && agency != "FBI" && agency != "NSA")
                Console.WriteLine("FALSE");


        }
    }
}
