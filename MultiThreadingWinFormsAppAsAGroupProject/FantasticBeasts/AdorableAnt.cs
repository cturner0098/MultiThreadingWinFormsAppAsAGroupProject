/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class AdorableAnt : FantasticBeast
    {
        public override void SayHello() {
            Console.WriteLine("Hello from AdorableAnt");
        }
        public override void RunThread() {
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            long result = ComputeLargestPrimeFactor(num);
            response = Convert.ToString(result);
        }

        public long ComputeLargestPrimeFactor(long num)
        {
            long result = 1;
            for (long i = num / 2; i >= 1; i--)
            {
                if (IsPrime(i) && num % i == 0) { result = i; break; }
            }
            return result;
        }
        private Boolean IsPrime(long num)
        {
            Boolean result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) { result = false; break; }
            }
            return result;
        }

    }
}
