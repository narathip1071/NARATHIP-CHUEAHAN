using System;

namespace Practice_Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum,a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            sum = a + b + c;
            while (sum >= 0)
            {
                Console.Write("tank A: ");
                int tankA = int.Parse(Console.ReadLine());
                Console.Write("box A : ");
                int boxA = int.Parse(Console.ReadLine());
                sum = sum - boxA;
                if(sum==0)
                {
                    Console.WriteLine("The winner is : B");
                    break;
                }

                Console.Write("tank B: ");
                int tankB = int.Parse(Console.ReadLine());
                Console.Write("box B : ");
                int boxB = int.Parse(Console.ReadLine());
                sum = sum - boxB;
                if(sum==0)
                {
                    Console.WriteLine("The winner is : A");
                    break;
                }
            }
        }
    }
    
}
