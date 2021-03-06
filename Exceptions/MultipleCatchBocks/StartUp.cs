﻿using System;

namespace MultipleCatchBocks
{
    class StartUp
    {
        static void Main(string[] args)
        {

                try
                {
                    Sqrt(-1);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine("Error: " + ex.Message);
                    throw;
                }        



        }

        public static double Sqrt(double value)
        {
            if (value < 0)
                throw new System.ArgumentOutOfRangeException("value",
                   "Sqrt for negative numbers is undefined!");
            return Math.Sqrt(value);
        }
    }
}
