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
    class ObedientOwl : FantasticBeast
    {
        public override void SayHello()
        {
            
        }

        public override void RunThread()
        {
            response = ComputeLargestPrimeFactor(Int32.Parse(request)).ToString();
        }
        public int ComputeLargestPrimeFactor(int num)
        {
            int answer = 0;
            for (int y = num / 2; y > 1; y--)
            {
                if (num % y == 0 && IsPrime(y) == true)
                {

                    answer = y;
                    break;
                }
            }
            return answer;
        }

      
        public bool IsPrime(int num)
        {
            bool primeness = true;
            for (int x = 2; x < num; x++)
            {
                if (num % x == 0)
                {
                    primeness = false;
                    break;
                }
            }
            return primeness;
        }
    }
}
