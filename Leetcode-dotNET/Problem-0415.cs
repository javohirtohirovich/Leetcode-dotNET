using System.Text;

namespace Leetcode_dotNET;

public class Problem_0415
{
    public string AddStrings(string num1, string num2)
    {
        var i = num1.Length - 1;
        var j = num2.Length - 1;
        var q = 0;
        var result = new StringBuilder();

        while (i >= 0 || j >= 0 || q > 0)
        {
            var raqam1 = 0;
            var raqam2 = 0;
            if (i >= 0)
            {
                raqam1 = num1[i] - '0';
            }

            if (j >= 0)
            {
                raqam2 = num2[j] - '0';
            }

            int sum = raqam1 + raqam2 + q;
            result.Insert(0, (sum % 10));
            q = sum / 10;

            i--;
            j--;
        }
        return result.ToString();
    }
}
