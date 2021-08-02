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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> valuesPerLevel = new List<int>();
        //Use stack to store the values and then pop into list at the end using while loop
        
        //Or reach to leave node using DFS and then start the loop
        
        if(root == null)
        {
            return result;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
            while(queue.Any()){
                int size = queue.Count();
                 valuesPerLevel = new List<int>();
                for(int i=0;i<=size-1;i++){
                    TreeNode node = queue.Dequeue();
                    valuesPerLevel.Add(node.val);
                    if(node.left != null)
                    {
                       queue.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                       queue.Enqueue(node.right);
                    }
                }
                result.Insert(0,valuesPerLevel);
            }
        return result;
    }
    
  
}