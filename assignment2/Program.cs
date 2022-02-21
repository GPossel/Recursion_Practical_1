using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();

            // A
            int n = 15;
            int maxNumberToStop = 377;
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            Console.WriteLine($"n = {n}");
            Console.Write("{0}, ", num1);

            while (sum < maxNumberToStop + 1)
            {
                sum = num1 + num2;
                if (sum == maxNumberToStop) { Console.Write("{0}", sum); break; }
                Console.Write("{0}, ", num2);
                num1 = num2;
                num2 = sum;

            }

            Console.WriteLine();
            // B
            myProgram.Assignment_2_Fibonacci(10);
        }

        public void Assignment_2_Fibonacci(int numb)
        {

            // B
            Console.WriteLine($"n = {numb}");
            string println = "";
            List<string> list = new List<string>();
            int n = 1;

            for (int i = 0; i < numb; i++)
            {
                if (i == 0)
                { println += $"f({n})"; }
                else
                { println += $"f({n}) = f({n - 1}) + f({n - 2})"; }
                var r = Fibonacci(n);
                println += $" = {r}";
                list.Add(println);
                println = "";
                n++;
            }

            list.ForEach(x => Console.WriteLine(x));
            var result = 0;
            var lastSum = list.Last().Split().Last();
            Console.WriteLine($"result: {int.Parse(lastSum)}");
        }

        public int Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
