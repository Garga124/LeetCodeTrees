/**
 * Time: O(N)
 * Space: O(1), we can use hashmap but it will take O(n) space
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
    int prev = 0;
    int count = 0;
    int maxFrequency = 0;
    List<int> modes = new List<int> ();
    public int[] FindMode(TreeNode root) {
       
        //Call Inorder traversal
        InOrderTraversal(root);
         Console.WriteLine("modes.Counmodes.Count" + modes.Count);
        //Convert List to Array
        int[] result = new int[modes.Count];
        int i =0;
        foreach(int value in modes)
        {
            result[i] = value;
            i++;

        }
        return result;
    }

    public void InOrderTraversal(TreeNode root)
    {
        if(root == null)
        return;
        InOrderTraversal(root.left);
        if(prev !=null)
        {
            if(prev == root.val)
            {
                 count ++;
            }else
            {
                //Reset the count
                count = 1;

            }
        }
        if(count>maxFrequency)
        {
            maxFrequency = count;
            modes.Clear();
            modes.Add(root.val);

        }
        else if(count == maxFrequency)
        {
            modes.Add(root.val);
        }
        prev = root.val;
        InOrderTraversal(root.right);
    }
}