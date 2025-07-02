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
        for (int j = 0; j < letterCountList.Count; j++)
        {
            var ishora = true;

            for (int i = 0; i < 26; i++)
            {
                if (licensePlateLetter[i] != 0)
                {
                    if (licensePlateLetter[i] > letterCountList[j][i])
                    {
                        ishora = false;
                        break;
                    }
                }
            }
            if (ishora)
            {
                if (words[j].Length < minResult)
                {
                    result = words[j];
                    minResult = words[j].Length;
                }
            }
        }

        return result;
    }
}
