/**
 * Time : O(N)
 * Space : O(h) where h is the height of the tree, and it will be used by the recursion stack
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    TreeNode targetTree, res;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        targetTree = target;
        inorder(original,cloned);
        return res;
    }

    //placeholder for tree traversal
    public void inorder(TreeNode original, TreeNode cloned)
    {
        if(original !=null)
        {
             //Inorder --> Left, Root, Right
        //Left
        inorder(original.left,cloned.left);

        if(original == targetTree)
        {
            res = cloned;

        }
        //Right
        inorder(original.right,cloned.right);
        }
       
    }
}