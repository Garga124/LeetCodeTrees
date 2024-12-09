/**
 * Time Complexity O(n), where n are the number of nodes in binary tree.
 * Auxiliary Space: O(n), if the tree is completely unbalanced, the maximum size of the queue can grow to O(n).
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
    public bool IsCousins(TreeNode root, int x, int y) {

     if(root == null)
        {
            return false;
        }
        Queue<TreeNode>queue  = new Queue<TreeNode>();
          
        // Push the root node into queue
        queue.Enqueue(root);

        // variables to check if a and b are found yet.
        bool xFound = false, yFound = false;
        

        while(queue.Any())
        {
            int size = queue.Count();
            for(int i=0;i<size;i++)
            {
                TreeNode current = queue.Dequeue();

                if(current.val == x)
                {
                    xFound = true;
                }
                if(current.val == y)
                {
                    yFound = true;
                }
                //To check that x and y are siblings or not, check if the given node has two children nodes.

                if(current.left !=null && current.right != null)
                {
                    //if it has 2 children and they are equal to x and y, then return false;
                    //otherwise push left and right node of the child nodes to the queue
                    if((current.left.val == x && current.right.val == y) || (current.left.val == y && current.right.val == x))
                    {
                        return false;
                    }

                }


                if(current.left !=null)
                {
                    queue.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            // After iteration of one level, following needs to 
            // be checked
            
            // if both a and b are found,
            // return true.
            if (xFound && yFound)
                return true;
            
            // if one of a or b is found,
            // return false.
            if (xFound || yFound)
                return false;
        }
             return false;
            
        }
       

    
}