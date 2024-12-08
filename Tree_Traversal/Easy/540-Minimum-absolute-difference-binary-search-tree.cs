/**
 * Time :O(n)
 * Space: O(h)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int minimumDifference = Int32.MaxValue;
    TreeNode prevNode ;
    public int GetMinimumDifference(TreeNode root) {
        InOrderTraversal(root);
        return minimumDifference;
    }

    public void InOrderTraversal(TreeNode root)
    {
        if(root == null)
        return;
        //Traverse Left
        InOrderTraversal(root.left);
        if(prevNode !=null)
        minimumDifference = Math.Min(minimumDifference, root.val - prevNode.val);
        //Process root node 
        prevNode = root;
        InOrderTraversal(root.right);
    }
}