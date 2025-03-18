using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




//STRINGBUILDER


//Reverse string
//namespace Practice
//{
//    class Practice
//    {
//        static void Main(string[] args)
//        {
//            string input = "CSharp";
//            StringBuilder sb = new StringBuilder(input);
//            char[] charArray = sb.ToString().ToCharArray();
//            Array.Reverse(charArray);
//            string ssb = new String(charArray);
//            Console.WriteLine("Reversed String: " + ssb);
//        }
//    }
//}



//Performance comparison
//class Program
//{
//    static void Main()
//    {
//        int numIterations = 10000;
//        string text = "Item";

//        Stopwatch sw = Stopwatch.StartNew();
//        StringBuilder sb = new StringBuilder();
//        for (int i = 1; i <= numIterations; i++)
//        {
//            sb.Append(text).Append(i);
//        }
//        sw.Stop();
//        Console.WriteLine($"StringBuilder took: {sw.ElapsedMilliseconds}ms");

//        sw.Restart();
//        string result = "";
//        for (int i = 1; i <= numIterations; i++)
//        {
//            result += text + i;
//        }
//        sw.Stop();
//        Console.WriteLine($"String Concatenation took: {sw.ElapsedMilliseconds} ms");
//    }
//}



//Reverse a Sentence
//class Program
//{
//    static void Main()
//    {
//        string s = "The quick brown fox jumps over a lazy dog";
//        string[] str = s.Split(' ');
//        Array.Reverse(str);
//        StringBuilder sb = new StringBuilder();
//        foreach(var st in str)
//        {
//            sb.Append(st).Append(' ');
//        }
//        Console.WriteLine($"Reversed sentence: {sb.ToString()}");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < 10; i++)
//        {
//            sb.Append("abc");
//        }

//        Console.WriteLine(sb);
//    }
//}





//LINQ
//class Program
//{
//    class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }
//    static void Main()
//    {
//        List<Person> ppl = new List<Person>()
//    {
//        new Person{Name="Arya", Age=22},
//        new Person{Name="Asher", Age=21},
//        new Person{Name="Manas", Age=22},
//        new Person{Name="Pranav", Age=23},
//        new Person{Name="Kartikey", Age=22},
//        new Person{Name="Satvik", Age=21}
//    };

//        //Query Syntax
//        Console.WriteLine("Using Query Syntax");
//        var res = from individual in ppl
//                  where individual.Age > 21
//                  orderby individual.Age descending
//                  select new { individual.Name, individual.Age };

//        foreach (var data in res)
//        {
//            Console.WriteLine($"{data.Name}, {data.Age}");
//        }

//        //Method Syntax
//        Console.WriteLine("Using Method Syntax");
//        var filteredppl = ppl.Where(Person => Person.Age > 21).OrderByDescending(Person=>Person.Age).Select(Person => new { Person.Name, Person.Age });

//        foreach (var data in res)
//        {
//            Console.WriteLine($"{data.Name}, {data.Age}");
//        }
//    }
//}


//Exception Handling
//using System;  // 1

//class Program   // 2
//{              // 3
//    static void Main()   // 4
//    {          // 5
//        try    // 6
//        {      // 7

//            int number = 10;   // 8
//            int divisor = 0;   // 9


//            int result = number / divisor;   // 10
//        }      // 11
//        catch (DivideByZeroException ex)  // 12
//        {                                      // 13
//            Console.WriteLine("Caught DivideByZeroException");  // 14
//            Console.WriteLine("Exception Message: " + ex.Message);  // 15
//            Console.WriteLine("Stack Trace before rethrowing:\n" + ex.StackTrace);  // 16


//            Console.WriteLine("\nRe-throwing using 'throw;'");   // 17
//            try                                          // 18
//            {                                          // 19
//                throw;   // 20 This rethrows the exception preserving the original stack trace
//            }                                          // 21
//            catch (Exception rethrownEx)                // 22
//            {                                          // 23
//                Console.WriteLine("Stack Trace after rethrowing with 'throw;':\n" + rethrownEx.StackTrace);  // 24
//            }                                          // 25


//            Console.WriteLine("\nRe-throwing using 'throw ex;'");   // 26
//            try                                          // 27
//            {                                          // 28
//                throw ex;   // 29 This rethrows the exception but loses the stack trace
//            }                                          // 30
//            catch (Exception rethrownEx)                // 31
//            {                                          // 32
//                Console.WriteLine("Stack Trace after rethrowing with 'throw ex;':\n" + rethrownEx.StackTrace);  // 33
//            }                                          // 34
//        }                                              // 35
//    }                                                  // 36
//}                                                      // 37



//class Program
//{
//    static async Task Main(string[] args)
//    {
//        // Call an asynchronous method and await its result
//        Console.WriteLine("Main method started");
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


//class Program
//{
//    public delegate void PrintMessage();
//    static void Main()
//    {
//        PrintMessage messageDelegate = PrintHelloWorld;
//        CallDelegate(messageDelegate);
//    }
//    static void CallDelegate(PrintMessage message)
//    {
//        message();
//    }
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


//Inbuilt Delegates
//class Program
//{
//    static void Main(string[] args)
//    {
//        Func<int, int, int> add = (a, b) => a + b;
//        Console.WriteLine("Result: " + add(3, 4));
//        Action<string> message = (msg) => Console.WriteLine(msg);
//        message("Achhaa Okay Samajh Gaya");
//        Predicate<int> res = IsEven;

//        int number = 4;
//        bool ans = res(4);
//        Console.WriteLine($"{number} is even : {ans}");
//    }
//    static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }
//}




//StringBuilder Practice 
//class rev
//{
//    public static void Main(string[] args)
//    {
//        String str = "Arya";
//        char[] arr = str.ToCharArray();
//        Array.Reverse(arr);
//        Console.WriteLine(new string(arr));
//    }
//}


//class interes
//{
//    public static void Main(string[] args)
//    {
//        int count = 0;
//        string str = "1211";
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < str.Length; i++)
//        {
//            for (int j = i + 1; j < str.Length; j++)
//            {
//                if (str[i] == str[j])
//                {
//                    count++;
//                }
//                else
//                {
//                    count = 1;
//                    sb.Append(count).Append(str[i]);

//                }
//            }
//        }
//        Console.WriteLine(sb.ToString());
//    }
//}



//Longest Common Prefix
//class pref
//{
//    public static void Main(string[] args)
//    {
//        string[] strs = {"Dog", "Doggy", "Dogesh", "Doghouse"};
//        StringBuilder sb = new StringBuilder();
//        string First = strs[0];

//        for (int i = 0; i < First.Length; i++)
//        {
//            foreach (string str in strs)
//            {
//                if (str.Length <= i || str[i]!= First[i])
//                {
//                    Console.WriteLine(sb.ToString());
//                }
//            }
//            sb.Append(First[i]);
//        }
//        Console.WriteLine(sb.ToString());
//    }
//}




//delegates
//public delegate int AddDelegate(int a, int b);
//class emp
//{
//    public static void Main(string[] args)
//    {
//        AddDelegate add = (a, b) => (a + b);
//        int result = add(5, 10);
//        Console.WriteLine(result);

//    }
//}
