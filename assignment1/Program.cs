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
            int result = 1;

            // A
            for (int i = 1; i < numb; i++)
            {
                result *= n;
                n--;
            }

            // B
            Console.WriteLine($"n = {numb}");
            string println = "";
            List<string> list = new List<string>();

            for (int j = 0; j < numb; j++)
            {
                if (n == 1)
                {
                    println += $"f({n})";
                }
                else
                {
                    println += $"f({n}) = f({n - 1}) x {n}";
                }

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
