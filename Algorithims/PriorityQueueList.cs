namespace Algorithims
{
    internal class PriorityQueueList
    {
        public Node header;

        public void Insert(int item)
        {
            var newNode = new Node(item);
            if (header == null)
            {
                header = newNode;
                return;
            }
            Node current = header;

            while (current.next != null)
            {
                if (item < current.value)
                {
                    newNode.next = current;
                    newNode.prev = current.prev;
                    current.prev.next = newNode;
                    current.prev = newNode;
                    return;
                }
                current = current.next;
            }
            if (item < current.value)
            {
                newNode.next = current;
                newNode.prev = current.prev;
                current.prev.next = newNode;
                current.prev = newNode;
            }
            else
            {
                current.next = newNode;
                newNode.prev = current;
            }
        }
        public void Print()
        {
            Node current = header;

            while (current != null)
            {
                Console.Write(current.value + " -> ");
                current = current.next;
            }
            Console.WriteLine();
        }
        public int RemoveMin()
        {
            int value = -1;
            if (header != null)
            {
                value = header.value;
                header = header.next;
            }
            return value;
        }
        public class Node
        {
            public Node next;
            public Node prev;
            public int value;
            public Node(int value)
            {
                this.value = value;
                next = null;
                prev = null;
            }
        }
    }

}
