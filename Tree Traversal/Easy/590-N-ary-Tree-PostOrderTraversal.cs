/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> Postorder(Node root) {
        List<int> list = new List<int>();
        return postOrder(root,list);
        
    }
    
    public List<int> postOrder(Node root, List<int> list)
    {
        if (root == null){
            return list;
        }
        foreach(Node child in root.children){
            postOrder(child, list);
            
        }
        list.Add(root.val);
        return list;
    }
}