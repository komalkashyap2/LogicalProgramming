using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5, a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a prime number", num);


            }
            else
            {
                Console.WriteLine("not a prime number");
            }
            Console.ReadLine();
        }
    }
}
