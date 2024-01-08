using System;

namespace Hw1.Exercise1
{
    /// <summary>
    /// Prime numbers application core.
    /// </summary>
    public class PrimeNumbersApplication
    {
        /// <summary>
        /// Runs prime numbers application.
        /// Prints prime numbers in the given range (from <paramref name="args"/>) to the output.
        /// </summary>
        /// <param name="args">
        /// Arguments - valid integer range [from, to] 
        /// between <see cref="int.MinValue"/> and <see cref="int.MaxValue"/>
        /// to find prime numbers.
        /// </param>
        /// <returns>Return <c>0</c> in case of success and <c>-1</c> in case of failure.</returns>
        public int Run(string[] args)
        {
            int temp;

            if (args == null || args.Length != 2 || !int.TryParse(args[0], out var from) || !int.TryParse(args[1], out var to))
            {
                return -1;
            }

            if (from > to)
            {
                temp = from;
                from = to;
                to = temp;
            }

            for (var number = from; number <= to; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number);
                    Console.Write(';');
                }
            }
            return 0;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (var i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

