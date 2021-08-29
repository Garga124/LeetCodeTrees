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
    
    public IList<IList<int>> result = new List<IList<int>>();
    public SortedDictionary<int, List<int>> IndexingItems = new SortedDictionary<int, List<int>>();
        
    public IList<IList<int>> VerticalOrder(TreeNode root)
    {
        if(root == null) return result;
        Queue<(int, TreeNode)> queue = new Queue<(int, TreeNode)>();
        int hDis = 0;
        queue.Enqueue((hDis, root));
        
        while(queue.Count != 0)
        {
            (int, TreeNode) qTop = queue.Peek();
            queue.Dequeue();
            hDis = qTop.Item1;
            TreeNode current = qTop.Item2;
            AddItemToDictionary(hDis, current);
            
            if(current.left != null)
            {
                queue.Enqueue((hDis - 1, current.left));
            }
            
            if(current.right != null)
            {
                queue.Enqueue((hDis + 1, current.right));
            }
        }
        
        foreach(var item in IndexingItems)
        {
            var value = item.Value as List<int>;            
            result.Add(value);
        }
        return result;
    }
    
    public void AddItemToDictionary(int hDis, TreeNode node)
    {
        if(IndexingItems.ContainsKey(hDis))
        {
            IndexingItems[hDis].Add(node.val);
            // Console.WriteLine($"Updating {hDis} value");
        }
        else
        {
            // Console.WriteLine($"Adding new item {hDis} to Dictionary with {node.val} value");
            IndexingItems.Add(hDis, new List<int>(){ node.val });
        }
    }
}
