namespace Leetcode_dotNET;

public class Problem_0067
{
    public string AddBinary(string a, string b)
    {
        var result = "";

        var i = a.Length - 1;
        var j = b.Length - 1;
        var qoldiq = 0;

        while (i >= 0 || j >= 0 || qoldiq == 1)
        {
            int bitA = i >= 0 ? a[i] - '0' : 0;
            int bitB = j >= 0 ? b[j] - '0' : 0;

            int sum = bitA + bitB + qoldiq;

            result = (sum % 2) + result;
            qoldiq = sum / 2;

            i--;
            j--;
        }
        return result;
    }
}
