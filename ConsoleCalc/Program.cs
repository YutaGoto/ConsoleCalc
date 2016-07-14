using System;
using System.Collections.Generic;

namespace ConsoleCalc
{
	public class Rule
	{
		public void addRule(int num, string msg)
		{

		}
	}

    public class Application
    {
        public void run(int start, int stop)
        {
            Console.WriteLine();
            for (int i = start; i <= stop; i++)
            {
                string msg = "";
                if(i % 3 == 0)
                {
                    msg = msg + "Fizz";
                }

                if(i % 5 == 0)
                {
                    msg = msg + "Buzz";
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

            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            game1.run(startNum, stopNum);

            Console.WriteLine("press any key");
			Console.ReadKey();
		}
	}
}
