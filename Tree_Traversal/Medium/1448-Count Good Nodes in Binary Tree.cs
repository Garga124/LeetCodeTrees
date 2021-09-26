/**Time Complexity : O(N)
Space Complexity : O(h)
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
    public int numberOfGoodNodes = 0;
    public int maxValue = Int32.MinValue;
    
    public int GoodNodes(TreeNode root) {
        if(root == null)
            return numberOfGoodNodes;
        //Technically Root Node is always a good node;
        maxValue = root.val;
        numberOfGoodNodes ++;
        //Find out how many good nodes are in the left subtree;
        if(root.left!=null){
       preOrder(root.left, maxValue);     
        }
       
        //Find out how many good nodes are in the right subtree;
        if(root.right!=null){
        preOrder(root.right,maxValue);
        }
        return numberOfGoodNodes;
        
        
        
        
    }
    
    void preOrder(TreeNode root , int maxValue){
        if(root.val>=maxValue){
            numberOfGoodNodes++;
            maxValue = root.val;
        }
        if(root.left !=null){
           preOrder(root.left,maxValue) ;
        }
        if(root.right !=null){
           preOrder(root.right,maxValue) ;
        }
        
    }
    
    
}