namespace Leetcode_dotNET;

public class Problem_0859
{
    public bool BuddyStrings(string s, string goal)
    {
        var indexes = new List<int>();
        if (s.Length != goal.Length || s.Length == 1)
        {
            return false;
        }
        var unequalsCount = 0;
        var letters = new int[26];
        for (int i = 0; i < goal.Length; i++)
        {
            if (s[i] != goal[i])
            {
                indexes.Add(i);
                unequalsCount++;
                if (unequalsCount > 2) return false;
            }
            letters[s[i] - 'a']++;
        }
        if (unequalsCount == 0)
        {
            foreach(var i in letters)
            {
                if (i > 1) { return true; }
            }
            return false;
        }
        else if (unequalsCount == 2)
        {
            if (s[indexes[0]] == goal[indexes[1]] && s[indexes[1]] == goal[indexes[0]])
            {
                return true;
            }
            return false;
        }

        return false;
    }
}
