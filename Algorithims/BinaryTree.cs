namespace Algorithims
{
    internal class BinaryTree
    {
        private Node root;
        public BinaryTree(int initialValue)
        {
            Node node = new Node(initialValue, null);
            root = node;
        }
        public void Insert(int value)
        {
            Node? current = root;
            while (true)
            {
                if (value < current.element && current.leftChild != null)
                    current = current.leftChild;
                else if (value > current.element && current.rightChild != null)
                    current = current.rightChild;
                else break;

            }
            _attachNode(current, value);

        }
        public void PreOrder()
        {
            PreOrderHelper(root);
            Console.WriteLine();
        }
        public void PostOrder()
        {
            PostOrderHelper(root);
            Console.WriteLine();
        }
        public void InOrder()
        {
            InOrderHelper(root);
            Console.WriteLine();
        }
        private void PreOrderHelper(Node? node)
        {
            if (node == null) return;

            PrintNode(node);
            PreOrderHelper(node.leftChild);
            PreOrderHelper(node.rightChild);

        }
        private void PostOrderHelper(Node? node)
        {
            if (node == null) return;

            PostOrderHelper(node.leftChild);
            PostOrderHelper(node.rightChild);
            PrintNode(node);
        }
        private void InOrderHelper(Node? node)
        {
            if (node == null) return;

            InOrderHelper(node.leftChild);
            PrintNode(node);
            InOrderHelper(node.rightChild);
        }
        private void PrintNode(Node? node)
        {
            Console.Write(node?.element + ", ");
        }
        private void _attachNode(Node current, int value)
        {
            var node = new Node(value, current);
            if (value < current.element)
                current.leftChild = node;
            else current.rightChild = node;
        }
    }
    class Node
    {
        public int element;
        public Node? parent;
        public Node? leftChild;
        public Node? rightChild;

        public Node(int element, Node? parent)
        {
            this.element = element;
            this.parent = parent;
        }
    }
}
