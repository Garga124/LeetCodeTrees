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

public class Codec {
    // Encodes a tree to a single string.
       public string serialize(Node root) {
        StringBuilder sb = new StringBuilder();
        serializeHelper(root, sb);
        return sb.ToString();
    }
    //Helper serializer
    private void serializeHelper(Node root, StringBuilder sb){
        if(root == null){
            sb.Append("null").Append(",");
        } else{
              sb.Append(root.val).Append(",");
         sb.Append(root.children.Count()).Append(",");
            
         for(int i = 0;i<root.children.Count();i++){
             serializeHelper(root.children[i],sb);
         }
        }
      
      // Console.Out.WriteLine("SSSSSSSSS"+sb); 
    }
	
    // Decodes your encoded data to tree.
    public Node deserialize(string data) {
          Queue<string> queue = new Queue<string>();
        
        
        List<string> result = data.Split(',').ToList();

        foreach(string item in result){
            queue.Enqueue(item);
        }
        return deserializeHelper(queue);
    }
            //Helper serializer
    private Node deserializeHelper(Queue<String> q){
     string rootValue = q.Dequeue();
        //Console.Out.WriteLine("RootValue"+ rootValue);
        if(rootValue == "null"){
            return null;
        }else{
            
            int size = Convert.ToInt32(q.Dequeue());
            Node root = new Node();
            root.val = Convert.ToInt32(rootValue);
            // Console.Out.WriteLine("Size"+  size);
            root.children = new List<Node>();
            for(int i = 0;i<size;i++){
           
                root.children.Add(deserializeHelper(q));
            }
             return root;
        }
     
        
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));