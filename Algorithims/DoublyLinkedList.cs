using System;
using System.Text;
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

            while (current != null)
            {
                Console.Write(current.value + "->");
                current = current.next;
            }
            Console.WriteLine();
        }
        public int[] ProcessList(ref int min, ref int max)
        {
            Node current = header;
            int[] array = new int[5];
            int index = 0;

            while (current != null)
            {
                int value = current.value;

                if(value < min) min = value;
                else if(value > max) max = value;
                array[index++] = value;
                current = current.next;
            }

            return array;
        }
        public void Remove(int c)
        {
            Node current = header;
            while (current != null)
            {
                if (current.value == c)
                {
                    header = RemoveHelper(current);
                    break;
                }
                current = current.next;
            }
        }
        private Node RemoveHelper(Node node)
        {
            Node next = node.next;
            Node previous = node.previous;
            Node result = null;

            if (previous == null)
            {
                result = node.next;
            }
            else
            {
                node.previous = next;
                node.next = previous;
            }

            return result;
        }
        private void SwapElements(Node node1, Node node2)
        {
            // Ensure node1 comes before node2 in the list
            if (node1.next != node2)
            {
                Node temp = node1;
                node1 = node2;
                node2 = temp;
            }

            // Swap connections of node1
            Node node1Prev = node1.previous;
            Node node2Next = node2.next;

            if (node1Prev != null)
                node1Prev.next = node2;
            else
                header = node2; // Update header if node1 is the first node

            node2.previous = node1Prev;
            node1.next = node2Next;

            if (node2Next != null)
                node2Next.previous = node1;

            node1.previous = node2;
            node2.next = node1;
        }

        public void SortList(int c)
        {
            Node current = header;
            while (current != null)
            {
                if (current.value == 'B')
                {
                    Node runner = current.next;

                    while (runner != null && runner.value == 'B')
                    {
                        runner = runner.next;
                    }

                    if (runner != null)
                        SwapElements(current, runner);

                }

                current = current.next;
            }
        }



        public int FindMiddleElement() // O(n)
        {
            Node slow = header; // 1
            Node fast = header; // 1

            while (fast.next != null) // n/2 because fast will move 2 steps each time
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

