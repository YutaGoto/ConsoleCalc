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

		public List<Rule> AddRule(Rule r)
		{
            return rule.Add(r);
		}

		public void Run(int start, int stop)
		{
            string msg = "";
            for (int i = start; i <= stop; i++)
			{
                foreach (Rule r in rule)
                {
                    bool result = r.Match(i);
                    if (result)
                    {
                        msg += "*";
                    }
                    else
                    {
                        msg = msg + i;
                    }
                }
			}
            Console.WriteLine(msg);
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
            Rule rule1 = new Rule();
            Rule rule2 = new Rule();
            rule1.Init(3, "Fizz");
            rule2.Init(5, "Buzz");

            Application game = new Application();
            game.AddRule(rule1);
            game.AddRule(rule2);

            game.Run(1, 10);

            Console.WriteLine("press any key");
			Console.ReadKey();
		}
	}
}
