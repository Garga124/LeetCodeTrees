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
    int count = 0;
    private TreeNode result ;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        dfs(root,p,q);
        Console.Out.WriteLine("Count Value is " + count);
        return count == 2 ?result :null;
    }
    
    private bool dfs(TreeNode root,TreeNode p,TreeNode q){
         //Console.Out.WriteLine("Current Value is " + root.val);
        if(root == null){
            return false;
        }
        
        bool left = dfs(root.left,p,q);
        bool right = dfs(root.right,p,q);
        bool curr = root == p || root == q;
        //Console.Out.WriteLine("Current Value is " + root);
        if(curr)
            count ++;
        if((left && right)||(left && curr)||(right && curr)){
            result = root;
        }
        
        return left || right || curr;
    }
}