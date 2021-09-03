/**
Time Complexity : O(N)
Space Comlexity : O(H)
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
    public int start = 0 ;
    public TreeNode Str2tree(string s) {
        if(s==null || s.Length <=0){
            Console.Out.WriteLine("ddddd");
            return null;
        }
        return helper(s);
    }
    
    public TreeNode helper(string s){
        if(start>=s.Length){
            return null;
        }
        bool neg = false;
        if(s[start]=='-'){
            neg = true;
            start ++;
        }
        int num = 0;
        while(start<s.Length && Char.IsDigit(s[start])){
            int digit = s[start] - '0';
            num = num *10 + digit;
            start ++;
        }
        
        if(neg){
            num = -num;
        }
        TreeNode root = new TreeNode(num);
        if(start<s.Length && s[start] == '('){
            start ++;
            root.left = helper(s);
        }
        if(start<s.Length && s[start] == ')'){
            start ++;
            return root;
        }
        if(start<s.Length && s[start] == '('){
            start ++;
            root.right = helper(s);
        }
        if(start<s.Length && s[start] == ')'){
            start ++;
            return root;
        }
        
        return root;
    }
}