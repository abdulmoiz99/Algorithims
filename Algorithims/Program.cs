using Algorithims;
using System.Net;




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


//// Stack Implmenetation
//int[] numbersToInsert = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
//var stack = new Stack();
//foreach (int number in numbersToInsert)
//{
//    stack.Push(number);
//}
//while (!stack.IsEmpty())
//{
//    Console.WriteLine(stack.Pop());
//}


////Selection Sort

//int[] numbersToSort = { 4, 7, 2, 1, 9, 5, 3, 8, 0, 6 };
//SelectionSort.Sort(ref numbersToSort);
//foreach (int number in numbersToSort)
//{
//    Console.Write(number + ",");
//}


////Insertion Sort

//int[] numbersToSort = { 23, 1, 10, 5, 2 };
//numbersToSort =  InsertionSort.Sort(numbersToSort);
//foreach (int number in numbersToSort)
//{
//    Console.Write(number + ",");
//}


//// Priority Queue With List
//var priorityQueue = new PriorityQueueList();
//Console.WriteLine(priorityQueue.RemoveMin());

//priorityQueue.Insert(1);
//priorityQueue.Insert(6);
//priorityQueue.Insert(3);
//priorityQueue.Insert(2);
//priorityQueue.Insert(4);
//priorityQueue.Insert(5);
//priorityQueue.Print();

//Console.WriteLine(priorityQueue.RemoveMin());
//Console.WriteLine(priorityQueue.RemoveMin());
//Console.WriteLine(priorityQueue.RemoveMin());
//priorityQueue.Print();



//Suppose we are given two n-element sorted sequences A and B that should not
//be viewed as sets (that is, A and B may contain duplicate entries). Give an O(n)-time
//pseudo-code algorithm for computing a sequence representing the set A  B (with no
//duplicates).

//int[] array1 = { 1, 2, 5, 6, 10, 15, 18 };
//int[] array2 = { 4, 7, 10, 18, 19, 20, 21 };
//var list = new List<int>();
//var sequence1 = new Sequence();
//var sequence2 = new Sequence();


//for (int i = 0; i < array1.Length; i++)
//{
//    sequence1.InsertLast(array1[i]);
//    sequence2.InsertLast(array2[i]);
//}

//while (!sequence1.IsEmpty() && !sequence2.IsEmpty())
//{
//    if (sequence1.First() == sequence2.First())
//    {
//        list.Add(sequence1.RemoveFirst());
//        sequence2.RemoveFirst();
//    }
//    else if (sequence1.First() < sequence2.First())
//        list.Add(sequence1.RemoveFirst());
//    else
//        list.Add(sequence2.RemoveFirst());
//}
//while (!sequence1.IsEmpty())
//{
//    list.Add(sequence1.RemoveFirst());
//}

//while (!sequence2.IsEmpty())
//{
//    list.Add(sequence2.RemoveFirst());
//}

//Console.WriteLine("Sequence Result");
//foreach (var item in list)
//{
//    Console.Write(item + ",");
//}



/// 
// Implemtation Of Doubly Linked List

//var list = new DoublyLinkedList();

//list.Insert(1);
//list.Insert(2);
//list.Insert(3);
//list.Insert(4);
//list.Insert(5);

//list.Print();

//Console.WriteLine(list.FindMiddleElement());


//// QUEUE WITH 2 Stacks

//int[] array = { 1, 2, 3, 4, 5, 6 };
//var queue = new QueueWithStack();
//foreach (var item in array)
//{
//    queue.EnQueue(item);
//}
//while (!queue.IsEmpty())
//{
//    Console.Write(queue.Dequeue() + ",");
//}

//int[] array = { 1, 2, 3, 4, 5, 6 };
//var stack = new StackWithQueue();
//foreach (int item in array)
//{
//    stack.Push(item);
//}

//while (!stack.IsEmpty())
//{
//    Console.WriteLine(stack.Pop());
//}



///// WHO WINS THE ELECTION 

//int[] votes = { 1, 2, 1, 1, 3, 2 };

//int winingCandidate = votes[0];
//int voteCount = int.MinValue;
//int winingVote = int.MinValue;

//for (int i = 0; i < votes.Length; i++)
//{
//    for (int j = 0; j < votes.Length; j++)
//    {
//        if (votes[i] == votes[j])
//        {
//            voteCount++;
//        }
//    }
//    if (voteCount > winingVote)
//    {
//        winingVote = voteCount;
//        winingCandidate = votes[i];
//    }
//    voteCount = 0;
//}
//Console.WriteLine(winingCandidate);



///// WHO WINS THE ELECTION 
//var voteCounts = new Dictionary<int, int>();
//int _winingCandidate = 0;
//int _winingVote = int.MinValue;
//for (int i = 0; i < votes.Length; i++)
//{
//    if (voteCounts.ContainsKey(votes[i]))
//    {
//        voteCounts[votes[i]]++;
//    }
//    else
//    {
//        voteCounts[votes[i]] = 1;
//    }
//    if (voteCounts[votes[i]] > _winingVote)
//    {
//        _winingCandidate = votes[i];
//        _winingVote = voteCounts[votes[i]];
//    }
//}

//Console.WriteLine(_winingCandidate);

//foreach (var item in voteCounts)
//{
//    Console.WriteLine(item.Key + ": " + item.Value);
//}


//// IN PLACE QUICK SORT
//int[] numbers = { 9, 7, 5, 11, 6, 2, 14, 3, 10, 12 };

//InplaceQuickSort.Sort(ref numbers);

// string[] objects = { "BLUE", "RED", "BLUE", "RED", "BLUE", "BLUE", "RED", "RED", "BLUE" };


//int endPointer = objects.Length - 1;
//for (int i = 0; i < objects.Length; i++) 
//{
//    if (objects[i] == "BLUE") 
//    {
//        endPointer = FindAvailableIndex(endPointer, i); 
//        if (endPointer != -1)
//        {
//            (objects[i], objects[endPointer]) = (objects[endPointer], objects[i]);
//        }
//        else break;
//    }
//}
//int FindAvailableIndex(int startIndex, int currentIndex)
//{
//    for (int i = startIndex; i > currentIndex; i--)
//        if (objects[i] == "RED") return i;

//    return -1;
//}



//string[] objects = { "BLUE", "RED", "BLUE", "RED", "BLUE", "BLUE", "RED", "RED", "BLUE" };

//int leftPointer = 0, rightPointer = objects.Length - 1;

//while (leftPointer <= rightPointer)
//{
//    if(objects[leftPointer] == "BLUE" && objects[rightPointer] == "RED")
//    {
//        (objects[leftPointer], objects[rightPointer]) = (objects[rightPointer], objects[leftPointer]);
//        leftPointer++;
//        rightPointer--;
//    }
//    else if (objects[leftPointer] == "RED")
//        leftPointer++;
//    else
//        rightPointer--;

//}

//foreach (string obj in objects)
//{
//    Console.Write(obj + ", ");
//}



//// in place quick sort
//int[] numbers = { 9, 7, 2, 5, 11, 6, 2, 14, 3, 10, 12 };

//InplaceQuickSort.Sort(numbers);

