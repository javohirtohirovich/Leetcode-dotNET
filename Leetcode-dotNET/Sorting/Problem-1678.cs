namespace Leetcode_dotNET.Sorting;

public class Problem_1678
{
    public string Interpret(string command)
    {
        command = command.Replace("()", "o");
        command = command.Replace("(al)", "al");
        return command;
    }
}
