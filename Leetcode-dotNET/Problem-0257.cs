namespace Leetcode_dotNET;
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Problem_0257
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<string>();
        if (root == null) return result;
        if (root.left == null && root.right == null)
        {
            result.Add(root.val.ToString());
            return result;
        }
        var leftPaths = BinaryTreePaths(root.left);
        var rightPaths = BinaryTreePaths(root.right);
        foreach (var path in leftPaths)
        {
            result.Add(root.val + "->" + path);
        }
        foreach (var path in rightPaths)
        {
            result.Add(root.val + "->" + path);
        }
        return result;
    }
}
