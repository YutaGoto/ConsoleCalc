using System;

namespace ConsoleCalc
{
	public class Rule
	{
		public int number;
		public string message;

		public void Init(int num, string msg)
		{
			number = num;
			message = msg;
		}

		public bool Match(int i)
		{
			if (i % number == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	public class Application
	{
		public Rule[] rule = new Rule[];
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine("press any key");
			Console.ReadKey();
		}
	}
}
