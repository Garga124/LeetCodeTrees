/**
Time Complexity :O(N)
Space Complexity :O(N)
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
      public TreeNode lca = new TreeNode();
      public int maxLevel = 0;
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        dfs(root,0);
        return lca;
    }
    
    public int dfs(TreeNode root,int currentLevel){
          maxLevel = Math.Max(maxLevel,currentLevel);
        if(root == null){
            return currentLevel;
        }
        
        int left = dfs(root.left,currentLevel+1);
        int right = dfs(root.right,currentLevel+1);
        if(left == maxLevel && right == maxLevel){
            lca = root;
        }
        return Math.Max(left,right);
    }
}