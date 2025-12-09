using System;

namespace Factorial
{
    class Program
    {
        static int fact(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * fact(n - 1);

        }
        static void Main(string[] args)
        {

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("enter number:");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Factorial of {0} = {1}",n1,fact(n1));
            }

            Console.ReadKey();
        }
    }
}
