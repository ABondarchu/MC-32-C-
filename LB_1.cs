using System;
				
public class MyClassA
{
	int a = 2;
	int b = 4;
	
	public int C0
	{
		get { a *= b; return a; }
	}
	
	
	
	public int C1
	{
		get { return a+b; }
	}
	
}


public class Program
{
	public static void Main()
	{
		MyClassA MyObject = new MyClassA();
		Console.WriteLine(string.Format("C0 result: {0}\nC1 result: {1}\n", 
										MyObject.C0, MyObject.C1));
	}
}
