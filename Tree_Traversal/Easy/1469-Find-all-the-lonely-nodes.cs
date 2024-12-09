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
    TreeNode prev = null;
    IList<int> lonelyNodes = new List<int>();
    public IList<int> GetLonelyNodes(TreeNode root) {
        
        preOrder(root);
        return lonelyNodes;
        
    }

    public void preOrder(TreeNode root)
    {
        if(root == null)
        return;
        //Process root
        if(root.left !=null && root.right ==null)
        {
            lonelyNodes.Add(root.left.val);
        }
        if(root.left ==null && root.right !=null)
        {
            lonelyNodes.Add(root.right.val);
        }
         //Left
        preOrder(root.left);
        //Right
        preOrder(root.right);
    }
}