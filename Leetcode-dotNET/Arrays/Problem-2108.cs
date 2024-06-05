namespace Leetcode_dotNET.Arrays;

public class Problem_2108
{
    public string FirstPalindrome(string[] words)
    {
        var result = false;
        foreach (var word in words)
        {
            result = CheckWordPalindrome(word);
            if(result != false) { return word; }
        }
        return "";
    }
    public bool CheckWordPalindrome(string word)
    {
        string word2 = "";
        for(int i = word.Length - 1; i >= 0; i--)
        {
            word2 += word[i];
        }
        if(word==word2 )
        {
            return true;
        }
        else { return false; }
    }
}
