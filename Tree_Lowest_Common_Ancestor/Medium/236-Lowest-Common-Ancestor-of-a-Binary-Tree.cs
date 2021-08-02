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
    private TreeNode result;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        findLCA(root,p,q);
        return result;
    }
    
    private bool findLCA(TreeNode root, TreeNode p, TreeNode q){
        if(root == null)
            return false;
        bool left = findLCA(root.left,p,q);
        bool right =  findLCA(root.right,p,q);
        bool curr = root == p || root == q;
        if((left && right)|| (left && curr) || (right && curr)){
          result = root;
        }
        
          return left || right || curr;
    }
}