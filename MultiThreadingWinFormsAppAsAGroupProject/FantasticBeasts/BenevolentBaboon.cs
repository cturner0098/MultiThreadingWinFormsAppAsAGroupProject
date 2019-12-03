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
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);

            long result = ComputeLargestPrimeFactor(num);
            response = Convert.ToString(result);
        }

        /// <summary>
        /// Computes the largest prime factor of a number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public long ComputeLargestPrimeFactor(long num)
        {
            long largestPrimeFactor = -1;

            for (long i = (num - 1); i > 0; i--) //Start at num-1 and work down to zero.
            {
                if (IsPrime(i) && num % i == 0) //Checking to see if our current number, i, is both prime and a factor of our argument.
                {
                    largestPrimeFactor = i;
                    return largestPrimeFactor;
                }

            }

            return largestPrimeFactor;
        }

        private bool IsPrime(long num) //I created this method during my midterm.
        {
            bool isPrime = true;  //Initially set to true.  Will be changed as we test the number.

            if (num == 2)
            {
                isPrime = true;

            }
            else if (num == 1 || num == 0 || num % 2 == 0) //A few edge cases
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(num); i++) //Loop to test if the possible prime has factors.
                {

                    if (num % i == 0) //If the number has a factor, the number is not prime.
                    {
                        isPrime = false;
                        break;
                    }

                }
            }

            return isPrime; //Return whether or not the number is prime.
        }

    }
}

