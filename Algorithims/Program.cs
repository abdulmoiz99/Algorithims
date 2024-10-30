using Algorithims;


int[] numbersToInsert = { 25, 37, 28, 16, 7, 44, 23, 31, 47, 17, 26, 24, 11, 1, 38 };
var binaryTree = new BinaryTree(numbersToInsert[0]);
for (int i = 1; i < numbersToInsert.Length; i++)
{
    binaryTree.Insert(numbersToInsert[i]);
}
binaryTree.PreOrder();
binaryTree.PostOrder();
binaryTree.InOrder();