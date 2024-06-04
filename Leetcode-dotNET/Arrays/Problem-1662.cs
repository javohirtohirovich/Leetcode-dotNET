namespace Leetcode_dotNET.Arrays;

public class Problem_1662
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var strWord1 = "";
        var strWord2 = "";
        if (String.Join(strWord1, word1) == String.Join(strWord2, word2))
        {
            return true;
        }
        return false;
    }
}
