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
    public TreeNode lca = new TreeNode();
    public int maxLevel = 0;
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        // find out the p and q node (which should be the last nodes)
        //approaches 1) find out the last leaves using Queue using BFS and then add the logic to find the lowest common ancrestor of binary tree, 
        //Time complexity is O(n) and space Complexity is o(n)
        //Approach 2 ) using DFS find out the deepest leaves and then add the logic to find the lowest common ancestor
        //Time Complexity id O(n) 
        
        //LowestCommonAncestor(root,1);
        dfs(root,0);
        return lca;
    }
    
    
    
    
    
    //
    private int dfs(TreeNode root, int currentLevel){
        maxLevel = Math.Max(maxLevel,currentLevel);
        if(root == null)
            return currentLevel;
        int left = dfs(root.left,currentLevel+1);
        int right = dfs(root.right,currentLevel+1);
        if(left == maxLevel && right == maxLevel){
            lca = root;
        }
        return Math.Max(left,right);
    }
    
    //Logic to find out the lowest common ancestor 
    public TreeNode LowestCommonAncestor(TreeNode root, int currentLevel){
        Console.Out.WriteLine("1");
        if(root == null){
            Console.Out.WriteLine("2");
            return null;
        }
        
        if(currentLevel>maxLevel){
            Console.Out.WriteLine("3");
            maxLevel = currentLevel;
        }
        
        
        
        
       /* if(root == p|| root == q)
            return root;*/
        
        //Traverse the left side of tree
        TreeNode left = LowestCommonAncestor(root.left , currentLevel++);
        //Traverse the right side of tree
        TreeNode right = LowestCommonAncestor(root.right,currentLevel++);
          Console.Out.WriteLine("4");
        if(left != null && right !=null){
            
            Console.Out.WriteLine("Left " +left.val);
             Console.Out.WriteLine("right " +right.val);
            return root;
        }
        
        if(left == null && right == null)
        { Console.Out.WriteLine("6");
            return null;
        }
        
        if(left != null){
            
             Console.Out.WriteLine("Left " +left.val);
            return left;
        }else {
             Console.Out.WriteLine("7");
            return right;
        }
       
    }
}