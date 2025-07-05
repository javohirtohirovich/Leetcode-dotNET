namespace Leetcode_dotNET;

public class Problem_0824
{
    public string ToGoatLatin(string sentence)
    {
        var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        var words = sentence.Split(' ');
        var result = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (vowels.Contains(char.ToLower(words[i][0])) || words[i].Length == 1)
            {
                result += words[i] + "ma" + new string('a', i + 1) + " ";
            }
            else
            {
                result += words[i].Substring(1) + words[i][0] + "ma" + new string('a', i + 1) + " ";
            }
        }

        return result.Substring(0, result.Length - 1);
    }
}
