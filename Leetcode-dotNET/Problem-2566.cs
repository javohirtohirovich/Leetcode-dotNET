namespace Leetcode_dotNET;

public class Problem_2566
{
    public int MinMaxDifference(int num)
    {
        var min = 0;
        var max = 0;
        var ishora = char.MinValue;
        var strNums1 = num.ToString().ToCharArray();
        var strNums2 = num.ToString().ToCharArray();


        for (var i = 0; i < strNums1.Length; i++)
        {
            if (strNums1[i] != '9' && ishora==char.MinValue)
            {
                ishora = strNums1[i];
                strNums1[i] = '9';
            }
            else if (ishora == strNums1[i])
            {
                strNums1[i] = '9';

            }
        }
        ishora= char.MinValue;


        ishora = strNums2[0];
        for (var i = 0; i < strNums2.Length; i++)
        {
            if (ishora == strNums2[i])
            {
                strNums2[i] = '0';
            }
        }


        max = int.Parse(new string(strNums1));
        min = int.Parse(new string(strNums2));

        return max - min;

    }
}
