namespace Algorithims
{
    internal class DoublyLinkedList
    {
        Node header;

        public void Insert(char value)
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
        public char[] ProcessList(ref char min, ref char max)
        {
            Node current = header;
            char[] array = new char[5];
            int index = 0;

            while (current != null)
            {
                char value = current.value;

                if (value < min) min = value;
                else if (value > max) max = value;
                array[index++] = value;
                current = current.next;
            }

            return array;
        }
        public void Remove(char c)
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
        private void SwapElements(Node a, Node b)
        {
            char temp = a.value;
            a.value = b.value;
            b.value = temp;
        }

        public void SortList(char c, Node current = null)
        {

            if(current == null)
                current = header;

            while (current != null)
            {
                if (current.value != c)
                    break;

                current = current.next;
            }
            Node next = current.next;

            while (next != null)
            {
                if (next.value == c)
                {
                    SwapElements(current, next);
                    current = current.next;
                }
                next = next.next;
            }
        }
        public void SortListWithSkip(char c, char skipChar)
        {
            Node current = header;
            while(current!= null)
            {
                if (current.value != c)
                    break;
                else current = current.next;
            }
            SortList(c, current);
        }


        public char FindMiddleElement() // O(n)
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


        public class Node
        {
            public Node previous;
            public char value;
            public Node next;
        }
    }

}

