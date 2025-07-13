namespace Leetcode_dotNET;

public class Problem_0504
{
    public string ConvertToBase7(int num)
    {
        var result = "";
        var n = Math.Abs(num);
        while (n != 0)
        {
            var remainder = n % 7;
            result = remainder + result;
            n /= 7;
        }
        if (num < 0)
        {
            result = "-" + result;
        }
        return result == "" ? "0" : result;
    }
}
