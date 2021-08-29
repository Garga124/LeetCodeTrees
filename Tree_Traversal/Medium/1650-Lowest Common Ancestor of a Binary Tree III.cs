/*
Time Complexity : Total number of steps to find LCA = O(depth p + depth q - depth ofLCA )
Space Complexity : O(1)
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
        // Invalid Input Condition
        // Node P and Q must exist in the tree as per the given constraint
        if (p == null || q == null) {
            return null;
        }
        // Optional Base Condition. Due to the given constraint (p != q), this check is redundant
        // If both the nodes are the same, then the LCA is P or Q.
        if (p == q) {
            return p;
        }
         // Pointer to Node P
        Node pointerP = p;
        
        // Pointer to Node Q
        Node pointerQ = q;
        while(pointerP != pointerQ){
            if(pointerP == null){
                pointerP = q;
            }else{
                pointerP = pointerP.parent;
            }
            if(pointerQ == null){
                pointerQ = p;
            }else{
                pointerQ = pointerQ.parent;
            }
            
        }
        
        return pointerQ;
        
        
        
        
      /*  List<Node> pAncestors = new List<Node>();
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
        return null;*/
    }
}