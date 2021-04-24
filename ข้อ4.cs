using System;

namespace สอบ4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dx, dy, step, x, y;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;
            {
                if (Math.Abs(dx) >= Math.Abs(dy))
                {
                    step = Math.Abs(dx);
                    dx /= step;
                }
                else
                {
                    step = Math.Abs(dy);
                    dy /= step;
                }

                x = x1;
                y = y1;
                int i = 1;

                for (i = 1; i <= step; i++)
                {
                    x += dx;
                    y += dy;
                }
                Console.WriteLine(i);
            }

        }
    }
}
