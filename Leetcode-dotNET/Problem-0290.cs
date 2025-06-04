namespace Leetcode_dotNET;

public class Problem_0290
{
    public bool WordPattern(string pattern, string s)
    {
        var dict1 = new Dictionary<string, char>();
        var dict2 = new Dictionary<char, string>();
        var words = s.Split(' ');
        if (words.Length != pattern.Length)
        {
            return false;
        }
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            var letter = pattern[i];

            if (!dict1.ContainsKey(word))
            {
                dict1.Add(word, letter);
            }
            else
            {
                if (dict1[word] != letter)
                {
                    return false;
                }
            }

            if (!dict2.ContainsKey(letter))
            {
                dict2.Add(letter,word);

            }
            else
            {
                if(dict2[letter] != word)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
