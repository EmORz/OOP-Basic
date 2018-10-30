namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("T1");
            list.Add("T2");
            list.Add("T3");
            list.Add("T4");
            list.Add("T5");
            list.Add("T6");

            while (list.Count >0)
            {
                Console.WriteLine(list.GetRandomElement());
            }



        }
    }
}
