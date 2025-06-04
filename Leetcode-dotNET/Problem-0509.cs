using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_dotNET;

public class Problem_0509
{

    //public int Fib(int n)
    //{
    //    if (n < 2) return n;
    //    return Fib(n - 1) + Fib(n - 2);
    //}

    public int Fib(int n)
    {
        if (n < 2) return n;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
