namespace Leetcode_dotNET;

public class Problem_0657
{
    public bool JudgeCircle(string moves)
    {
        int x = 0;
        int y = 0;

        foreach (var move in moves)
        {
            switch(move)
            {
                case 'U': y += 1; break;
                case 'D': y -= 1; break;
                case 'R': x += 1; break;
                case 'L': x -= 1; break;

            }

        }
        if( x == 0 && y == 0)
        {
            return true;
        }
        return false;
    }
}
