/**
 * Time We can solve this in O(n) time and with a single traversal of the given BST. 
 * Space O(1)
 Definition for a binary tree node.
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
     TreeNode first = null;
        TreeNode prev = null;
        TreeNode middle = null;
        TreeNode last = null;
    public void RecoverTree(TreeNode root) {
        //Define the lowest value of the integer to the previous value, as this should be compared with the most left
        //node of the tree
        prev = new TreeNode(Int32.MinValue);
        //Traverse the tree using inorder traversal, this will help us in returning sorted nodes and will be easy to  
        //detect the violations
        inorderTraversal(root);
        //Detect Violation- first violation
        if(first !=null  && last !=null)
        {
            int t = first.val;
            first.val = last.val;
            last.val = t;
        }else if (first!= null && middle !=null)
        {
            //Detect Violation- second violation
            int t = first.val;
            first.val = middle.val;
            middle.val = t;

        }
    }

    //Method to traverse the tree using inorder traversal

    public void inorderTraversal(TreeNode root)
    {
        if(root == null)
        return;
        inorderTraversal(root.left);

        if(prev !=null && (root.val <prev.val))
        {
        //If this is first violation , mark these two violations and store it in
        // 'first' && 'middle'
        if(first == null)
        {
            first = prev;
            middle = root;
        }else
        {
            last = root;
        }

        }
        //Mark this node as prev and traverse right
        prev = root;
        inorderTraversal(root.right);
    }
}