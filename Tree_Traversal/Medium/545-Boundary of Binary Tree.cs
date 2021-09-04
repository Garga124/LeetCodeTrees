/**
//TC:O(N)
//SC:O(N)
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
    public IList<int> BoundaryOfBinaryTree(TreeNode root) {
        IList<int> list = new List<int>();
        if(!isLeafNode(root)){
             list.Add(root.val);
        }
          TreeNode node = root.left;
        //Add left boundary leaves
        while(node != null){
             if(!isLeafNode(node)){
             list.Add(node.val);
        }
            if(node.left!=null){
                node = node.left;
            }else{
                node = node.right;
            }
            
        }
        
        //Add leaves
        addLeaveNodes(root,list);
        
        //Add right boundary leaves
       Stack<int> stack = new Stack<int>();
        node = root.right;
        while(node!=null){
             if(!isLeafNode(node)){
             stack.Push(node.val);
        }
            if(node.right!=null){
                node = node.right;
            }else{
                node = node.left;
            }
        }
        while(stack.Any()){
            list.Add(stack.Pop());
        }
        
        return list;
        
    }
    
    public bool isLeafNode(TreeNode node){
        return(node.left == null && node.right == null);
    }
    public void addLeaveNodes(TreeNode root,IList<int> list){
        if(isLeafNode(root)){
            list.Add(root.val);
        }
        if(root.left != null){
            addLeaveNodes(root.left,list);
        }
         if(root.right != null){
            addLeaveNodes(root.right,list);
        }
    }
}