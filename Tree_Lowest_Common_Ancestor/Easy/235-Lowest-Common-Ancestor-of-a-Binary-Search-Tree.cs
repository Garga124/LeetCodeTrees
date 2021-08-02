/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //it means they both are in left subtree
        if(p.val<root.val && q.val <root.val ){
            return LowestCommonAncestor(root.left,p,q);
        }
           //it means they both are in right subtree
        else if(p.val>root.val && q.val>root.val){
            return LowestCommonAncestor(root.right,p,q);
        }else {
            //It means one is in the left subtree and one is in the right subtree and the root is the lowest common ancestor
            return root;
        }
            
        
    }
}