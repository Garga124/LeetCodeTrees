// Time: O(N)
// Space: O(N)
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
  
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
           Dictionary<TreeNode,TreeNode> childParentMap = new Dictionary<TreeNode,TreeNode>();
        IList<int> result = new List<int>();
        HashSet<TreeNode> hashSetVisited = new HashSet<TreeNode>();
        if(root == null){
            return result;
        }
        findParent(childParentMap,root);
        Queue<TreeNode> queue = new  Queue<TreeNode>();
        queue.Enqueue(target);
        while(queue.Any()){
            int size = queue.Count;
            for(int i =0;i<size;i++){
                TreeNode node = queue.Dequeue();
                hashSetVisited.Add(node);
                if(k == 0)
                {
                    result.Add(node.val);
                }
                if(childParentMap.ContainsKey(node) && !hashSetVisited.Contains(childParentMap[node])){
                   // Console.Out.WriteLine("Inside if condition");
                    queue.Enqueue(childParentMap[node]);
                }
                    if(node.left !=null && !hashSetVisited.Contains(node.left))
                    {
                        queue.Enqueue(node.left);
                   
                    }
                    if(node.right!= null && !hashSetVisited.Contains(node.right))
                    {
                         queue.Enqueue(node.right);
                          
                    }
            }
            k--;
            if(k<0){
                break;
            }
        }
        return result;
    }
    public  void findParent( Dictionary<TreeNode,TreeNode> childParentMap,TreeNode root){
        if(root == null){
            return ;
        }
        if(root.left !=null)
        {
            childParentMap.Add(root.left,root);
        }
        if(root.right !=null)
        {
            childParentMap.Add(root.right,root);
            
            
        }
        findParent(childParentMap,root.left);
        findParent(childParentMap,root.right);
        return ;
    }
}