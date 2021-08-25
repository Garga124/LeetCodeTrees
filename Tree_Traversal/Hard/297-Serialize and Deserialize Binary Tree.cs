/**
 * Time Complexity O(N)
 * Space Complexity O(N)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {


    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null){
            return "X";
        }
        string leftSerializedNodes = serialize(root.left);
        string rightSerializedNodes = serialize(root.right);
        return root.val +","+ leftSerializedNodes + "," + rightSerializedNodes;
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        string [] stringNodesArr = data.Split(",");
        Queue<string> queue = new Queue<string>(); 
        for(int i =0;i<stringNodesArr.Length;i++){
            queue.Enqueue(stringNodesArr[i]);
        }
        TreeNode root = deserialize(queue);
        return root;
    }
    
      public static TreeNode deserialize(Queue<string> queue) {
          if(queue.Count() == null){
              return null;
          }
       string queueValue = queue.Dequeue();
          //Console.Out.WriteLine(queueValue);
          if(queueValue =="X")
              return null;
          TreeNode root = new TreeNode(Int32.Parse(queueValue));
          root.left = deserialize(queue);
          root.right = deserialize(queue);
          return root;
        
    }
    
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));