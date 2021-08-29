/*
* Time complexity : O(N) since each node is processed exactly once.
* Space complexity :O(N). We have to keep a recursion stack of the size of the tree height, which is O(logN) for the best case of completely balanced tree and O(N) for the worst case of completely unbalanced tree.

// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node() {}

    public Node(int _val) {
        val = _val;
        left = null;
        right = null;
    }

    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
    }
}
*/

public class Solution {
        Node prev;
        Node headList;
    public Node TreeToDoublyList(Node root) {
        if(root == null){
            return root;
        }
       
       ConvertToDLL(root);
        prev.right = headList;
        headList.left = prev;
        
        return headList;
        
       // return root;
    }
    
    public void ConvertToDLL(Node root){
        if(root != null){
             ConvertToDLL(root.left);
        if(prev == null){
            headList = root;
        }else{
            root.left = prev;
            prev.right = root;
            
        }
        prev = root;
        ConvertToDLL(root.right);
        }
        
    }
}