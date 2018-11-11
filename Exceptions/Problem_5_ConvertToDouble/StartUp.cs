using System;

namespace Problem_5_ConvertToDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Which exceptions can occur by converting from string to double?
            //Write a program which triggers these exceptions
            try
            {
                var result = ReadDouble();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            when(ex is FormatException || ex is OverflowException)
            {
            } 
        }

        private static double ReadDouble()
        {
           
            try
            {
                string input = Console.ReadLine();
                var convToDoub = Convert.ToDouble(input);
                return convToDoub;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                throw fe;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                throw oe;
            }
        }
    }
}
