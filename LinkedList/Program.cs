using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    internal class LinkList
    {
        private Node Head { get; set; }
        private Node Tails { get; set; }
        private Node Current { get; set; }
        private Node Previous { get; set; }
        private Node Next { get; set; }
        private int Size { get; set; }

        public void Push(int value)
        {
            Size++;
            var node = new Node() { Value = value };
            if (Head == null)
            {
                Head = node;
                Console.WriteLine($"Головной узел:{Head.Value}");
            }
            else
            {
                Current.Next = node;
                Console.WriteLine($"Текущий указатель:{Current.Next.Value}");
            }
            Current = node;
            Console.WriteLine($"Текущий узел:{Current.Value}");
        }

        public void PushStart(int value)
        {
            Size++;
            var node = new Node() { Value = value };
            node.Next = Head;
            Head = node;
            Console.WriteLine($"Головной узел:{Head.Value}");
            Console.WriteLine($"Головной указатель:{Head.Next.Value}");
            if (Size == 0)
            {
                Tails = Head;
                Size++;
            }
        }

        public void Reverse()
        {
            Console.WriteLine($"Метод Reverse");

            if (Head == null) return;

            Previous = null;
            Current = Head;
            Next = null;

            while (Current.Next != null)
            {
                Next = Current.Next;
                Current.Next = Previous;
                Previous = Current;
                //Console.WriteLine($"Предыдущий:{Previous.Value}");
                Current = Next;
                Console.WriteLine($"Текущий узел:{Previous.Value}");
                if(Previous.Next != null)
                {
                    Console.WriteLine($"Текущий указатель:{Previous.Next.Value}");
                }
                else
                {
                    Console.WriteLine($"Текущий указатель:null");
                }
            }

            Current.Next = Previous;
            Head = Current;
            Console.WriteLine($"Текущий узел:{Head.Value}");
            Console.WriteLine($"Текущий указатель:{Head.Next.Value}");
            Console.WriteLine($"Головной узел:{Head.Value}");
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Node node = new Node();
            LinkList linkList = new LinkList();
            linkList.Push(1);
            linkList.Push(2);
            linkList.Push(3);
            linkList.Push(4);
            //linkList.PushStart(10);
            linkList.Reverse();
            Console.ReadKey();
        }
    }

}