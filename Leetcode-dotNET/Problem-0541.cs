namespace Leetcode_dotNET;

public class Problem_0541
{
    public string ReverseStr(string s, int k)
    {
        var sLetters = s.ToArray<char>();
        for(int i = 0; i < s.Length; i += k * 2)
        {
            int a = i;
            int b = Math.Min(i + k - 1, s.Length - 1);
            while (a < b)
            {
                var temp = sLetters[a];
                sLetters[a] = sLetters[b];
                sLetters[b] = temp;

                a++;
                b--;
            }
        }

       

        return new string(sLetters);
    }
}
