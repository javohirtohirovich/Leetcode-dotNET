namespace Leetcode_dotNET;

public class Problem_1945
{
    public int GetLucky(string s, int k)
    {
        string son = "";
        int sum = 0;


        foreach (char c in s)
        {
            son += (-96 + (int)c).ToString();
        }
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < son.Length; j++)
            {
                sum += int.Parse(son[j].ToString());
            }
            son=sum.ToString();
            sum = 0;
        }
        return int.Parse(son);
    }

    //The most effective method
    //public int GetLucky(string s, int k)
    //{
    //    // Bosqich 1: Belgilarni raqamga aylantirish
    //    string digits = "";
    //    foreach (char c in s)
    //    {
    //        int val = c - 'a' + 1;
    //        digits += val.ToString();
    //    }

    //    // Bosqich 2: Raqamlarni yig'indisini k marta olish
    //    while (k-- > 0)
    //    {
    //        int sum = 0;
    //        foreach (char d in digits)
    //        {
    //            sum += d - '0';
    //        }
    //        digits = sum.ToString();
    //    }

    //    return int.Parse(digits);
    //}
}
