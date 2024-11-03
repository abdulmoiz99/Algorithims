using System;
namespace Algorithims
{
    internal class DoublyLinkedList
    {
        Node header;

        public void Insert(int value)
        {
            Node current = header;
            if (current == null)
            {
                var Node = new Node();
                Node.value = value;
                header = Node;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                var Node = new Node();
                Node.value = value;
                Node.previous = current;
                current.next = Node;
            }
        }
        public void Print()
        {
            Node current = header;

            while(current != null)
            {
                Console.Write(current.value + ",");
                current = current.next;
            }
            Console.WriteLine();
        }

        public int FindMiddleElement() // O(n)
        {
            Node slow = header; // 1
            Node fast = header; // 1
            
            while(fast.next != null) // n/2 because fast will move 2 steps each time
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            return slow.value; // 1
        }


        class Node
        {
            public Node previous;
            public int value;
            public Node next;
        }
    }

}
