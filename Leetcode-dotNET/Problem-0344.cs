namespace Leetcode_dotNET;

public class Problem_0344
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left <= right)
        {
            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
}
