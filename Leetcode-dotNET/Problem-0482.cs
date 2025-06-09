using System.Text;

namespace Leetcode_dotNET;

public class Problem_0482
{
    //2-solution

    public string LicenseKeyFormatting(string s, int k)
    {
        s = s.Replace("-", "").ToUpper();
        if (s.Length < k)
        {
            return s;
        }

        var result = new StringBuilder();

        int f = k;
        for (int i = 0; i < s.Length / k; i++)
        {
            result.Insert(0, "-" + s.Substring(s.Length - f, k));
            f += k;
        }

        if (s.Length % k != 0)
        {
            result.Insert(0, s.Substring(0,s.Length % k));
        }
        else
        {
            result.Remove(0, 1);
        }

        return result.ToString();
    }

    //1-solution
    //public string LicenseKeyFormatting(string s, int k)
    //{
    //    var result = "";
    //    var f = 0;
    //    for (int i = s.Length - 1; i >= 0; i--)
    //    {
    //        if (s[i] == '-')
    //        {
    //            continue;
    //        }
    //        if (f == k)
    //        {
    //            result = "-" + result;
    //            f = 0;
    //        }
    //        result = char.ToUpper(s[i]) + result;
    //        f++;

    //    }

    //    return result;
    //}
}
