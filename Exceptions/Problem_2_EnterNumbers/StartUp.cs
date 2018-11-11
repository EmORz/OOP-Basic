using System;

namespace Problem_2_EnterNumbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
            //If an invalid number or a non-number text is entered, the method should throw an exception.
            //that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
            //If the user enters an invalid number, make the user enter all of them again.
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            //TODO - make it
            ReadNumber(start, end);



        }

        private static void ReadNumber(int start, int end)
        {

            for (int i = 0; i < 8; i++) //enters 10 numbers
            {
                int temp = int.Parse(Console.ReadLine());


            }
        }
    }
}
