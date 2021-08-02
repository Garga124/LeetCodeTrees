/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    
public List<int> Preorder(Node root) {
    List<int> list = new List<int>();
       return preOrderWalk(root , list);
       // return nodes;
    }
    public List<int> preOrderWalk(Node root, List<int> list){
        if(root == null){
            return list;
        }
        list.Add(root.val);
        foreach(Node child in root.children){
            preOrderWalk(child,list);
        }
        return list;
    }
}