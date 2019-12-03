/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class ClimbingCougar : FantasticBeast
    {
        public override void SayHello()
        {
            throw new NotImplementedException();
        }
        public override void RunThread()
        {
            response = maxfactor(request);
        }
        static private long maxfactor(long n)
        {
            long k = 2;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    n /= k;
                }
                else
                {
                    ++k;
                }
            }

            return n;
        }
    }
}
