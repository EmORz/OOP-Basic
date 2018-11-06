namespace Operations
{
    using _1_MathOperation;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            var withInt = mathOperations.Add(2, 3);
            var withDouble = mathOperations.Add(2.2, 3.3, 5.5);
            var withDecimal = mathOperations.Add(2.2m, 3.3m, 4.4m);
            //
            Console.WriteLine(withInt);
            Console.WriteLine(withDouble);
            Console.WriteLine(withDecimal);
        }
    }
}
