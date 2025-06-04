namespace Leetcode_dotNET;

public class Problem_0020
{
    public bool IsValid(string s)
    {
        var stackCharackters = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stackCharackters.Push(s[i]);
            }
            else
            {
                if (stackCharackters.Count == 0)
                {
                    return false;
                }
                var first = stackCharackters.Pop();
                if ((s[i] == ')' && first != '(') ||
                    (s[i] == '}' && first != '{') ||
                    (s[i] == ']' && first != '['))
                {
                    return false;
                }

            }
        }

        return stackCharackters.Count == 0;
    }
}
