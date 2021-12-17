using System;
using System.Collections.Generic;
namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int numbercity = int.Parse(Console.ReadLine());
            string[] namecity = new string[numbercity];
            for (int i = 0; i < numbercity; i++)
            {
                Console.Write("nameCity{0} : ", i);
                namecity[i] = Console.ReadLine();
            }
            int[,] distance = new int[numbercity,numbercity];
            int x = 1;
            do
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("s : ");
                    distance[x, j] = int.Parse(Console.ReadLine());
                    distance[j, x] = distance[x, j];
                }
                x++;

            } while (x < numbercity);

            string namelater = Console.ReadLine();
            int[] Shortestdistance = DijkstraAlgo(distance, 0, numbercity);
            Print(Shortestdistance, namelater, namecity);

        }
       static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
       }

        static void Print(int[] Shortestdistance,string namelater, string[] name)
        {
            Console.WriteLine("shortest distance to namelater : ");

            for (int i = 0; i < name.Length;i++)
            {
                if(namelater==name[i])
                {
                    Console.WriteLine( Shortestdistance[i]);
                    break;
                }
            }   
        }
         static int[] DijkstraAlgo(int[,] graph, int source, int verticesCount)
         {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && graph[u, v] != -1 && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }
            return distance;
         }

    }
}
