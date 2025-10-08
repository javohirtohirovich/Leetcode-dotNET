namespace Leetcode_dotNET;

public class Problem_0405
{
    public string ToHex(int num)
    {
        if (num == 0) return "0";

        uint n = (uint)num;

        string result = "";
        while (n != 0)
        {
            uint remainder = n % 16;
            if (remainder < 10)
            {
                result = (char)(remainder + '0') + result;
            }
            else
            {
                result = (char)(remainder - 10 + 'a') + result;
            }

            n /= 16;
        }

        return result;
    }
}
