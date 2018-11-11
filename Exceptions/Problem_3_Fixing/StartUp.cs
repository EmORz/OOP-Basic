using System;

namespace Problem_3_Fixing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            /*This program is throwing an IndexOutOfRangeException. 
             * Using your skills, fix this problem using a try catch block.*/
            string[] weekdays = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday"  };
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(weekdays[i].ToString());
                }
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException indE)
            {
                Console.WriteLine(indE.Message);
            }
           
        }
    }
}
