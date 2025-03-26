namespace Sushilio.UltimateCalculator
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            return (int) (a / b);
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
