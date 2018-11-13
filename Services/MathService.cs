using System;

namespace MvcMovie.Services
{
    public class MathService
    {
        private Guid _id = Guid.NewGuid();

        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Divide(decimal numerator, decimal denominator)
        {
            return numerator / denominator;
        }

        public Guid Id
        {
            get
            {
                return _id;
            }
        }
    }
}