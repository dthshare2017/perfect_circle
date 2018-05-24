using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put your number to check isPerfectNumber here: ");
            int n = int.Parse(Console.ReadLine());
            if (is_perfect_number(n))
                Console.WriteLine(n + " is perfect number");
            else Console.WriteLine(n + "is not perfect number");
            Console.ReadLine();
        }

        static bool is_perfect_number(int n)
        {
            try
            {
                int _total = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        _total += i;
                }
                if (_total == n)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}