using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num = int.Parse(Console.ReadLine());
            int i = 0;
        
            for (i = 1; i <= num; i++)
            {
                 num1 = int.Parse(Console.ReadLine());
                int[] d = new int[num1];
            }
         
        }
       static void sort(ref int[] d,int num, int num1)
        {
            int count, max, j, k;
            for (count = 0; count < num; count++)
            {
                max = count;
                for (j = count + 1; j < num1; j++)
                {
                    if (d[max] < d[j])
                        max = j;
                }
                if (max != count)
                {
                    k = d[count];
                    d[count] = d[max];
                    d[max] = k;
                } 

            }
           
        }
    }
}
