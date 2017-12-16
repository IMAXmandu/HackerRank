void levelOrder(Node root)
{
    ArrayList<Node> list = new ArrayList<Node>();
    list.add(root);
    
    while(list.size() != 0)
    {
        Node cur = list.get(0);
        list.remove(0);
        System.out.print(cur.data + " ");
        if(cur.left != null) list.add(cur.left);
        if(cur.right != null) list.add(cur.right);
    }
}
