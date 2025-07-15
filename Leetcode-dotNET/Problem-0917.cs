namespace Leetcode_dotNET;

public class Problem_0917
{
    public string ReverseOnlyLetters(string s)
    {
        var sArr = new char[s.Length];
        var charCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsLetter(s[i]))
            {
                sArr[i] = s[i];
                charCount++;
            }
        }

        var lettersCount = s.Length - charCount;
        var j = s.Length - 1;
        var f = 0;
        while (lettersCount > 0)
        {
            if (sArr[f] != '\0')
            {
                f++;
            }
            else if (!char.IsLetter(s[j]))
            {
                j--;
            }
            else if (char.IsLetter(s[j]) && sArr[f] == '\0')
            {
                sArr[f] = s[j];
                f++;
                j--;
                lettersCount--;
            }
           
        }
        return new string(sArr);
    }

    //Sample solution
    //public string ReverseOnlyLetters(string s)
    //{
    //    char[] arr = s.ToCharArray();
    //    int left = 0, right = s.Length - 1;

    //    while (left < right)
    //    {
    //        if (!char.IsLetter(arr[left]))
    //        {
    //            left++;
    //        }
    //        else if (!char.IsLetter(arr[right]))
    //        {
    //            right--;
    //        }
    //        else
    //        {
    //            (arr[left], arr[right]) = (arr[right], arr[left]);
    //            left++;
    //            right--;
    //        }
    //    }
    //    return new string(arr);
    //}
}
