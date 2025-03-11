using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//built in collections

//ArrayList

//class code
//{
//    public static void Main()
//    {
//        ArrayList a = new ArrayList();

//        a.Add(1);
//        a.Add("Hello");
//        a.Add("3.14");
//        a.Add(true);

//        Console.WriteLine("ArrayList after adding elements:");
//        PrintArrayList(a);

//        a.Insert(2, "Inserted Element");
//        Console.WriteLine("\nArrayList after inserting at index 2:");
//        PrintArrayList(a);

//        a.Remove(3.14);
//        Console.WriteLine("\nArrayList after removing 3.14:");
//        PrintArrayList(a);

//        a.RemoveAt(1);
//        Console.WriteLine("\nArrayList after removing at index 1:");
//        PrintArrayList(a);

//        Console.WriteLine("\nElement at index 1: " + a[1]);

//        a[1] = "New Value at index 1";
//        Console.WriteLine("\nArrayList after setting new value at index 1:");
//        PrintArrayList(a);

//        Console.WriteLine("\nContains 'Hello': " + a.Contains("Hello"));

//        Console.WriteLine("\nIndex of 'New Value at index 1': " + a.IndexOf("New Value at index 1"));

//        a.Clear();
//        Console.WriteLine("\n ArrayList after clearing all elements");
//        PrintArrayList(a);
//    }
//    static void PrintArrayList(ArrayList arr)
//    {
//        foreach (var a in arr)
//        {
//            Console.WriteLine(a);
//        }
//    }
//}


//Generic-List
//class Program
//{
//    public static void Main()
//    {
//        List<int> list = new List<int>();

//        list.Add(10);
//        list.Add(20);
//        list.Add(30);
//        list.Add(40);

//        Console.WriteLine("List after adding elements:");
//        PrintList(list);

//        list.Insert(2, 25);
//        Console.WriteLine("\nList after inserting 25 at index 2:");
//        PrintList(list);

//        list.Remove(20);
//        Console.WriteLine("\nList after removing 20:");
//        PrintList(list);

//        list.RemoveAt(1);
//        Console.WriteLine("\nList after removing element at index 1:");
//        PrintList(list);

//        Console.WriteLine("\nElement at index 1: " + list[1]);

//        list[1] = 50;
//        Console.WriteLine("\nList after modifying value at index 1:");
//        PrintList(list);

//        Console.WriteLine("\nList contains 30: " + list.Contains(30));

//        Console.WriteLine("\nIndex of 50 in the list: " + list.IndexOf(50));

//        Console.WriteLine("\nCount of elements in the list: " + list.Count);

//        list.Clear();
//        Console.WriteLine("\nList after clearing all elements:");
//        PrintList(list);
//    }

//    static void PrintList(List<int> list)
//    {
//        foreach (var item in list)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



//Hashtable
//class Program
//{
//    public static void Main()
//    {
//        Hashtable hashtable = new Hashtable();

//        hashtable.Add(1, "One");
//        hashtable.Add(2, "Two");
//        hashtable.Add(3, "Three");
//        hashtable.Add("A", "Apple");
//        hashtable.Add("B", "Banana");

//        Console.WriteLine("Hashtable after adding elements:");
//        PrintHashtable(hashtable);

//        Console.WriteLine("\nValue for key 1: " + hashtable[1]);

//        Console.WriteLine("\nContains key 2:" + hashtable.ContainsKey(2));

//        Console.WriteLine("\nContains value 'Banana': " + hashtable.ContainsValue("Banana"));

//        hashtable.Remove(3);
//        Console.WriteLine("\nHashtable after removing key 3:");
//        PrintHashtable(hashtable);

//        Console.WriteLine("\nAll keys in Hashtable:");
//        foreach (var key in hashtable.Keys)
//        {
//            Console.WriteLine(key);
//        }

//        Console.WriteLine("\nAll values in Hashtable:");
//        foreach (var value in hashtable.Values)
//        {
//            Console.WriteLine(value);
//        }

//        hashtable.Clear();
//        Console.WriteLine("\nHashtable after clearing all elements:");
//        PrintHashtable(hashtable);
//    }

//    static void PrintHashtable(Hashtable hashtable)
//    {
//        foreach (DictionaryEntry entry in hashtable)
//        {
//            Console.WriteLine($"Key:{entry.Key}, Value: {entry.Value}");
//        }
//    }
//}



//Dictionary

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Dictionary<string, int> dict = new Dictionary<string, int>();
//        dict.Add("One", 1);
//        dict.Add("Two", 2);
//        dict.Add("Three", 3);
//        dict.Add("Four", 4);

//        Console.WriteLine("Dictionary after adding elements:");
//        PrintDictionary(dict);

//        Console.WriteLine("\nValue for key 'Two': " + dict["Two"]);

//        Console.WriteLine("\nContains key 'One': " + dict.ContainsKey("one"));

//        Console.WriteLine("\nContains value 3: " + dict.ContainsValue(3));

//        dict.Remove("Three");
//        Console.WriteLine("\nDictionary after removing key 'Three':");
//        PrintDictionary(dict);

//        if (dict.TryGetValue("Four", out int value))
//        {
//            Console.WriteLine("\nValue for key 'Four': " + value);
//        }
//        else
//        {
//            Console.WriteLine("\nKey 'Four' not found.");
//        }

//    }
//    static void PrintDictionary(Dictionary<string,int> fet)
//    {
//        foreach (var res in fet)
//        {
//            Console.WriteLine($"Key:{res.Key}, Value:{res.Value} ");
//        }
//    }
//}



//Queue-non generic
//class Program
//{
//    public static void Main()
//    {
//        Queue queue = new Queue();
//        queue.Enqueue(1);
//        queue.Enqueue("Hello");
//        queue.Enqueue(3.14);
//        queue.Enqueue(true);

//        Console.WriteLine("Queue after enqueuing elements:");
//        PrintQueue(queue);

//        Console.WriteLine("\nPeek front element: " + queue.Peek());

//        Console.WriteLine("\nDequeue element: " + queue.Dequeue());
//        Console.WriteLine("\nQueue after dequeuing one element:");
//        PrintQueue(queue);

//        Console.WriteLine("\nContains 'Hello': " + queue.Contains("Hello"));

//        queue.Clear();
//        Console.WriteLine("\nQueue after clearing:");
//        PrintQueue(queue);
//    }

//    static void PrintQueue(Queue queue)
//    {
//        foreach (var item in queue)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



//Queue-Generic

//class Program
//{
//    public static void Main()
//    {
//        Queue<int> intQueue = new Queue<int>();
//        intQueue.Enqueue(1);
//        intQueue.Enqueue(2);
//        intQueue.Enqueue(3);

//        Console.WriteLine("Queue after enqueuing integers:");
//        PrintQueue(intQueue);

//        Console.WriteLine("\nPeek front element: " + intQueue.Peek());

//        Console.WriteLine("\nDequeue element: " + intQueue.Dequeue());
//        Console.WriteLine("\nQueue after dequeuing one element:");
//        PrintQueue(intQueue);

//        Console.WriteLine("\nContains '2': " + intQueue.Contains(2));

//        intQueue.Clear();
//        Console.WriteLine("\nQueue after clearing:");
//        PrintQueue(intQueue);

//        Queue<string> stringQueue = new Queue<string>();
//        stringQueue.Enqueue("Hello");
//        stringQueue.Enqueue("World");

//        Console.WriteLine("\nQueue after enqueuing strings:");
//        PrintQueue(stringQueue);

//        Console.WriteLine("\nPeek front element: " + stringQueue.Peek());
//    }

//    static void PrintQueue<T>(Queue<T> queue)
//    {
//        foreach (var item in queue)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



//Stack

//class NonGenericStackExample
//{
//    static void Main()
//    {
//        Stack stack = new Stack();

//        stack.Push(10);
//        stack.Push("Hello");
//        stack.Push(3.14);

//        Console.WriteLine("Popped item: " + stack.Pop());
//        Console.WriteLine("Popped item: " + stack.Pop());
//        Console.WriteLine("Popped item: " + stack.Pop());

//        if (stack.Count == 0)
//        {
//            Console.WriteLine("The stack is empty.");
//        }
//    }
//}



//Stack generic
//class Program
//{
//    static void Main()
//    {
//        Stack<int> stack = new Stack<int>();

//        stack.Push(10);
//        stack.Push(20);
//        stack.Push(30);

//        Console.WriteLine("Popped item: " + stack.Pop());
//        Console.WriteLine("Popped item: " + stack.Pop());
//        Console.WriteLine("Popped item: " + stack.Pop());

//        Console.WriteLine("Is stack empty? " + (stack.Count == 0));
//    }
//}


//SortedList

//class Program
//{
//    static void Main()
//    {

//        SortedList sortedList = new SortedList();

//        sortedList.Add(3, "Apple");
//        sortedList.Add(1, "Banana");
//        sortedList.Add(2, "Cherry");

//        foreach (DictionaryEntry entry in sortedList)
//        {
//            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
//        }

//        Console.WriteLine("\nAccess value with key 2: " + sortedList[2]);

//        if (sortedList.ContainsKey(1))
//        {
//            Console.WriteLine("\nKey 1 exists in the SortedList.");
//        }

//        sortedList.Remove(1);
//        Console.WriteLine("\nAfter removing key 1:");
//        foreach (DictionaryEntry entry in sortedList)
//        {
//            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
//        }

//        if (!sortedList.ContainsKey(1))
//        {
//            Console.WriteLine("\nKey 1 does not exist anymore.");
//        }
//    }
//}




//SortedList - Generic 

//class Program
//{
//    static void Main()
//    {
//        SortedList<int, string> sortedL = new SortedList<int, string>();
//        sortedL.Add(3, "Apple");
//        sortedL.Add(2, "Banana");
//        sortedL.Add(1, "Cherry");

//        Console.WriteLine($"Contains key 2:{sortedL.ContainsKey(2)}");

//        Console.WriteLine($"Value for key 1:{sortedL[1]}");

//        Console.WriteLine($"Index of key 2:{sortedL.IndexOfKey(2)}");


//        sortedL.RemoveAt(0);  
//        Console.WriteLine($"Contains key 2 after removal by index: {sortedL.ContainsKey(2)}"); 


//        sortedL.Clear();
//        Console.WriteLine($"Count after clear: {sortedL.Count}");  


//        sortedL.Add(10, "Ten");
//        sortedL.Add(20, "Twenty");


//        foreach (var pair in sortedL)
//        {
//            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
//        }


//        sortedL.TrimExcess();
//        Console.WriteLine($"Trimmed excess capacity. Current count: {sortedL.Count}");


//        var keys = sortedL.Keys;
//        var values = sortedL.Values;

//        Console.WriteLine("Keys: ");
//        foreach (var key in keys)
//        {
//            Console.WriteLine(key);
//        }

//        Console.WriteLine("Values: ");
//        foreach (var value in values)
//        {
//            Console.WriteLine(value);
//        }
//    }
//}



//LinkedList - generic

//class Program
//{
//    static void Main()
//    {
//        LinkedList<int> L = new LinkedList<int>();
//        L.AddLast(10);
//        L.AddLast(20);
//        L.AddLast(30);
//        L.AddFirst(5);

//        Console.WriteLine("Elements in the LinkedList:");
//        foreach(var item in L)
//        {
//            Console.WriteLine(item);
//        }
//        L.RemoveFirst();
//        L.RemoveLast();

//        Console.WriteLine("\nAfter removing the first and last elements:");
//        foreach (var item in L)
//        {
//            Console.WriteLine(item);
//        }
//        var node = L.Find(20);
//        if (node != null)
//        {
//            L.Remove(node);
//        }
//        foreach (var item in L)
//        {
//            Console.WriteLine(item);
//        }
//        Console.WriteLine("\nDoes the list contain 10? " + L.Contains(10)); 
//        Console.WriteLine("Does the list contain 40? " + L.Contains(40));
//    }
//}


//SortedSet

//class Program
//{
//    static void Main()
//    {
//        SortedSet<int> s = new SortedSet<int>();

//        s.Add(10);
//        s.Add(5);
//        s.Add(15);

//        Console.WriteLine("Sorted contents:");
//        foreach (var item in s)
//        {
//            Console.WriteLine(item);
//        }
//        Console.WriteLine("\nContains 10? " + s.Contains(10));
//        Console.WriteLine("Contains 100? " + s.Contains(100));


//        s.Remove(5);

//        Console.WriteLine("\nAfter removing 5:");
//        foreach (var item in s)
//        {
//            Console.WriteLine(item);
//        }


//        SortedSet<int> otherSet = new SortedSet<int> { 15, 25, 30 };


//        s.UnionWith(otherSet);
//        Console.WriteLine("\nAfter UnionWith another set:");
//        foreach (var item in s)
//        {
//            Console.WriteLine(item);
//        }

//        s.IntersectWith(otherSet);
//        Console.WriteLine("\nAfter IntersectWith another set:");
//        foreach (var item in s)
//        {
//            Console.WriteLine(item);
//        }


//        s.ExceptWith(otherSet);
//        Console.WriteLine("\nAfter ExceptWith another set:");
//        foreach (var item in s)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



//HashSet

//class Program
//{
//    static void Main()
//    {

//        HashSet<int> hashSet = new HashSet<int>();

//        hashSet.Add(10);
//        hashSet.Add(20);
//        hashSet.Add(30);
//        hashSet.Add(10);  

//        Console.WriteLine("HashSet contents:");
//        foreach (var item in hashSet)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("\nContains 10? " + hashSet.Contains(10));  
//        Console.WriteLine("Contains 40? " + hashSet.Contains(40));  

//        bool removed = hashSet.Remove(20);
//        Console.WriteLine("\nAfter removing 20:");
//        foreach (var item in hashSet)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("\nContains 20? " + hashSet.Contains(20));  

//        hashSet.Clear();
//        Console.WriteLine("\nAfter clearing:");
//        Console.WriteLine("Count: " + hashSet.Count);  
//    }
//}


//CollectionBase


//namespace custocoll
//{
//    public class MyCollection : CollectionBase
//    {
//        public void AddItem(int item)
//        {
//            this.List.Add(item);
//        }
//        public int GetItem(int index)
//        {
//            return (int)this.List[index];
//        }
//        public void RemoveItem(int item)
//        {
//            this.List.Remove(item);
//        }
//        public override string ToString()
//        {
//            string result = "Collection Contents:";
//            foreach (var item in this.List)
//            {
//                result += item + " ";
//            }
//            return result;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {

//            MyCollection collection = new MyCollection();


//            collection.AddItem(10);
//            collection.AddItem(20);
//            collection.AddItem(30);


//            Console.WriteLine(collection.ToString());


//            Console.WriteLine("Item at index 1: " + collection.GetItem(1));

//            collection.RemoveItem(20);
//            Console.WriteLine("After removing 20: " + collection.ToString());
//        }
//    }
//}

//Expression Tree
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Expression<Func<int, bool>> lam = num => num < 5;
//        bool result = lam.Compile()(3);
//        Console.WriteLine(result);
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    { 
//        BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(10), Expression.Constant(2));
//        BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Divide, Expression.Constant(10), Expression.Constant(5));
//        BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(10), Expression.Constant(2));
//        BinaryExpression b4 = Expression.MakeBinary(ExpressionType.Subtract, b1, b2);
//        BinaryExpression b5 = Expression.MakeBinary(ExpressionType.Add, b4, b3);


//        int result = Expression.Lambda<Func<int>>(b5).Compile()();
//        Console.WriteLine("( 10* 2 ) + ( 10/5) - (5-1) : {0}", result);
//    }
//}



//Decompose
//class Program
//{
//    static void Main()
//    {
//        Expression<Func<int, bool>> expr = num => num < 5;
//        ParameterExpression param = (ParameterExpression)expr.Parameters[0];
//        BinaryExpression operation = (BinaryExpression)expr.Body;
//        ParameterExpression left = (ParameterExpression)operation.Left;
//        ConstantExpression right = (ConstantExpression)operation.Right;

//        Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}", param.Name, left.Name, operation.NodeType, right.Value);
//    }
//}


//Creating Expression tree
//class Program
//{
//    static void Main()
//    {
//        Expression<Func<int, int, int>> expr = (a, b) => a + b;
//        Console.WriteLine(expr.Body);
//    }
//}

//Breaking Down
//class Program
//{
//    static void Main()
//    {
//        Expression<Func<int, int, int>>expr = (a, b) => a + b;
//        ParameterExpression param1 = expr.Parameters[0];
//        ParameterExpression param2 = expr.Parameters[1];
//        Console.WriteLine($"Parameter 1: {param1.Name}");
//        Console.WriteLine($"Parameter 2: {param2.Name}");
//        BinaryExpression operation = (BinaryExpression)expr.Body;
//        Console.WriteLine($"Operation: {operation.NodeType}");
//        BinaryExpression body = (BinaryExpression)expr.Body;
//        Console.WriteLine("Left Operand:" + body.Left);
//        Console.WriteLine("Right Operand:" + body.Right);
//    }
//}



//Visitor
class Program
{
    static void Main()
    {
        Expression<Func<int>> expr = () => 5 + 10;
        VisitExpression(expr.Body);
    }
    static void VisitExpression(Expression expr)
    {
        if (expr is BinaryExpression binary)
        {
            Console.WriteLine($"Operator: {binary.NodeType}");
            VisitExpression(binary.Left);
            VisitExpression(binary.Right);
        }
        else if (expr is ConstantExpression constant)
        {
            Console.WriteLine($"Constant: {constant.Value}");
        }
    }
}