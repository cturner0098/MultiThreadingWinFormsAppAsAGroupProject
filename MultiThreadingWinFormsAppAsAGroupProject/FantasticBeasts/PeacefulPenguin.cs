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
    class PeacefulPenguin : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }

        public static Boolean IsPrime(long num)
        {
            Boolean status = true;
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if ((num % i) == 0) return false;
            }
            return status;
        }

        public static long ComputeLargestPrimeFactor(long num)
        {
            long answer = 0;
            for (long y = num / 2; y > 1; y--)
            {
                if (num % y == 0 && IsPrime(y) == true)
                {

                    answer = y;
                    break;
                }
            }
            return answer;
        }

        public override void RunThread()
        {

            long num = Convert.ToInt64(request);
            //long numTwo = 0;
            response = Convert.ToString(ComputeLargestPrimeFactor(num));
            


            /*for(int x = 2; x < num; x++)
            {
                if (IsPrime(x))
                {
                    x = (int)numTwo;
                }
            }*/

        }
    }
}
