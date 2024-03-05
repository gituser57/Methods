#define recursion

namespace Methods
{
    /// <summary>
    /// arithmetic progression instance
    /// </summary>
    public class InstanceProgression
    {
        public readonly double A1;
        public readonly double Difference;
    public InstanceProgression(double a1, double difference)
        {  A1 = a1; Difference = difference; }

        /// <summary>
        /// the n member of arithmetic progression 
        /// </summary>
        public double An(double n) => A1 + (n - 1) * Difference;

        /// <summary>
        /// summary of n arithmetic progression members  
        /// </summary>
        public double SumA1UpAn(double n)
        {

#if recursion

            if (n == 1)
                return A1;
            else
                return An(n) + SumA1UpAn(n - 1);
#else
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += An(i);
            return sum;
#endif
        }
    }
}
