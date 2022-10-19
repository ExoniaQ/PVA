using System;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = Convert.ToUInt64(Console.ReadLine());
            bool prime = true;

            if (num % 2 == 0 && num > 2)
            {
                prime = false;
            }
            else
            {
                int boundary = (int)Math.Sqrt(num);
                for (int i = 3; i < boundary; i += 2)
                {
                    if (num % Convert.ToUInt64(i) == 0)
                    {
                        prime = false;
                    }
                }
            }
            if (prime)
            {
                Console.WriteLine("is prime");
            }
            else
            {
                Console.WriteLine("is not prime");
            }
            Console.ReadKey();
        }
    }
}
