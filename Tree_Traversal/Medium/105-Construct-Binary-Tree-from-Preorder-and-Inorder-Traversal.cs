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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        TreeNode root = new TreeNode();
        if(preorder.Length == 1)
            root.val = preorder[0];
       return helper(0,0,inorder.Length-1,preorder,inorder);
        //return root;
    }
    public TreeNode helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder){
        if(preStart>preorder.Length-1 || inStart > inEnd ){
            return null;
        }
        TreeNode root = new TreeNode(preorder[preStart]);
        
        //Find the index of root in inorder to get the left and right values of a tree
        //1st time we need to find from the whole array
        int iIndex = 0;
        for(int i =inStart;i<=inEnd;i++){
            if(root.val == inorder[i]){
                iIndex = i;
            }
        }
        
        //Received index then find the left value and build a left subtree
        root.left = helper(preStart+1,inStart,iIndex-1,preorder,inorder);
        root.right = helper(preStart+iIndex-inStart +1,iIndex+1,inEnd,preorder,inorder);
            return root;
    }
}