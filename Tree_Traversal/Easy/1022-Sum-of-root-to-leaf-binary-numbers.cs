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
    
    public int SumRootToLeaf(TreeNode root) {
        return PreOrderTraversalToCalculateSum(root,0);
     
    }

    public int PreOrderTraversalToCalculateSum(TreeNode root,int sum)
    {
        if(root == null)
        return 0;
        sum = (2*sum) + root.val;
        if(root.left == null && root.right == null)
        return sum;
        return PreOrderTraversalToCalculateSum(root.left,sum) + PreOrderTraversalToCalculateSum(root.right,sum);

    }
}