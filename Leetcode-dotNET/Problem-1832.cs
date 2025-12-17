namespace Leetcode_dotNET;

public class Problem_1832
{

    public bool CheckIfPangram(string sentence)
    {
        var alph = "abcdefghijklmnopqrstuvwxyz";

        for(int i = 0;  i < alph.Length; i++)
        {
            if(!sentence.Contains(alph[i]))
            {
                return false;
            }
        }
        return true;
    }


    //solution - 1
    //public bool CheckIfPangram(string sentence)
    //{
    //    var result = new HashSet<char>();
    //    foreach(char c in sentence)
    //    {
    //        result.Add(c);
    //    }

    //    return result.Count == 26;
    //}
}
