using System.Text;

namespace Leetcode_dotNET;

public class Problem_0557
{
    public string ReverseWords(string s)
    {
        var words= s.Split(' ');
        var result = new StringBuilder();

        foreach(var word in words)
        {
            for(int i = word.Length - 1; i >= 0; i--)
            {
                result.Append(word[i]);
            }
            result.Append(" ");
        }

        result.Remove(result.Length - 1,1);
        return result.ToString();
    }
}
