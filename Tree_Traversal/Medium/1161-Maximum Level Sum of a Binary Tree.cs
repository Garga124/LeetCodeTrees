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
    public int MaxLevelSum(TreeNode root) {
         if(root == null)
             return 0;
        
        int currSum = 0;
        int maxLevel = 1;
        int maxSum = root.val;
        int currLevel = 1;
        
        Queue<TreeNode> queue = new  Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Any()){
            currSum = 0;
             
            int size = queue.Count();
            for(int i =0;i<size;i++){
                TreeNode node = queue.Dequeue();
                currSum +=node.val;
               
                
                if(node.left !=null){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
               
            }
            Console.Out.WriteLine("I am at level"+ currLevel);
            Console.Out.WriteLine("MaxLevel"+ maxLevel);
            
             if(currSum>maxSum){
                    maxLevel = currLevel;
                    maxSum = currSum;
                }
            
       currLevel ++;
        }
             return maxLevel;
       
    }
}