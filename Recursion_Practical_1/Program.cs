using System;
using System.Collections.Generic;

namespace Recursion_Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Assignment_1_Factorial(7);
        }

        public void Assignment_1_Factorial(int numb)
        {
            int n = numb;
            Console.WriteLine($"n = {n}");
            int result = 1;

            Console.Write($"f(n) = ");
            // A
            for (int i = 1; i < numb; i++)
            {
                result *= n;
                Console.Write($"{i} x ");
                n--;
            }

            Console.Write($"= {result}");
            Console.WriteLine();

            // B
            Console.WriteLine($"n = {numb}");
            string println = "";
            List<string> list = new List<string>();

            for (int i = 0; i < numb; i++)
            {
                println += $"f({n}) = f({n - 1}) x {n}";
                var r = Factorial(n);
                println += $" = {r}";
                list.Add(println);
                println = "";
                n++;
            }

            list.ForEach(x => Console.WriteLine(x));
        }

        public int Factorial(int n)
        {
            if (n < 1)
                return 1;

            return Factorial(n - 1) * n;
        }


    }
}
