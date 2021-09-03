/**
 TC=>O(H) where h is the height of the tree
 Space Complexity O(1) 
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
    public int ClosestValue(TreeNode root, double target) {
   /* TreeNode child = target < root.val ? root.left : root.right;

            if (child == null) {
                return root.val;
            }

            int childClosest = ClosestValue(child, target);

            return Math.Abs(root.val - target) < Math.Abs(childClosest - target) ? root.val : childClosest;
            */
        int res = root.val;
        while(root!=null){
            if(Math.Abs(target-root.val)<Math.Abs(target-res)){
                res = root.val;
            }
            if(target<root.val){
                root = root.left;
            }else{
                root = root.right;
            }
                
            
        }
        return res;
    }
}