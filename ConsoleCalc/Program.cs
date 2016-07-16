using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
	public class Rule
	{
		public string message;
		public int number;

		public void Init(string msg, int num)
		{
			message = msg;
			number = num;
		}

		public string Dividable(int i)
		{
			if (i % number == 0)
			{
				return message;
			}
			return "";

		}
	}

    public class Application
    {
		public List<Rule> rule = new List<Rule>();

		public void AddRule(Rule r)
		{
			rule.Add(r);
		}

        public void Run(int start, int stop)
        {
            Console.WriteLine();
            for (int i = start; i <= stop; i++)
            {
                string msg = "";
				foreach(Rule r in rule)
				{
					msg = msg + r.Dividable(i);
				}

                if (msg == "")
                {
                    msg = i.ToString();
                }
                Console.WriteLine(msg);
            }
        }
    }

	class MainClass
	{
		public static void Main(string[] args)
		{
            Application game1 = new Application();
			Rule rule1 = new Rule();
			Rule rule2 = new Rule();
			rule1.Init("Fizz", 3);
			rule2.Init("Bizz", 5);

			game1.AddRule(rule1);
			game1.AddRule(rule2);

            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            game1.Run(startNum, stopNum);

            Console.WriteLine("press any key");
			Console.ReadKey();
		}
	}
}
