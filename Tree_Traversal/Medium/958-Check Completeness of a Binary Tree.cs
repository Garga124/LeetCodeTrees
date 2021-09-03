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
    public bool IsCompleteTree(TreeNode root) {
        bool end = false;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Any()){
                TreeNode node = queue.Dequeue();
                if(node == null){
                    end = true;
                }else{
                    if(end) return false;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
        }
        return true;
    }
}