using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Staircase
{
    class Solution
    {
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string line = new string('#', i).PadLeft(n);
                Console.WriteLine(line);
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
