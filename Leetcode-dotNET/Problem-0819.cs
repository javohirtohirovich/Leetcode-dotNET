using System.Diagnostics.Tracing;

namespace Leetcode_dotNET;

public class Problem_0819
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var wordsList = new List<string>();
        var word = "";
        foreach (var l in paragraph)
        {
            if (char.IsLetter(l))
            {
                word += char.ToLower(l);
            }
            else
            {
                if (!string.IsNullOrEmpty(word) && !banned.Contains(word))
                {
                    wordsList.Add(word);
                }
                word = "";

            }
        }

        if (wordsList.Count == 0 && !string.IsNullOrEmpty(word))
        {
            wordsList.Add(word);
        }

        var countDict = new Dictionary<string, int>(wordsList.Count);
        foreach (var w in wordsList)
        {
            if (countDict.TryGetValue(w, out int count))
                countDict[w] = count + 1;
            else
                countDict[w] = 1;
        }

        int maxCount = 0;
        string maxItem = string.Empty;
        foreach (var kvp in countDict)
        {
            if (kvp.Value > maxCount)
            {
                maxCount = kvp.Value;
                maxItem = kvp.Key;
            }
        }

        return maxItem;

    }
}
