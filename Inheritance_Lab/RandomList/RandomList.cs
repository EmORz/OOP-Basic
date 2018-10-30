namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList: List<string>
    {
        private Random rnd;

        public RandomList()
        {
            this.Rnd = new Random();
        }

        public Random Rnd { get => rnd; set => rnd = value; }

        public string GetRandomElement()
        {
            if (Count<1)
            {
                return "no questions avialable";
            }
            int index = Rnd.Next(0, Count-1 );
            string result = this[index];
            RemoveAt(index);
            return result;
        }
    }
}
