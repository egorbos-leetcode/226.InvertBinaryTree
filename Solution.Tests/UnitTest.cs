using BinaryTree;

namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Equal([1, null, 2], Solution.InvertTree(TreeNode.BuildTree<int>([1, 2])).ToArray()); 
        Assert.Equal([4, 7, 2, 9, 6, 3, 1], Solution.InvertTree(TreeNode.BuildTree<int>([4, 2, 7, 1, 3, 6, 9])).ToArray());
        Assert.Equal([2, 3, 1], Solution.InvertTree(TreeNode.BuildTree<int>([2, 1, 3])).ToArray()); 
        Assert.Equal([], Solution.InvertTree(TreeNode.BuildTree<int>([]))?.ToArray() ?? []);
#pragma warning restore CS8604 // Possible null reference argument.
    }
}