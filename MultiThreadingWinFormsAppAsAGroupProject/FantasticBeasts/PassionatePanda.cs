/*
 * Brennan Gilmore
 * gilmorbn@mail.uc.edu
 * PassionatePanda
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class PassionatePanda : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            // Use the value in request, compute the largest prime factor,
            // store in response
            //result.tosrtring()
            long num = Convert.ToInt64(request);
            response = Convert.ToString(ComputeLargestPrimeFactor(num));

        }
        public long ComputeLargestPrimeFactor(long num)
        {
            long lp = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0) { lp = i; break; }
            }
            return lp;
        }
        private Boolean IsPrime(long num)
        {
            Boolean result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
}
