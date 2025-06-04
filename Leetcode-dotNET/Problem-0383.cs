namespace Leetcode_dotNET;

public class Problem_0383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var lettersRansomeNote = new int[26];
        var lettersMagazine = new int[26];

        foreach(var letter in ransomNote)
        {
            lettersRansomeNote[(int)letter - 'a']++;
        }

        foreach(var letter in magazine)
        {
            lettersMagazine[(int)letter - 'a']++;
        }
        
        for(int i=0; i<26;i++)
        {
            if (lettersRansomeNote[i] > lettersMagazine[i])
            {
                return false;
            }
        }
        return true;
    }
}
