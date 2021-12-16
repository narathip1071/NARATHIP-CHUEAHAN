using System;
using System.Collections.Generic;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            Console.Write("numproduct: ");
            int numproduct = int.Parse(Console.ReadLine());

            while (true)
            {
                char shatters = char.Parse(Console.ReadLine());
                Node node = new Node(shatters);
                queue.Push(node);
            }
            char[] shatterssucceed = { 'A', 'B', 'C', 'D', 'E' };
        }

        static void processs(ref Queue queue,char[] shatterssucceed)
        {
            Queue Temporary = new Queue();
            Node Next;
            Node first = queue.Pop();
            List<Node> systemdata = new List<Node>();
            systemdata.Add(first);
            int sumproduct = 0;
            while (true)
            {
                Next = queue.Pop();
                if (Next==null)
                {
                    Next = Temporary.Pop();
                    
                }
                foreach (Node list in systemdata)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        if (Next.shatters == shatterssucceed[i])
                        {
                            sumproduct = sumproduct++;
                            
                        }
                        else if(Next.shatters != shatterssucceed[i])
                        {
                            Temporary.Push(Next);
                        }
                    }
                    Console.WriteLine(sumproduct);
                    Console.WriteLine(Temporary);
                }
            }
        }
    }

    class Node
    {
        public char shatters;
        public Node nextNode;
        
        public Node(char shattersValue)
        {
            shatters = shattersValue;
            nextNode = null;
        }
    }
    class Queue
    {
        private Node Rood;
        public void Push(Node node)
        {
            if (Rood == null)
            {
                Rood = node;
            }
            else
            {
                Node ptr = Rood;
                while (ptr.nextNode != null)
                {
                    ptr = ptr.nextNode;
                }
                ptr.nextNode = node;
            }
        }
        public Node Pop()
        {
            if (Rood == null)
            {
                return null;
            }
            Node node = Rood;
            Rood = Rood.nextNode;
            node.nextNode = null;
            return node;
        }
    }
}
