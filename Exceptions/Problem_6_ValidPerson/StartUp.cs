using System;

namespace Problem_6_ValidPerson
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                Person vaidPerson = new Person(32, "Nikolov", "Emo");
                Person firstNamePerson = new Person(-32, "Nikolov", "yt");

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch(ArgumentOutOfRangeException aoe)
            {
                Console.WriteLine(aoe.Message);
            }
        

        }
    }
}
