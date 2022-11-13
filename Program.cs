using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            for (int i = 1; i <= b; i++)
            {
                x *= a;
            }
            Console.Write("{0}, {1} -> {2}\n\n", a, b, x);
            Console.ReadKey();
        }
    }
