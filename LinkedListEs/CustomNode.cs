using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEs
{
    public class CustomNode
    {
        private Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            last.Next = newNode;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddToAPosition(int data, int position)
        {
            Node newNode = new Node(data);
            if (position == 0)
            {
                AddFirst(data);
                return;
            }
            Node current = head;
            for (int i = 0; current != null && i < position - 1/*2*/; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of bounds.");
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }


        public bool Remove(int key)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.Data == key)
            {
                head = temp.Next;
                return true;
            }
            while (temp != null && temp.Data != key)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                return false;
            }
            prev.Next = temp.Next;
            return true;
        }


        public void Display()
        {
            Node current = head;
            Console.Write("Lista: ");
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }

        public void DisplayNumeriPari()
        {
            Node current = head;
            Console.Write("Lista numeri pari: ");
            while (current != null)
            {
                if (current.Data % 2 == 0)
                {
                    Console.Write($"{current.Data} -> ");
                }
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }

        public void DisplayNumeriDispari()
        {
            Node current = head;
            Console.Write("Lista numeri dispari: ");
            while (current != null)
            {
                if (current.Data % 2 != 0)
                {
                    Console.Write($"{current.Data} -> ");
                }
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
