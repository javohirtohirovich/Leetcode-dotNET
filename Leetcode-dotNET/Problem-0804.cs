namespace Leetcode_dotNET;

public class Problem_0804
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var morseLetters = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        var res = new HashSet<string>();

        foreach (var word in words)
        {
            var morse = "";
            foreach(var l in word)
            {
                morse += morseLetters[l - 'a'];
            }
            res.Add(morse);
        }

        return res.Count;
    }
}
