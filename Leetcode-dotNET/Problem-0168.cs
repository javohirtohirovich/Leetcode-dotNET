namespace Leetcode_dotNET;

public class Problem_0168
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = "";
        while (columnNumber > 0)
        {
            columnNumber--;
            int remainder = columnNumber % 26;
            result = (char)(remainder + 'A') + result;
            columnNumber /= 26;

        }
        return result;
    }
}
