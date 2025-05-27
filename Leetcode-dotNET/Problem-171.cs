namespace Leetcode_dotNET;

public class Problem_171
{
    public int TitleToNumber(string columnTitle)
    {
        int result = 0;
        foreach (var c in columnTitle)
        {
            int value = c - 'A' + 1;
            result = result * 26 + value;
        }
        return result;
    }
}
