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
    class FranticFox : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            // Use the value in request, compute the largest prime factor,
            // store in response
            long result = computeLargestPrime(Convert.ToInt64(request));
            response = result.ToString();

            
        }
        public static long computeLargestPrime(long n)
        {
            long primeFactor = 1;
            long i = 2;

            while (i <= n / i)
            {
                if (n % i == 0)
                {
                    primeFactor = i;
                    n /= i;
                }
                else
                {

                    i += 1;
                }
            }


            if (primeFactor < n)
            {

                primeFactor = n;

            }
            return primeFactor;
        }
        

    }
}
