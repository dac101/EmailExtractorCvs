using System;

namespace AlgothrimDevelopment.Algothrim
{
    public class FizzBuzz
    {
        private static void FizzBuzzCode()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine(i + " is FizzBuzz \n");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine(i + " is Fizz \n");
                }else if (i%5 == 0)
                {
                    Console.WriteLine(i + " is Buzz \n");
                }
                else
                {
                    Console.WriteLine(i + "\n");
                }
            }
        }
    }
}