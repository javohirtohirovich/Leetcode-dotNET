namespace Leetcode_dotNET;

public class Problem_14
{
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs == null || strs.Length == 0)
        {
            return "";
        }

        string minStr = strs.OrderBy(s => s.Length).First();

        for(int i =0; i < minStr.Length; i++)
        {
            foreach(string str in strs)
            {
                if(str[i] != minStr[i])
                {
                    return minStr.Substring(0, i);
                }
            }
        }

        return minStr;

    }
}