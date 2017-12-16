void topView(Node root) 
{
    Node cur = root;
    Stack<Node> stack = new Stack<Node>();
    while(cur != null)
    {
        stack.push(cur);
        cur = cur.left;
    }
    
    while(stack.isEmpty() == false)
    {
        Node node = stack.pop();
        System.out.print(node.data + " ");
    }
    
    cur = root.right;
    while(cur != null)
    {
        System.out.print(cur.data + " ");
        cur = cur.right;
    }
}
