using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._3PrimeNumbers
{
    
    public static class PrimeNumber
    {
        //PrimeNumber GetPrime = new PrimeNumber();
        public static int GetPrime(int n)
        {
            int primeNum = 1;
            int primeCount = 0;

            while (primeCount != n)
            {
                primeNum++;
                if(isPrime(primeNum))
                {
                    primeCount++;
                }
            }
            return primeNum;
        }

        public static bool isPrime(int primeNum)
        {
            for (int i = 2; i < primeNum; i++)
            {
                if (primeNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prime Number Finder.  We find the Primes so you don't have to!");
            Console.WriteLine();

            bool keepgoing;
            while (keepgoing = true)
            {


                Console.WriteLine("What Prime number are you looking for?");
                Console.WriteLine();
                int entry = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number you chose, {entry}, is Prime number {PrimeNumber.GetPrime(entry)}.");
                Console.WriteLine();
                Console.WriteLine("Would you like us to find you another Prime Number?  yes/no");
                Console.WriteLine();
                string goAgain = Console.ReadLine().ToLower();
                if (goAgain == "yes" || goAgain == "y")
                {
                    keepgoing = true;
                }
                else
                {
                    keepgoing = false;
                }
                
            }
            
        }
    }
}
