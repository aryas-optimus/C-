using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

//Basic Structure of C# Program


//namespace declaration
//namespace training
//{
//    //class declaration
//    class Program
//    {
//        //Data Members
//        int Member1;
//        float Member2;

//        //Functions/Methods/Blocks
//        static void Main(string[] args)
//        {
//            //Function Body
//            Console.WriteLine("Hello World");
//        }
//    }
//}


//Write methods

//namespace training
//{
//    class Program
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Hello");
//            Console.Write("Hi");
//            Console.Write("Bye");
//            Console.WriteLine("WELCOME");
//            Console.Write("C#.NET");
//        }
//    }
//}


//Printing the value of a variable

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			string name = "ABC";
//			Console.WriteLine(name);
//			Console.WriteLine("Hello " + name);
//			Console.WriteLine($"Hello {name}");
//		}
//	}
//}




//Reading value at run time

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Enter your name");
//			String name = Console.ReadLine();
//			Console.WriteLine($"Hello {name}");
//		}
//	}
//}


//////DOUBT--------1

//Reading Integer Value

//namespace Training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Enter two numbers");
//			int num1 = Convert.ToInt32(Console.ReadLine());
//			int num2 = Convert.ToInt32(Console.ReadLine());

//			Console.WriteLine("Numbers are " + num1 + " and " + num2);
//			Console.WriteLine($"Addition is {num1 + num2}");

//		}
//	}
//}


//ReadKey and Read

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Enter a Key");
//			int var1 = Console.Read();
//			Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");

//			Console.WriteLine("Enter Another Key");
//			ConsoleKeyInfo var2 = Console.ReadKey();
//			Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar: {var2.KeyChar} ASCII:{(int)var2.KeyChar}");
//		}
//	}
//}



////////Doubt-2
//Console class properties and beep method

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.BackgroundColor = ConsoleColor.Blue;
//			Console.ForegroundColor = ConsoleColor.White;
//			Console.WriteLine("Title: Understanding Console Class");
//			Console.Title = "Understanding Console Properties";
//			Console.WriteLine("BackgroundColor: Blue");
//			Console.WriteLine("ForegroundColor: White");
//			Console.CursorSize = 50;

//			Console.Beep();
//		}
//	}
//}

//class TestClass
//{
//	static void Main(string[] args)
//	{
//		Console.WriteLine(args.Length);
//	}
//}


//manual octal representation

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int octalValue = Convert.ToInt32("075", 8);
//			Console.WriteLine(octalValue);
//		}
//	}
//}


//Escape sequences

//namespace training
//{
//	class program
//	{
//		static void Main(string[] args)
//		{
//			string ff = "First page content\fSecond page content";
//			Console.WriteLine(ff);
//			string cr = "First page content\rSecond page content";
//			Console.WriteLine(cr);
//		}
//	}
//}


//Implicit type casting

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int num = 100;
//			Type numType = num.GetType();

//			double n = num;
//			Type nType = n.GetType();

//			Console.WriteLine($"Int value:{num}");
//			Console.WriteLine($"Int type:{numType}");
//			Console.WriteLine($"Int size:{sizeof(int)} Bytes");

//			Console.WriteLine($"Double value:{n}");
//			Console.WriteLine($"Double type:{nType}");
//			Console.WriteLine($"Double size:{sizeof(double)} Bytes");
//		}
//	}
//}


//different data type casting using function

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			string str = "Hello";
//			int i1 = Convert.ToInt32(str); 

//			Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");

//			Console.ReadKey();
//		}
//	}
//}

//conversion of a bigger data type into smaller one

//namespace training
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			short a = 300;
//			byte b = (byte) a;
//			Console.WriteLine(b);

//		}
//	}
//}



//Static and non-static variable initialization using class constructor

//namespace training
//{
//	class Program
//	{
//		static int x = 100;
//		int y;

//		public Program(int a)
//		{
//			x = a;
//			y = a;
//		}

//		static void Main(string[] args)
//		{
//			Console.WriteLine($"x's value: {x}");

//			Program P = new Program(200);

//			Console.WriteLine($"x's value: {x}");
//			Console.WriteLine($"y's value: {P.y}");


//			Program PP = new Program(300);

//			Console.WriteLine($"x's value: {x}");
//			Console.WriteLine($"y's value: {PP.y}");
//		}
//	}
//}



//Control flow
//namespace controlflow
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			if (5 > 1)
//			{
//				Console.WriteLine("Executing S1");
//				Console.WriteLine("Executing S2");
//			}
//			else
//			{
//				Console.WriteLine("Executing S3");
//				Console.WriteLine("Executing S4");
//			}

//			Console.WriteLine("Executing");
//			Console.ReadKey();
//		}
//	}
//}


//Loop
//namespace loop
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			for (int i = 0; i < 5; i++)
//			{
//				Console.WriteLine("Happy Happy Happy!");
//			}
//			Console.WriteLine("Music");
//			Console.ReadKey();
//		}
//	}
//}


//goto statement

//class Program
//{
//	static void Main(string[] args)
//	{
//		Console.WriteLine("Music");
//		goto statement1;
//		Console.WriteLine("Silent1");
//		Console.WriteLine("Silent2");
//	statement1:
//		Console.WriteLine("Happy");
//		Console.WriteLine("Happy2");

//	}
//}

//Ladder If-Else

//class Program
//{
//	static void Main(string[] args)
//		{
//		Console.WriteLine("Enter a number");
//		int i = Convert.ToInt32(Console.ReadLine());
//		if (i == 10)
//		{
//			Console.WriteLine("i is 10");
//		}
//		else if (i == 15)
//		{
//			Console.WriteLine("i is 15");
//		}
//		else if (i == 20)
//		{
//			Console.WriteLine("i is 20");
//		}
//		else
//		{
//			Console.WriteLine("i is not present");
//		}

//		Console.ReadKey();
//		}
//}

//Functions

//class Program
//{
//	static void Main(string[] args)
//	{
//		int x, y;
//		x = 10;
//		y = 15;
//		int sum = Add(x, y);
//		Console.WriteLine($"Sum is {sum}");
//		Console.ReadKey();
//	}

//	static int Add(int a, int b)
//	{
//		int sum = a + b;
//		return sum;
//	}
//}


//Function Overloading-Representation of ambiguity
//class Program
//{
//	static void Main(string[] args)
//	{
//		int a = 10, b = 2, c, d;
//		c = add(a, b);
//		Console.WriteLine($"Sum of {a} and {b} is {c}");
//		d = add(a, b, c);
//		Console.WriteLine($"Sum of {a} and {b} and {c} is {d}");
//		Console.WriteLine($"Sum of {a} and {b} is {add(a, b)}");
//		Console.ReadKey();
//	}
//	static int add(int x, int y)
//	{
//		return x + y;
//	}
//	static int add(int x, int y, int z)
//	{
//		return x + y + z;
//	}
//	static int add(int x, int y)
//	{
//		return x + y;
//	}
//}

