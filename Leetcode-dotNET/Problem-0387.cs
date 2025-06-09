using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_dotNET;

public class Problem_0387
{
    public int FirstUniqChar(string s)
    {
        var lettersCount = new int[26];
        foreach (char c in s)
        {
            lettersCount[c - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (lettersCount[s[i] - 'a'] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}
