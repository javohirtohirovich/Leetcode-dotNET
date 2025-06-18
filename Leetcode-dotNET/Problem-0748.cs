namespace Leetcode_dotNET;

public class Problem_0748
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var licensePlateLetter = new int[26];
        foreach (var l in licensePlate)
        {
            if (char.IsLetter(l))
            {
                licensePlateLetter[char.ToLower(l) - 'a']++;
            }
        }


        List<int[]> letterCountList = new List<int[]>();
        foreach (var word in words)
        {
            int[] letterCounts = new int[26];
            foreach (var ch in word)
            {
                if (char.IsLetter(ch))
                {
                    letterCounts[char.ToLower(ch) - 'a']++;
                }
            }
            letterCountList.Add(letterCounts);
        }

        var minResult = int.MaxValue;
        var result = "";
        foreach (var word in words)
        {
            var ishora = true;

            for (int i = 0; i < 26; i++)
            {
                if (licensePlateLetter[i] > word[i])
                {
                    ishora = false;
                    break;
                }

            }
            if (ishora)
            {
                if (word.Length < minResult)
                {
                    result = word;
                    minResult = word.Length;
                }
            }
        }

        return result;
    }
}
