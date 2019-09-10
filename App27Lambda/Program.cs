using System;
using System.Collections.Generic;

namespace App27Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

        }
    }
    public static bool Find (List<int> a)
    {
        foreach (var item in a)
        {
            if (item == 56) return true;
        }
    }
}
