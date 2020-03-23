using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public static class PrimeNumber
    {
        public static bool IsPrime(this int number)
        {
            if (number > 0 && number <= 3)
            {
                return true;
            }
            if (number < 0 || number%2==0)
            {
                return false;
            }
         
            for(int i = 3; i<Math.Sqrt(number); i=i+2)
            {
                if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Method1(int n)
        {
            int k = n;
            while(!k.IsPrime())
            {
                k--;
            }
            return k;
        }
     
        public static int Method2(int n)
        {
            List<int> primes = new List<int>();
            for(int i=1; i<n;i++)
            {
                if (i.IsPrime())
                    primes.Add(i);
            }
            return primes[primes.Count - 1];
        }
    }
}
