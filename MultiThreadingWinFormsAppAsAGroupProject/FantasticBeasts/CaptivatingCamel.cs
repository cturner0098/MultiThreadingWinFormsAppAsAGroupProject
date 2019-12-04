/*****************************************************************************************************************
 * Name            - Thaddeus Fairweather
 * Email Address   - fairwetd@mail.uc.edu   
 * Assignment #    - MultiThreadingWinFormsAppAsAGroupProject GITHUB
 * Due date        - 12/03/2019
 * Course          - IT3045C
 *****************************************************************************************************************/
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
    class CaptivatingCamel : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            // Use the value in request, compute the largest prime factor,
            // store in response
            response = ComputeLargestPrimeFactor(Convert.ToInt64(request)).ToString();

        }
        /// <summary>
        /// Find Largest Prime Factor Number 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public long ComputeLargestPrimeFactor(long num)
        {
            int i;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    num /= i;
                    i--;
                }
            }
            return i;
        }
    }
}
