using Algorithims;




/*
 *  ------ Binary Search Tree Implementation
int[] numbersToInsert = { 25, 37, 28, 16, 7, 44, 23, 31, 47, 17, 26, 24, 11, 1, 38 };
var binaryTree = new BinaryTree(numbersToInsert[0]);
for (int i = 1; i < numbersToInsert.Length; i++)
{
    binaryTree.Insert(numbersToInsert[i]);
}
binaryTree.PreOrder();
binaryTree.PostOrder();
binaryTree.InOrder();
*/


// Stack Implmenetation
int[] numbersToInsert = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
var stack = new Stack();
foreach (int number in numbersToInsert)
{
    stack.Push(number);
}
while (!stack.IsEmpty())
{
    Console.WriteLine(stack.Pop());
}


