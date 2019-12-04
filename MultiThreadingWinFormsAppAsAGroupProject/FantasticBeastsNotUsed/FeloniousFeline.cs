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
    class FeloniousFeline : FantasticBeast
    {
        private int num;

        public override void SayHello()
        {
            throw new NotImplementedException();
        }
        public override void RunThread()
        {

        }


        public int ComputeLargestPrimeFactor()
        {
            int result = 1;
            for (int i = num / 2; i >= 1; i--)
            {
                if (isPrime(i) && num % i == 0) { result = i; return i;}
            }
            // returns zero is it cannot work out for the program
            return 0;
        }
        private Boolean isPrime(int num)
        {
            Boolean answer = true;
            for (long i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {// if the number is 0 it will return false and will return the result 
                 // back to the main method else it'll return as true
                    answer = false; break;
                }

            }
            return answer;
        }
    }
}