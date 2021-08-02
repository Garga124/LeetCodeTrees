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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        TreeNode root = new TreeNode();
        
        return helper(postorder.Length-1,0, inorder.Length-1, postorder, inorder);
        
        
    }
    
     public TreeNode helper(int preStart, int inStart, int inEnd, int[] postorder, int[] inorder){
        if(preStart>postorder.Length-1 || inStart > inEnd ){
            return null;
        }
        TreeNode root = new TreeNode(postorder[preStart]);
        int iIndex = 0;
        // Console.Out.WriteLine("IStart and IEnd"+ inStart + ":End "+ inEnd);
        for(int i = inStart;i<=inEnd;i++ ){
            if(root.val == inorder[i])
                iIndex = i;
        }
        
        root.right = helper(preStart - 1,iIndex+1,inEnd,postorder,inorder);
        root.left  = helper(preStart -(inEnd - iIndex)-1,inStart, iIndex-1,postorder,inorder);
        return root;
    }
}