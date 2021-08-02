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
    public IList<int> PreorderTraversal(TreeNode root) {
     IList<int> list = new List<int>();
         if(root == null)
        {
            return list; 
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Any()){
            TreeNode curentNode = stack.Pop();
            list.Add(curentNode.val);
            if(curentNode.right !=null){
                stack.Push(curentNode.right);
            }
            if(curentNode.left !=null){
                stack.Push(curentNode.left);
            }
        }
        return list;
      //  return dfs(root,list);
        
    }
    /*
    public IList<int> dfs(TreeNode root, IList<int> list){
        if(root == null)
        {
            return list; 
        }
        
        list.Add(root.val);
        list = dfs(root.left,list);
        return dfs(root.right,list);
            
            
    }*/
   
}