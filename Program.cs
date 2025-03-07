using System;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Numerics;
//using partialmetho;
////Collections

////Array

//namespace ArrayDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] Numbers = { 10, 20, 30 };

//            Console.WriteLine("Accessing the Array elements using for loop");

//            for (int i = 0; i <= Numbers.Length - 1; i++)
//            {
//                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//            }

//            Console.WriteLine("Asccessing using foreach loop");

//            foreach(int num in Numbers)
//            {
//                Console.WriteLine($"{num}");
//            }
//        }
//    }
//}


//namespace ArrayDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] Numbers = new int[3];

//            for (int i = 0; i < Numbers.Length; i++)
//            {
//                Numbers[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Accessing the Array elements using for loop");

//            for (int i = 0; i <= Numbers.Length - 1; i++)
//            {
//                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//            }

//            Console.WriteLine("Asccessing using foreach loop");

//            foreach (int num in Numbers)
//            {
//                Console.WriteLine($"{num}");
//            }
//        }
//    }
//}


//Add two matrices

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter rows and columns");
//        int Rows = Convert.ToInt32(Console.ReadLine());
//        int Columns = Convert.ToInt32(Console.ReadLine());

//        int[,] Matrix1 = new int[Rows, Columns];
//        int[,] Matrix2 = new int[Rows, Columns];

//        int[,] ResultMatrix = new int[Rows, Columns];
//        Console.WriteLine("Enter elements of 1st matrix");
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Columns; j++)
//            {
//                Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        Console.WriteLine("Enter elements for 2nd Matrix");
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Columns; j++)
//            {
//                Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        Console.WriteLine("\nSum of Both the Matrics:");
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Columns; j++)
//            {
//                ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
//                Console.Write($"{ResultMatrix[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//        Console.ReadKey();

//    }
//}




//class Program
//{
//    static void Main()
//    {

//        string str1 = "happy";
//        string str2 = new String("happy");

//        bool equal = (str1 == str2);
//        Console.WriteLine("Using '==': " + equal); 

//        equal = str1.Equals(str2);
//        Console.WriteLine("Using 'Equals()': " + equal); 
//    }
//}



//ArrayList

//using System;
//using System.Collections;
//namespace Csharp8Features
//{
//    public class ArrayListDemo
//    {
//        public static void Main()
//        {

//            ArrayList arrayList1 = new ArrayList();
//            arrayList1.Add(101); 
//            arrayList1.Add("James"); 
//            arrayList1.Add(true); 
//            arrayList1.Add(4.5); 


//            int firstElement = (int)arrayList1[0]; 
//            string secondElement = (string)arrayList1[1]; 

//            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");


//            var firsItem = arrayList1[0]; 
//            var secondItem = arrayList1[1]; 

//            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");


//            arrayList1[0] = "Smith";
//            arrayList1[1] = 1010;


//            foreach (var item in arrayList1)
//            {
//                Console.Write($"{item} ");
//            }
//            Console.ReadKey();
//        }
//    }
//}


//ArrayList-InsertRange

//using System.Collections;

//namespace list
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            ArrayList arrayList1 = new ArrayList()
//            {
//                "India",
//                "USA",
//                "UK",
//                "Nepal"
//            };

//            Console.WriteLine("Array List Elements Before Insertion");

//            foreach (var item in arrayList1)
//            {
//                Console.WriteLine($"{item} ");
//            }

//            ArrayList arrayList2 = new ArrayList()
//            {
//                "Sri Lanka",
//                "Japan",
//                "Britain"
//            };
//            arrayList1.InsertRange(0, arrayList2);

//            Console.WriteLine("Array List Elements after Insertion");

//            foreach(var item2 in arrayList1)
//            {
//                Console.WriteLine($"{item2} ");
//            }
//        }
//    }
//}



//ArrayList Copy


//namespace Csharp
//{
//    public class ArrayListDemo
//    {
//        public static void Main()
//        {
//            ArrayList arrayList = new ArrayList()
//            {
//                    "India",
//                    "USA",
//                    "UK",
//                    "Denmark",
//                    "HongKong",
//            };

//            Console.WriteLine("Array List Elements:");
//            foreach (var item in arrayList)
//            {
//                Console.WriteLine($"{item} ");
//            }

//            //Creating a clone of the arrayList using Clone method
//            ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
//            Console.WriteLine("\nCloned ArrayList Elements:");
//            foreach (var item in cloneArrayList)
//            {
//                Console.WriteLine($"{item} ");
//            }

//            Console.ReadKey();
//        }
//    }
//}


//Sorting

//using System.Collections;

//namespace sorting
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayList L = new ArrayList() { 5, 2, 1, 9, 6 };

//            Console.WriteLine("Elements before sorting");
//            foreach (int item in L)
//            {
//                Console.WriteLine($"{item} ");
//            }
//            //L.Sort();
//            //Console.WriteLine("Elements after sorting");
//            //foreach (int item in L)
//            //{
//            //    Console.WriteLine($"{item} ");
//            //}


//            IComparer descendingComparer = new DescendingComparer();
//            //L.Sort(descendingComparer);
//            //Console.WriteLine("Elements after sorting");
//            //foreach (int item in L)
//            //{
//            //    Console.WriteLine($"{item} ");
//            //}

//            L.Sort(0, 3, descendingComparer);
//            Console.WriteLine("Elements after sorting");
//            foreach (int item in L)
//            {
//                Console.WriteLine($"{item} ");
//            }
//        }

//    }

//    public class DescendingComparer : IComparer
//    {
//        public int Compare(Object x, Object y)
//        {
//            if (x is int intX && y is int intY)
//            {
//                if (intX > intY)
//                    return -1;
//                else if (intX < intY)
//                    return 1;
//                else
//                    return 0;
//            }
//            return 0;
//        }
//    }
//}


//Singleton Class

//public class Singleton
//{
//    private static Singleton instance;

//    private Singleton()
//    {
//        Console.WriteLine("Singleton instance created.");
//    }

//    public static Singleton GetInstance()
//    {
//        if (instance == null)
//        {
//            instance = new Singleton();
//        }
//        retrurn instance;
//    }
//    public void ShowMessage()
//    {
//        Console.WriteLine("Hello from Singleton!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Singleton singleton1 = Singleton.GetInstance();
//        singleton1.ShowMessage();
//    }
//}






//HashTables

//class HashTab
//{
//    static void Main(string[] args)
//    {
//        Hashtable ht = new Hashtable();
//        ht.Add(1, "One");
//        ht.Add(2, "Two");
//        ht.Add(3, "Three");

//        foreach (DictionaryEntry e in ht)
//        {
//            Console.WriteLine($"{e.Key} : {e.Value}");
//        }

//        Console.WriteLine("Is One Present : " + ht.ContainsKey(1));

//        Console.WriteLine("Is Two Present : " + ht.ContainsKey(2));

//        Console.WriteLine("Is Three Present : " + ht.ContainsValue("Three"));

//        DictionaryEntry[] myArray = new DictionaryEntry[ht.Count];

//        ht.CopyTo(myArray, 0);
//        Console.WriteLine("\nHashtable Copy Array Elements:");
//        foreach (DictionaryEntry item in myArray)
//        {
//            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//        }

//        Object[] myObjArrayKey = new Object[ht.Count];
//        Object[] myObjArrayValue = new Object[ht.Count];
//        Console.WriteLine("\nCopyTo Method to Copy Keys:");
//        ht.Keys.CopyTo(myObjArrayKey, 0);
//        foreach (var key in myObjArrayKey)
//        {
//            Console.WriteLine($"{key} ");
//        }

//        Console.WriteLine("\nCopyTo Method to Copy Values:");
//        ht.Values.CopyTo(myObjArrayValue, 0);
//        foreach (var value in myObjArrayValue)
//        {
//            Console.WriteLine($"{value} ");
//        }

//        Console.ReadKey();
//    }
//}




//SortedList

//class Program
//{
//    static void Main(string[] args)
//    {
//        SortedList sL = new SortedList();

//        sL.Add(3, "Three");
//        sL.Add(2, "Two");
//        sL.Add(1, "One");

//        Console.WriteLine("Sorted Elements (Keys in ascending order):");
//        foreach (DictionaryEntry e in sL)
//        {
//            Console.WriteLine($"{e.Key}: {e.Value}");
//        }

//        Console.WriteLine("\nValue for key 2: " + sL[2]);
//        Console.WriteLine("\nContains 3: " + sL.Contains(3));
//        Console.WriteLine("\nContains key 3: " + sL.ContainsKey(3));
//        Console.WriteLine("\nContains value 'Three': " + sL.ContainsValue("Three"));

//        sL.Remove(1);
//        Console.WriteLine("\nAfter Removing key 1:");
//        foreach (DictionaryEntry e in sL)
//        {
//            Console.WriteLine($"{e.Key}: {e.Value}");
//        }

//        sL.Add(4, "Four");
//        Console.WriteLine("\nAfter Adding key 4:");
//        foreach (DictionaryEntry e in sL)
//        {
//            Console.WriteLine($"{e.Key}: {e.Value}");
//        }

//        Console.WriteLine("\nNumber of elements in the SortedList: " + sL.Count);

//        int[] keysArray = new int[sL.Count];
//        object[] valuesArray = new object[sL.Count];

//        sL.Keys.CopyTo(keysArray, 0);
//        sL.Values.CopyTo(valuesArray, 0);

//        Console.WriteLine("\nKeys Array:");
//        foreach (var key in keysArray)
//        {
//            Console.WriteLine(key);
//        }

//        Console.WriteLine("\nValues Array:");
//        foreach (var value in valuesArray)
//        {
//            Console.WriteLine(value);
//        }
//    }
//}


//Sorting with custome interface

//namespace demo
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            List<Employee> l = new List<Employee>
//            {
//                new Employee() { ID = 101, Name = "Asher", Gender = "Male", Salary = 0},
//                new Employee() { ID = 102, Name = "Kartikey", Gender = "Male", Salary = 0},
//                new Employee() { ID = 103, Name = "Manas", Gender = "Male", Salary = 25000},
//                new Employee() { ID = 104, Name = "Pranav", Gender = "Male", Salary = 12000}
//            };

//            Console.WriteLine("Employees Before Sorting");
//            foreach (Employee e in l)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary={3}", e.ID, e.Name, e.Gender, e.Salary);
//            }
//            l.Sort();
//            Console.WriteLine("\nEmployees After Sorting");
//            foreach (Employee e in l)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary={3}", e.ID, e.Name, e.Gender, e.Salary);
//            }
//            Console.ReadKey();
//        }
//    }

//    public class Employee : IComparable<Employee>
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//        public int Salary { get; set; }
//        public int CompareTo(Employee obj)
//        {
//            if (this.Salary > obj.Salary)
//            {
//                return 1;
//            }
//            else if (this.Salary < obj.Salary)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//        }
//    
//}


//Multicast delegate

//namespace Dele
//{
//     delegate void calculator(int x, int y);

//    class Program
//    {

//        static void Add(int a, int b)
//        {
//            Console.WriteLine(a + b);
//        }
//        static void Mul(int a, int b)
//        {
//            Console.WriteLine(a * b);
//        }

//        static void Main(string[] args)
//        {
//            calculator calc = new calculator(Add);
//            calc += Mul;
//            calc(20, 30);
//        }

//    }
//}


//Concurrent Dictionary

//namespace ConcurrentCollections
//{
//    class Program
//    {
//        static ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Method1);
//            Thread t2 = new Thread(Method2);
//            t1.Start();
//            t2.Start();
//            t1.Join();
//            t2.Join();

//            foreach (KeyValuePair<int, string> item in dictionary)
//            {
//                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
//            }

//            Console.ReadKey();
//        }

//        public static void Method1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.TryAdd(i, "Added By Method1 " + i);
//                Thread.Sleep(100);
//            }
//        }

//        public static void Method2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.TryAdd(i, "Added By Method2 " + i);
//                Thread.Sleep(100);
//            }
//        }
//    }
//}



//MultiThreading




//class Program
//{
//    static void Main(string[] args)
//    {
//        Thread thread1 = new Thread(Worker1);
//        Thread thread2 = new Thread(Worker2);

//        thread1.Start();
//        thread2.Start();

//        thread1.Join();
//        thread2.Join();

//        Console.WriteLine("Main thread ends.");
//    }

//    static void Worker1()
//    {
//        Console.WriteLine("Thread 1 is working...");
//        Thread.Sleep(2000);
//        Console.WriteLine("Thread 1 ends.");
//    }

//    static void Worker2()
//    {
//        Console.WriteLine("Thread 2 is working...");
//        Thread.Sleep(3000);
//        Console.WriteLine("Thread 2 ends.");
//    }
//}




//LINQ
//class Linkyu
//{
//    static void Main()
//    {
//        string[] Language = { "C#", "VB", "Java", "C++", "C", "Perl", "Ruby", "Python" };

//        var result = from lang in Language
//                     where lang.Contains('C')
//                     select lang;

//        foreach (var l in result)
//        {
//            Console.WriteLine(l);
//        }
//    }
//}


//class Linkyu
//{
//    static void Main(string[] args)
//    {
//        List<string> my_list = new List<string>()
//        {
//            "This is my laptop",
//            "This is my phone",
//            "This is my mouse",
//            "This is my dog"
//        };

//        var res = from L in my_list
//                  where L.Contains("my")
//                  select L;

//        foreach(var r in res)
//        {
//            Console.WriteLine(r);
//        }
//    }
//}


//class Linkyu
//{
//    static void Main(string[] args)
//    {
//        int[] age = { 12, 23, 21, 22, 45, 33, 20, 26, 55, 66 };
//        var a = from i in age where i > 20 select i;

//        foreach (int item in a)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



//Method Syntax
//class liunkyu
//{
//    static void Main()
//    {
//        List<string> my_list = new List<string>()
//        {
//            "This is John Cena",
//            "My name is John Cena",
//            "This is my hood"
//        };
//        var res = my_list.Where(a => a.Contains("This"));

//        foreach (var q in res)
//        {
//            Console.WriteLine(q);
//        }
//    }
//}


//LINQ to sort a list

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> li = new List<int> { 10, 2, 5, 4, 8 };
//        var sorted = from n in li
//                     orderby n ascending
//                     select n;

//        foreach (var re in sorted)
//        {
//            Console.WriteLine(re);
//        }
//    }
//}


//Select 

//class Program
//{
//    static void Main(string[] args)
//    {
//        var li = new List<int> { 2, 5, 1, 8 };
//        var res = li.Select(n => n * 2).ToList();

//        Console.WriteLine(string.Join(", ", res));
//    }
//}


//Threads
//public class Program
//{
//    public static void PrintNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(1000);
//        }
//    }
//    public static void Main()
//    {
//        Thread thread = new Thread(PrintNumbers);
//        thread.Start();
//        Console.WriteLine("Main thread is running");
//        thread.Join();
//        Console.WriteLine("Thread execution finished");
//    }
//}


//Threading

//class threadd
//{
//    static void Main(string[] args)
//    {
//        Thread thread = new Thread(PrintNumbers);
//        thread.Start();

//        Console.WriteLine("Main Thread is Running");
//    }

//    static void PrintNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(1000);
//        }
//    }
//}



//ThreadPool
//class Program
//{
//    static void Main()
//    {
//        ThreadPool.QueueUserWorkItem(PrintNumbers);
//        Thread.Sleep(6000);
//        Console.WriteLine("Main thread running");
//    }

//    static void PrintNumbers(object state)
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(1000);
//        }
//    }
//}


//Monitor Class

//class Program
//{
//    static readonly object lockObject = new object();

//    static void Main()
//    {
//        Thread thread1 = new Thread(DoWork);
//        Thread thread2 = new Thread(DoWork);

//        thread1.Start();
//        thread2.Start();

//        thread1.Join();
//        thread2.Join();
//    }

//    static void DoWork()
//    {
//        Monitor.Enter(lockObject);
//        try
//        {
//            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is working.");
//            Thread.Sleep(1000);
//        }
//        finally
//        {
//            // Ensure the lock is released when the thread is done
//            Monitor.Exit(lockObject);
//        }
//    }
//}


//Single process mutex

//class mute
//{
//    static Mutex mutex = new Mutex();
//    static void Main(string[] args)
//    {
//        Thread thread1 = new Thread(DoWork);
//        Thread thread2 = new Thread(DoWork);

//        thread1.Start();
//        thread2.Start();

//        thread1.Join();
//        thread2.Join();

//    }
//    static void DoWork()
//    {
//        mutex.WaitOne();
//        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is working.");
//        Thread.Sleep(1000);

//        mutex.ReleaseMutex();
//    }
//}


//Global Exception

//class Program
//{
//    static void Main()
//    {
//        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
//        throw new Exception("This is a global exception");
//    }
//    // Global exception handler
//    static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
//    {
//        Console.WriteLine("Global Exception Handled!");
//        Exception exception = (Exception)e.ExceptionObject;
//        Console.WriteLine($"Exception Message: {exception.Message}");
//    }
//}


//TPL

//class Program
//{
//    static void Main(string[] args)
//    {
//        Parallel.For(0, 1000, x => Ra nkIterations());
//        Console.Read();
//    }
//    private static void RankIterations()
//    {
//        StringBuilder sb = new StringBuilder();  
//        for (int i = 0; i < 1000; i++)
//        {
//            sb.Append("s");
//        }
//        Console.WriteLine(sb.ToString().Length);
//    }
//}


//Event

//using System;

//namespace EventDemo
//{
//    class EmployeeSeperator
//    {
//        public delegate void EmployeeSeperatedEventHandler();             // Delegate
//        public event EmployeeSeperatedEventHandler EmployeeSeperated;     // Event

//        public void Seperate()
//        {
//            // Publishing event
//            EmployeeSeperated?.Invoke();
//        }
//    }

//    class Finance
//    {
//        private readonly EmployeeSeperator employeeSeperator;

//        public Finance(EmployeeSeperator employeeSeperator)
//        {
//            this.employeeSeperator = employeeSeperator;
//            // Subscribing to the event
//            employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;
//        }

//        // Event handler
//        public void EmployeeSeperatedEventHandler()
//        {
//            Console.WriteLine("Finance department: employee separation process related to finance");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating instance of EmployeeSeperator
//            EmployeeSeperator employeeSeperator = new EmployeeSeperator();

//            // Creating instance of Finance and passing EmployeeSeperator to it
//            Finance finance = new Finance(employeeSeperator);

//            // Triggering the event by calling Seperate method
//            employeeSeperator.Seperate(); // This will invoke the event and call the event handler
//        }
//    }
//}



//Simple Paging
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> data = Enumerable.Range(1, 100).ToList();

//        int pageSize = 10;
//        int pageIndex = 2;

//        var pageData = data.Skip(pageIndex * pageSize).Take(pageSize).ToList();

//        Console.WriteLine($"Page {pageIndex + 1}:");
//        foreach (var item in pageData)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}


//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        // Call an asynchronous method and await its result
//        await PerformAsyncOperation();
//        Console.WriteLine("Main method finished.");
//    }

//    // Asynchronous method
//    static async Task PerformAsyncOperation()
//    {
//        Console.WriteLine("Operation started.");

//        // Simulating an async operation (e.g., I/O-bound)
//        await Task.Delay(3000);  // Wait for 3 seconds

//        Console.WriteLine("Operation completed.");
//    }
//}


//delegate
//class prog
//{
//    delegate void calculator(int x, int y);
//    public static void add(int a, int b)
//    {
//       Console.WriteLine(a+b);
//    }
//    public static void mul(int c, int d)
//    {
//        Console.WriteLine(c*d);
//    }
//    public static void Main(string[] args)
//    {
//        calculator calc = new calculator(add);
//        calc(10, 20);

//    }
//}


//Anonymous Delegate
//delegate void calculator(int a, int b);
//class program
//{
//    static void Main(string[] args)
//    {
//        calculator add = delegate (int a, int b)
//        {
//            Console.WriteLine(a + b);
//        };
//        add(10, 20);
//    }
//}


















































//Property and field
//public class Person
//{
//    //private field
//    private string _name;

//   //property
//   public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }

//    public int Age { get; set; }

//   public Person(string name, int age)
//   {
//        Name = name;
//        Age = age;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Name:{Name}, Age: {Age}");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Person person = new Person("Alice", 25);
//        person.DisplayInfo();
//    }
//}


//Partial Class

//namespace half
//{
//    public partial class Person
//    {
//        private string _name;

//        public string name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//    }

//    public partial class Person
//    {
//        public void display()
//        {
//            Console.WriteLine($"Name : {name}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Person person = new Person();
//            person.name = "Alice";
//            person.display();
//        }
//    }
//}


//Public Partial method 
//implemented

//namespace partialmetho
//{
//    public partial class Metho
//    {
//        partial void DisplayMessage();
//        public void Show()
//        {
//            DisplayMessage();
//        }
//    }

//    public partial class Metho
//    {
//        partial void DisplayMessage()
//        {
//            Console.WriteLine("HAHAHAHAHA");
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Metho ob = new Metho();
//        ob.Show();
//    }
//}


//Default constructor

//namespace defa
//{
//    class cons
//    {
//        public string name;
//        public int age;

//        public cons()
//        {
//            name = "Arya";
//            age = 22;
//        }
//        public void display()
//        {
//            Console.WriteLine($"Name:{name} and Age:{age}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            cons cal = new cons();
//            cal.display();
//        }
//    }
//}


//Parameterized constructor
//namespace param
//{
//    class Person
//    {
//        public string Name;
//        public int Age;

//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Name: {Name}, Age: {Age}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Using the parameterized constructor
//            Person person = new Person("Alice", 25);
//            person.DisplayInfo();
//        }
//    }
//}



//Copy Constructor
//using System;

//class Person
//{
//    public string Name;
//    public int Age;

//    // Default constructor
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    // Copy constructor
//    public Person(Person otherPerson)
//    {
//        Name = otherPerson.Name;
//        Age = otherPerson.Age;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person1 = new Person("Alice", 25);
//        person1.DisplayInfo(); // Output: Name: Alice, Age: 25

//        // Creating a new object using the copy constructor
//        Person person2 = new Person(person1);
//        person2.DisplayInfo(); // Output: Name: Alice, Age: 25
//    }
//}


//shallow copy
//namespace shallow
//{
//    public class Person
//    {
//        public string Name;
//        public int[] Scores;

//        public Person(string name, int[] scores)
//        {
//            Name = name;
//            Scores = scores;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            int[] scores1 = { 90, 85, 88 };
//            Person person1 = new Person("Alice", scores1);
//            Person person2 = new Person(person1.Name, person1.Scores);
//            person2.Scores[0] = 100;

//            Console.WriteLine(person1.Scores[0]);
//        }
//    }
//}


//Deep Copy

//namespace deep
//{
//    public class Person
//    {
//        public string Name;
//        public int[] Scores;

//        public Person(string name, int[] scores)
//        {
//            Name = name;
//            // Deep copy of the Scores array
//            Scores = (int[])scores.Clone();
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            int[] scores1 = { 90, 85, 88 };
//            Person person1 = new Person("Alice", scores1);
//            Person person2 = new Person(person1.Name, person1.Scores);

//            person2.Scores[0] = 100;

//            Console.WriteLine(person1.Scores[0]);  
//        }
//    }
//}


//Deep copy for refernce type



//public class Person
//{
//    public string Name;
//    public int Age;

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public Person DeepCopy()
//    {
//        return new Person(this.Name, this.Age);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person[] originalArray =
//        {
//            new Person("Alice", 30),
//            new Person("Bob", 25)
//        };

//        Person[] deepCopy = originalArray.Select(person => person.DeepCopy()).ToArray();

//        deepCopy[0].Name = "Changed Name";

//        Console.WriteLine(originalArray[0].Name);  
//        Console.WriteLine(deepCopy[0].Name);       
//    }
//}




//Static constructor
//class MyClass
//{
//    static int count;

//    // Static constructor
//    static MyClass()
//    {
//        count = 10;
//        Console.WriteLine("Static constructor called.");
//    }

//    // Instance constructor
//    public MyClass()
//    {
//        Console.WriteLine("Instance constructor called.");
//    }

//    public static void ShowCount()
//    {
//        Console.WriteLine(count);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Static constructor is called before accessing any static members
//        MyClass.ShowCount();

//        // Instance constructor is called when an object is created
//        MyClass obj = new MyClass();
//    }
//}


//Primary Constructor

//namespace any
//{
//    public class Person(String name, int age)
//    {
//        public string Name { get; } = name;
//        public int Age { get; }=Age;
//        public void Introduce()
//        {
//            Console.WriteLine($"Hello, my name is {Name} and I am {Age} year old");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person("Arya", 22);
//            person.Introduce();
//        }
//    }
//}


//Extension methods

//using System;

//namespace Ext
//{
//    public static class ex
//    {
//        public static string RightSubstring(this string s, int len)
//        {
//            if (s == null || len <= 0)
//            {
//                return null;
//            }

//            return s.Length <= len ? s : s.Substring(s.Length - len);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string inp = "Hello, World!";
//            string res = inp.RightSubstring(6);
//            Console.WriteLine(res);
//        }
//    }
//}



//IEnumerable

//class program
//{
//    static void Main(string[] args)
//    {
//        List<int> l = new List<int> { 2, 5, 1, 4, 6, 7 };

//        IEnumerable<int> res = l.Where(n => n % 2 == 0);

//        foreach(var ans in res)
//        {
//            Console.WriteLine(ans);
//        }
//    }
//}


//IQueryable
//class program
//{
//    static void Main(string[] args)
//    {
//        List<int> l = new List<int> { 2, 4, 1, 7, 9 };
//        IQueryable<int> ans = l.AsQueryable().Where(n => n % 2 == 0);

//        foreach (var re in ans)
//        {
//            Console.WriteLine(re);
//        }
//    }
//}


//Try Catch-throwex

//namespace tc
//{
//    class prog
//    {
//        public static void DivideZerobyZero()
//        {
//            try
//            {
//                int i = 0;
//                int j = 0;
//                int k = i / j;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }

//    class imp
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                prog.DivideZerobyZero();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.StackTrace);
//                Console.ReadLine();
//            }
//        }
//    }
//}



//trycatch throw
//namespace tc
//{
//    class prog
//    {
//        public static void DivideZerobyZero()
//        {
//            try
//            {
//                int i = 0;
//                int j = 0;
//                int k = i / j;
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }

//    class imp
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                prog.DivideZerobyZero();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.StackTrace);
//                Console.ReadLine();
//            }
//        }
//    }
//}



//call  by value

//class Program
//{
//    public static int update(int m, int n)
//    {
//        return m + n;
//    }
//    static void Main()
//    {
//        int a = 10;
//        int b = 5;
//        int res = update(a, b);
//        Console.WriteLine(res);
//    }
//}


//call by reference

//class referral
//{
//    public static int update(out int a, ref int b)
//    {
//        a = 100;
//        return a + b;
//    }
//    static void Main(string[] args)
//    {
//        int c;
//        int d = 200;
//        int res = update(out c, ref d);
//        Console.WriteLine(res);
//    }
//}


//params
//class param
//{
//    static void Main(string[] args)
//    {
//        int sum=add(2, 3, 5, 1, 2);
//        Console.WriteLine(sum);
//    }
//    static int add(params int[] nums)
//    {
//        int total=0;
//        foreach(int i in nums)
//        {
//            total += i;
//        }
//        return total;
//    }
//}


//Generic method

//public class genmetho
//{
//    static bool isequal<T>(T value1, T value2)
//    {
//        return value1.Equals(value2);
//    }
//    static void Main(string[] args)
//    {
//        bool res1, res2;
//        res1 = isequal<string>("arya", "arya");
//        res2 = isequal<int>(2, 3);

//        Console.WriteLine(res1);
//        Console.WriteLine(res2);
//    }
//}


//Generic class


//public class calculate<T>
//{
//    public static bool isequal(T value1, T value2)
//    {
//        return value1.Equals(value2);
//    }

//    public static void Main(string[] args)
//    {
//        bool res1, res2;
//        res1 = calculate<string>.isequal("arya", "arya");
//        res2 = calculate<int>.isequal(2, 3);

//        Console.WriteLine(res1);
//        Console.WriteLine(res2);
//    }
//}



//Yield Keyword

//class Program
//{
//    public static IEnumerable<int> GetNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            yield return i;  
//        }
//    }

//    static void Main()
//    {
//        foreach (int number in GetNumbers())
//        {
//            Console.WriteLine(number); 
//        }
//    }
//}


//async and await

//class Program
//{
//    static void Main(string[] args)
//    {
//        Method();
//        Console.WriteLine("Main Thread");
//        Console.ReadLine();
//    }
//    public static async void Method()
//    {
//        await Task.Run(new Action(LongTask));
//        Console.WriteLine("New Thread");
//    }
//    public static void LongTask()
//    {
//        Thread.Sleep(20000);
//    }
//}



//async and await

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        Console.WriteLine("Before async operation");

//        await SimpleAsyncMethod();

//        Console.WriteLine("After async operation");
//    }

//    static async Task SimpleAsyncMethod()
//    {
//        await Task.Delay(2000);  
//        Console.WriteLine("Async operation completed!");
//    }
//}



//IENUMERABLE
//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 2, 4, 6, 7 };
//        IEnumerable<int> enumerable = numbers;
//        IEnumerator<int> enumerator = enumerable.GetEnumerator();
//        while (enumerator.MoveNext())
//        {
//            Console.WriteLine(enumerator.Current);
//        }
//    }
//}


//IQueryable
//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 2, 4, 3, 6, 7, 8 };
//        IQueryable<int> queryable = numbers.AsQueryable();
//        IQueryable<int> filterednum = queryable.Where(n => n % 2 == 0);
//        IEnumerator<int> enumerator = filterednum.GetEnumerator();
//        while (enumerator.MoveNext())
//        {
//            Console.WriteLine(enumerator.Current);
//        }
//    }
//}




//yield keyword

//class withoutyield
//{
//    static IEnumerable<int> GetEvenNumbers(int upto)
//    {
//        List<int> numbers = new List<int>();
//        for (int i = 0; i <= upto; i += 2)
//        {
//            numbers.Add(i);
//            Console.WriteLine("Print");
//        }
//        return numbers;
//    }

//    static void Main(string[] args)
//    {
//        IEnumerable<int> getEvenNumbers = GetEvenNumbers(10);

//        foreach (int evenNumber in getEvenNumbers)
//        {
//            Console.WriteLine(evenNumber);
//        }
//    }

//}




//class withyield
//{
//    static IEnumerable<int> GetEvenNumbers(int upto)
//    {
//        for (int i = 0; i <= upto; i += 2)
//        {
//            yield return i;
//            Console.WriteLine("Print");
//        }
//    }

//    static void Main(string[] args)
//    {
//        IEnumerable<int> getEvenNumbers = GetEvenNumbers(10);

//        foreach (int evenNumber in getEvenNumbers)
//        {
//            Console.WriteLine(evenNumber);
//        }
//    }
//}

//class withyield
//{
//    static IEnumerable<int> GetEvenNumbers(int upto)
//    {
//        for (int i = 0; i <= upto; i += 2)
//        {
//            yield return i;
//            yield return i+1;
//            Console.WriteLine("Print");
//        }
//    }

//    static void Main(string[] args)
//    {
//        IEnumerable<int> getEvenNumbers = GetEvenNumbers(10);

//        foreach (int evenNumber in getEvenNumbers)
//        {
//            Console.WriteLine(evenNumber);
//        }
//    }

//}



//Custom Exception

//namespace cexception
//{
//    public class InvalidAgeException : Exception
//    {
//        public InvalidAgeException() : base("Invalid age provided") { }

//        public InvalidAgeException(string message) : base(message) { }

//        public InvalidAgeException(string message, Exception innerException) : base(message, innerException) { }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            try
//            {
//                int age = -5;
//                if (age < 0)
//                {
//                    //throw new InvalidAgeException();  //First Constructor
//                    //throw new InvalidAgeException("Age cannot be negative.");  //Second Constructor
//                    throw new InvalidAgeException("Age cannot be negative.", new Exception("Inner exception details"));  //Third Constructor
//        
//            }
//            catch (InvalidAgeException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");

//                if (ex.InnerException != null)
//                {
//                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
//                }
//            }
//        }
//    }
//}


//Inner Exception

//class Program
//{
//    static void ProcessData()
//    {
//        try
//        {
//            throw new InvalidOperationException("An error occured in processing.");
//        }
//        catch (InvalidOperationException ex)
//        {
//            //Throw a new exception and wrap the original exception as an inner exception
//            throw new ApplicationException("An application error occure.", ex);
//        }
//    }

//    static void Main()
//    {
//        try
//        {
//            ProcessData();
//        }

//        catch (ApplicationException ex)
//        {
//            Console.WriteLine($"outer Exception: {ex.Message}");
//            if (ex.InnerException != null)
//            {
//                Console.WriteLine($"inner Exception: {ex.InnerException.Message}");
//            }
//        }
//    }
//}




//Custom Collection

//namespace cuscol
//{
//    public class MyCustomCollection<T> : IEnumerable<T>
//    {
//        private List<T> items = new List<T>();

//        //Adding item to the collection
//        public void Add(T item)
//        {
//            items.Add(item);
//        }

//        //Removing item

//        public bool Remove(T item)
//        {
//            return items.Remove(item);
//        }

//        //Counting items
//        public int count => items.Count;

//        //Accessing item
//        public T this[int index]
//        {
//            get => items[index];
//            set => items[index] = value;
//        }

//        //Implementing IEnumerable interface
//        public IEnumerator<T> GetEnumerator()
//        {
//            return items.GetEnumerator();
//        }
//        //implementing non-generic version of GetEnumerator
//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            var collection = new MyCustomCollection<string>();
//            collection.Add("Hello");
//            collection.Add("Custom");
//            collection.Add("Collection");

//            Console.WriteLine("Items in the collection:");
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }
//            collection.Remove("Custom");
//            Console.WriteLine("\nItems after removal:");
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}




