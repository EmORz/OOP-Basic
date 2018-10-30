namespace CustomStack
{
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings: List<string>
    {
        public void Push(string element)
        {
            Add(element);
        }
        public string Pop()
        {
            string element = this.LastOrDefault();
            RemoveAt(IndexOf(element));
            return element;
        }
        public string Peek()
        {
            return this.LastOrDefault();
        }
        public bool IsEmpty()
        {
            return this.Count >= 0;
        }

    }
}
