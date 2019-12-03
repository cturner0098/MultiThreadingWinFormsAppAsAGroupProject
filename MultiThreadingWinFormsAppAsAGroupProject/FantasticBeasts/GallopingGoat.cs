/****************************************************************************************************************************************************************
 * Name: Joseph Svintsitsky
 * Email: svintsjr@mail.uc.edu
 * Assignment #: In class
 * Due Date: 12/03/19
 * Course: IT3045C
 * Desc: Implement the RunThread method in your beast. 
 * The method should compute the largest prime factor 
 * for the integer in the class member request and store 
 * the solution in the class member response. 
 ****************************************************************************************************************************************************************
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    class GallopingGoat : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }

        public override void RunThread()
        {
            response = ComputeLargestPrimeFactor(Convert.ToInt64(request)).ToString();
            Console.WriteLine("Response: {0}", response);
        }

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
