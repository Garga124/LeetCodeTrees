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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<int> zigzagList = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        bool reverse = true;
        if(root == null){
            return result;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Any()){
            zigzagList = new List<int>();
            int size = queue.Count();
                for(int i = 0; i<=size-1;i++){
                    TreeNode node = queue.Dequeue();
                    if(node.left !=null){
                         queue.Enqueue(node.left);
                     }if(node.right !=null){
                            queue.Enqueue(node.right);
                      }
                    if(reverse){
                    zigzagList.Add(node.val);    
                    } else{
                        zigzagList.Insert(0,node.val);
                    }
        }
            
            reverse = ! reverse;
            //Console.Out.WriteLine("Changing reverse" + reverse);
             result.Add(zigzagList);

    }
        return result;
}
}