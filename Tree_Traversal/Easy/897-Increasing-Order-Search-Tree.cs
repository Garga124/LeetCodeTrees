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
    TreeNode newRoot = null;
    TreeNode prev = null;
    public TreeNode IncreasingBST(TreeNode root) {
        InOrderTraversal(root);
        return newRoot;
    }

    public void InOrderTraversal(TreeNode root)
    {
        if(root == null)
        return;
        //Left
        InOrderTraversal(root.left);
        //Process 
        if(prev !=null)
        {
            root.left = null;
            prev.right = root;
        }
        if(newRoot == null)
        {
            newRoot = root;
        }
        prev = root;
        //Right
        InOrderTraversal(root.right);



    }
}