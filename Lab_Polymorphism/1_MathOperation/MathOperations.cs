namespace _1_MathOperation
{
    public class MathOperations
    {
        //•	Add(int, int): int
        //•	Add(double, double, double): double
        //•	Add(decimal, decimal, decimal): decimal
       
        public int Add(int first, int second)
        {
            return first + second;
        }
        public double Add(double first, double second, double third)
        {
            return first + second + third;
        }
        public decimal Add(decimal first, decimal second, decimal third)
        {
            return first + second + third;
        }
    }
}
