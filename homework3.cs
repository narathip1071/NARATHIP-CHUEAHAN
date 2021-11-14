using System;
using System.Collections.Generic;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            char Instruction;
            char Data;
            while (true)
            {

                Instruction = char.Parse(Console.ReadLine());
                if (Instruction == '?')
                {
                    break;
                }
                Data = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Node node = new Node(Instruction, Data);
                queue.Push(node);
            }
            processs(ref queue);

        }
        static void processs(ref Queue queue)
        {
            Queue Temporary = new Queue(); 
            Node Next;
            Node first = queue.Pop();
            List<Node> CPU = new List<Node>();
            CPU.Add(first);
            int row = 1;
            int column = 1;
            int column1 = 1;
            int processing =0 ;
            while (true)
            {
               
                Next = queue.Pop();
                if (Next== null)
                {
                    break;
                }
                foreach (Node list in CPU)
                {
                    if (Next.Instruction == list.Instruction)
                    {
                        if (Next.Data == list.Data)
                        {

                            row = 0; column = 0; break; 
                        }
                        else if (Next.Data != list.Data)
                        {
                            column1++; 
                            
                        }
                    }
                    else if (Next.Instruction != list.Instruction)
                    {
                            row++; column++; CPU.Add(Next);
                    }
                }
                if (column == 4 && row == 4||column1==3 )
                {
                    processing++;
                    Console.WriteLine("CPU cycles needed: {0}",processing);
                    Temporary.Push(Next);
                    Queue queue1 = Temporary;
                    if(processing>0)
                    { 
                        processs(ref queue);
                    }
                    else
                    {
                        break;
                    }
                }
               
            }
            
        }
    }
    class Node
    {
        public char Instruction;
        public char Data;
        public Node nextNode;
        public Node(char InstructionValue, char DataValue)
        {
            Instruction = InstructionValue;
            Data = DataValue;
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
