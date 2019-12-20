using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Project_Euler.No1
{
    class Solution
    {
        static void Main(String[] args)
        {
            List<long> numbers = new List<long>();

            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
            }

            foreach (var item in numbers)
            {
                long number = item - 1;

                long x3 = number / 3;
                long x5 = number / 5;
                long x15 = number / 15;

                long sum1 = 3 * x3 * (x3 + 1);
                long sum2 = 5 * x5 * (x5 + 1);
                long sum3 = 15 * x15 * (x15 + 1);

                long sum = (sum1 + sum2 - sum3) / 2;
                Console.WriteLine(sum);
            }
        }
    }
}
