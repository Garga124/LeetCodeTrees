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
    TreeNode prevNode;
    int leftSubTree = 0;
    int rightSubTree = 0;
    int result = 0;
    public int FindTilt(TreeNode root) {
        PostOrderTraversal(root);
        return result;
    }

    public int PostOrderTraversal(TreeNode root)
    {
        if(root == null)
        return 0;
        
        //Left
        int left = PostOrderTraversal(root.left);
        

        //Right
        int right = PostOrderTraversal(root.right);

        //Root
        result +=Math.Abs(left-right);
        return(left + right + root.val);
       
       //if root.left == null && root.right == null then you are on last node
       //append the value in the subtree sum and then make root = 0;
       //same for right node as well

    }
}