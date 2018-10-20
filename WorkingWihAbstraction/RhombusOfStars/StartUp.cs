using System;

namespace RhombusOfStars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrintRhombus(n, i);
            }
            for (int i = n - 2; i >= 0; i--)
            {
                PrintRhombus(n, i);

            }

        }

        private static void PrintRhombus(int n, int i)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }

    }
}
