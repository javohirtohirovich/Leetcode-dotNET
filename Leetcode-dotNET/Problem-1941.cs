namespace Leetcode_dotNET;

internal class Problem_1941
{
    // 1941. Check if All Characters Have Equal Number of Occurrences
    //The way I undressed
    public bool AreOccurrencesEqual(string s)
    {
        s = new string(s.OrderBy(c => c).ToArray());
        int count1 = s.Count(x => x == s[0]);
        int count2 = 1;
        var point = s[0];
        for(int i = 1; i < s.Length; i++)
        {
            if (s[i] == point)
            {
                count2++;
            }
            else
            {
               if(count1 != count2)
                {
                    return false;
                }
                point = s[i];
                count2 = 1;
            }
        }
        if(count1 != count2)
        {
            return false;
        }
        return true;

    }

    //The most effective method
    //public bool AreOccurrencesEqual(string s)
    //{
    //    int[] freq = new int[26];

    //    foreach (char c in s)
    //    {
    //        freq[c - 'a']++;
    //    }

    //    int target = 0;
    //    foreach (int f in freq)
    //    {
    //        if (f == 0) continue;
    //        if (target == 0)
    //            target = f;
    //        else if (f != target)
    //            return false;
    //    }

    //    return true;
    //}

}
