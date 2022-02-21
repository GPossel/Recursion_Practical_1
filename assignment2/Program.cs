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
            myProgram.Assignment_2_Fibonacci(10);
        }

        public void Assignment_2_Fibonacci(int numb)
        {
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
