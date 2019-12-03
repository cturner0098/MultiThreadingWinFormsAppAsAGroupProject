/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;

using System.Threading;


namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class BenevolentBaboon : FantasticBeast
    {
        public override void SayHello() {
            Console.WriteLine("Hello from BenevolentBaboon");
        }

        public override void RunThread()
        {
            long num = Convert.ToInt64(request);
            long result = ComputeLargestPrimeFactor(num);
            response = Convert.ToString(result);
        }

        public long ComputeLargestPrimeFactor(long num)
        {
            for (long i = num / 2; i > 1; i--)
            {

                if (num % i == 0 && isPrime(i))
                {
                    return i;
                }
            }
            return 0;

        }
        public bool isPrime(long num)
        {
            for (long i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}

