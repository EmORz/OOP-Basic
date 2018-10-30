namespace CustomStack
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            stack.Push("something1");
            stack.Push("something2");
            stack.Push("something3");
            stack.Push("something4");
            stack.Push("something5");
            stack.Push("something6");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());





        }
    }
}
