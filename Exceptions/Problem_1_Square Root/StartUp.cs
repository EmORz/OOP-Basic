using System;

namespace Problem_1_Square_Root
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            /*Write a program that reads an integer number and calculates and prints its square root.
             * If the number is invalid or negative, print "Invalid number". 
             * In all cases finally print "Good bye". Use try-catch-finally.*/
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number<0)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
