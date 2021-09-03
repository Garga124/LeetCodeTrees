/**
Time Complexity : O(M+N)
Space Complexity :O(M+N)
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        IList<int> result = new List<int>();
        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        leftSubtree(root1,s1);
        leftSubtree(root2,s2);
        while(s1.Any() && s2.Any()){
            TreeNode r1 = s1.Peek();
            TreeNode r2 = s2.Peek();
            if(r1.val>r2.val){
                result.Add(r2.val);
                s2.Pop();
                leftSubtree(r2.right,s2);
            }else{
                result.Add(r1.val);
                s1.Pop();
                leftSubtree(r1.right,s1);
            }
        }
        Stack<TreeNode> s = s1.Count() == 0?s2:s1;
        while(s.Any()){
            TreeNode r = s.Pop();
            result.Add(r.val);
            leftSubtree(r.right,s);
        }
        return result;
    }
    
    public void leftSubtree(TreeNode root,Stack<TreeNode> s){
        if(root == null){
            return;
        }
        s.Push(root);
        leftSubtree(root.left,s);
        
    }
}