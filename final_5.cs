using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            input(num);


        }
        static void input(int num)
        {
            string Itemname;
            string Itemtype;
            int N = 0;

            for (int i = 0; i < num; i++)
            {
                Itemname = Console.ReadLine();
                Itemtype = Console.ReadLine();

                string Itemmode = Console.ReadLine();

                if (Itemmode == "ShowAll")
                {
                    Console.WriteLine(Itemname);
                    Console.WriteLine(Itemtype);
                    Console.WriteLine();
                }
                else if (Itemmode == Itemtype)
                {
                    Console.WriteLine(Itemtype);
                }
                else
                {
                    Console.WriteLine("End");
                }
            }
        }
    }

    

        
       
    }
}
