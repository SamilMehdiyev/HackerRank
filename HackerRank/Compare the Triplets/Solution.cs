using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Compare_the_Triplets
{
    class Solution
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>() { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) result[0] += 1;
                else if (a[i] < b[i]) result[1] += 1;
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
