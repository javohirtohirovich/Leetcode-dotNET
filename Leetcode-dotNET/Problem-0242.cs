namespace Leetcode_dotNET;

public class Problem_0242
{

    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        var lettersCount = new int[26];
        foreach (var c in s)
        {
            lettersCount[c - 'a']++;
        }
        foreach (var c in t)
        {
            lettersCount[c - 'a']--;
        }

        foreach (var count in lettersCount)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;

    }


    //public bool IsAnagram(string s, string t)
    //{
    //    if (s.Length != t.Length)
    //    {
    //        return false;
    //    }
    //    char[] sArray = s.ToCharArray().OrderBy(c=>c).ToArray();
    //    char[] tArray = t.ToCharArray().OrderBy(c=>c).ToArray();
    //    for (int i = 0; i < sArray.Length; i++)
    //    {
    //        if (sArray[i] != tArray[i])
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}


    //Alternative solution using a frequency count

    //public bool IsAnagram(string s, string t)
    //{
    //    if (s.Length != t.Length)
    //        return false;

    //    int[] charCount = new int[26]; // faqat kichik lotin harflari uchun

    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        charCount[s[i] - 'a']++;
    //        charCount[t[i] - 'a']--;
    //    }

    //    foreach (int count in charCount)
    //    {
    //        if (count != 0)
    //            return false;
    //    }

    //    return true;
    //}

}

