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
    public bool EvaluateTree(TreeNode root) {
        return postorderEvaluation(root);
    }

    public bool postorderEvaluation(TreeNode root)
    {
        //Case of root node means if they are leaf nodes
        if(root.val ==0)
        {
            return false;
        }
        if(root.val == 1)
        {
            return true;
        }
         //Left inorderEvaluation
       bool l =  postorderEvaluation(root.left);
        //Right
       bool r = postorderEvaluation(root.right);
        return root.val == 2?(l ||r):(l && r);
    }
}/**
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
    public bool EvaluateTree(TreeNode root) {
        return postorderEvaluation(root);
    }

    public bool postorderEvaluation(TreeNode root)
    {
        //Case of root node means if they are leaf nodes
        if(root.val ==0)
        {
            return false;
        }
        if(root.val == 1)
        {
            return true;
        }
         //Left inorderEvaluation
       bool l =  postorderEvaluation(root.left);
        //Right
       bool r = postorderEvaluation(root.right);
        return root.val == 2?(l ||r):(l && r);
    }
}