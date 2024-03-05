using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class StaticProgression
    {
        public static double An(double a1, double difference, double n) => a1 + (n - 1) * difference;

        public static double SumA1UpAn(double a1, double difference, double n)
        {
            if (n == 1)
                return a1;
            else
                return An(a1, difference, n) + SumA1UpAn(a1, difference, n - 1);
        }
    }
}
