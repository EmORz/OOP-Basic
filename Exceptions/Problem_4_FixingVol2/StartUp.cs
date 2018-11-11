using System;

namespace Problem_4_FixingVol2
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //The given program is throwing an OverflowException. Fix it.
            try
            {
                int num1, num2;
                byte result;

                num1 = 30;
                num2 = 60;
                result = Convert.ToByte(num2 * num1);
                Console.WriteLine($"{num1} x {num2} = {result}");
                Console.ReadLine();
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
         
        }
    }
}
