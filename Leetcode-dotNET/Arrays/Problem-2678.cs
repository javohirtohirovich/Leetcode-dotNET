namespace Leetcode_dotNET.Arrays;

public class Problem_2678
{
    public int CountSeniors(string[] details)
    {
        int count = 0;
        for (int i = 0; i < details.Length; i++)
        {
            if (int.Parse(details[i][11].ToString() + details[i][12].ToString()) > 60)
            {
                count++;
            }
        }
        return count;
    }
}
