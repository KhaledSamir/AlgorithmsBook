using System;
namespace AlgorthimsBook.Chapter1
{
    public class Chapter1
    {
        public Chapter1()
        {
        }

        public decimal multiply(decimal x, decimal y)
        {
            if (y == 0) return 0;

            decimal z = multiply(x, Math.Floor(y));

            if (y % 2 == 0)
                return 2 * z;

            return x + (2 * z);
        }
    }
}
