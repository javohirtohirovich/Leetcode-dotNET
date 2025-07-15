namespace Leetcode_dotNET;

public class Problem_0884
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var s1Arr = s1.Split(" ");
        var s2Arr = s2.Split(" ");
        var hashSet = new HashSet<string>();
        foreach (var i in s1Arr)
        {
            hashSet.Add(i);
        }
        foreach (var i in s2Arr)
        {
            hashSet.Add(i);
        }

        var dict = new Dictionary<string, int>();
        foreach (var i in hashSet)
        {
            dict[i] = 0;
        }

        var result = new List<string>();
        foreach(var i in s1Arr)
        {
            dict[i]++;
        }
        foreach (var i in s2Arr)
        {
            dict[i]++;
        }

        foreach(KeyValuePair<string, int> pair in dict)
        {
            if (pair.Value == 1)
            {
                result.Add(pair.Key);
            }
        }
        return result.ToArray();
    }
}
