using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y;

            Console.Write("mode:");
            mode = Console.ReadLine();
            Console.Write("x : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y : ");
            y = double.Parse(Console.ReadLine());

            if (mode == "time" || mode == "price")
            {
                if (x >= 0)
                {
                    if (mode == "time")
                    {
                        y = Math.Pow((x - 1), 2);
                        Console.WriteLine("{0}, {1}", x, y);
                    }
                    else if (mode == "price")
                    {
                        x = Math.Sqrt(y) + 1;
                        Console.WriteLine("{0}, {1}", x, y);
                    }
                }
                else if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else Console.WriteLine("Invalid mode");


        }
    }
    
}
