namespace Leetcode_dotNET;

public class Problem_0844
{
    public bool BackspaceCompare(string s, string t)
    {
        var resultS = Remover(s);
        var resultT = Remover(t);

        return resultS == resultT;
    }

    public string Remover(string str)
    {
        var hashtag = 0;
        string result = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == '#')
            {
                hashtag++;
                continue;
            }

            if (hashtag == 0)
            {
                result = str[i] + result;
            }
            else
            {
                hashtag--;
            }
        }
        return result;
    }
}
