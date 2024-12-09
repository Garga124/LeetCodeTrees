/**
 * Definition for a binary tree node.
 * Using Inorder Traversal and Two Pointers – O(n) time and O(n) space
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
     List<int> nums = new List<int>();
    public bool FindTarget(TreeNode root, int k) {
      
      inorder(root);
       int[] arr = nums.ToArray();
       int left = 0;
       int right = arr.Length-1;
       
       //Use two pointers to find if there is a pair that //sums to sum
       while(left<right)
        {
            int currentSum = arr[left] + arr[right];
            if(currentSum == k)
            {
                return true;
            }
            //Move the left pointer to increase the currentsum
            else if (currentSum<k)
            {
                left ++;
            }
            //Move the right pointer to decrease the currentsum
            else 
            {
                right --;
            }
        }
        // No pair found
        return false;

    }

    public void inorder(TreeNode root)
    {
        if(root == null)
        return;
        //Left
        inorder(root.left);

        //Process node
        nums.Add(root.val);

        //Right
        inorder(root.right);

    }
}