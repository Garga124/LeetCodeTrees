/**
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
    int minDifference = Int32.MaxValue;
    TreeNode prev ;
    public int MinDiffInBST(TreeNode root) {
        InOrderTraversal(root);
        return minDifference;
    }

    public void InOrderTraversal(TreeNode root)
    {
        if(root == null)
        return;
        InOrderTraversal(root.left);
        if(prev !=null)
        {
            minDifference = Math.Min(minDifference,root.val - prev.val);
        }
        prev = root;
        InOrderTraversal(root.right);
    }


}