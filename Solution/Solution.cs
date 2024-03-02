using TreeNode = BinaryTree.TreeNode<int>;

namespace Solution;

public static class Solution
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root is null) return root;

        var temp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);
        
        return root;
    }
}