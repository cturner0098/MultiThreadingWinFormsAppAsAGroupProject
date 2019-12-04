/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class MuscularMoose : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            long num = Convert.ToInt64(request);
            response = Convert.ToString(ComputeLargestPrimeFactor(num));
          // Console.WriteLine(response);

        }

        public long ComputeLargestPrimeFactor(long num)
        {
            // declare i to be used in return
            int i;
            for (i = 2; i < num; i++)
            {
                // check if it can be divided (not prime)
                if (num % i == 0)
                {
                    // if not prime, divide num by i
                    num /= i;
                    // minus i incase the next number is also divisible by current
                    i--;
                }
            }

            // return largest prime factor
            return i;
        }
    }
}