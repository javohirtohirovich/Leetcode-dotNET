using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_dotNET;

public class Problem_0345
{
    public string ReverseVowels(string s)
    {
        var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        int i = 0;
        int j = s.Length - 1;
        bool iChanged = false;
        bool jChanged = false;
        var word = s.ToCharArray();

        while (i < j)
        {
            if (!vowels.Contains(word[i]))
            {
                i++;
            }
            else
            {
                iChanged = true;
            }

            if (!vowels.Contains(word[j]))
            {
                j--;
            }
            else
            {
                jChanged = true;
            }

            if (iChanged && jChanged)
            {
                var temp = word[i];
                word[i] = s[j];
                word[j] = temp;
                i++;
                j--;
                iChanged = false;
                jChanged = false;
            }


        }

        return new string(word);
    }
}
