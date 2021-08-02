/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {
        List<Node> pAncestors = new List<Node>();
        while(p!=null){
            pAncestors.Add(p);
            p = p.parent;
        }
        while(q!=null){
            if(pAncestors.Contains(q)){
                return q;
            }
            q=q.parent;
        }
        return null;
    }
}