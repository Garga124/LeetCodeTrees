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
    int result = 0;
    public int MaxAncestorDiff(TreeNode root) {
        dfs(root,root.val,root.val);
        return result;
    }
    
    private void dfs(TreeNode node, int cmin, int cmax){
        if(node == null)
            return;
        result = Math.Max(result, Math.Max(Math.Abs(node.val-cmin),Math.Abs(node.val-cmax)));
        cmin = Math.Min(cmin,node.val);
        cmax = Math.Max(cmax,node.val);
        dfs(node.left,cmin,cmax);
        dfs(node.right,cmin,cmax);
    }
}