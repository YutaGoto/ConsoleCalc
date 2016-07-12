using System;
using System.Collections.Generic;

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
		public List<Rule> rule = new List<Rule>();

		public List AddRule(Rule r)
		{
			rule.Add(r);
		}

		public void Run(int start, int stop)
		{
			for (i = start; int <= stop; int++)
			{
				string msg = "";
				rule.ForEach
				{
					bool result = 
				}
			}
		}
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
