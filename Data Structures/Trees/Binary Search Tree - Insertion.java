static Node Insert(Node root,int value)
{
    if(root == null)
    {
        Node rootNode = new Node();
        rootNode.data = value;
        root = rootNode;
    }
    else
    {
        if(root.data < value)
        {
            if(root.right != null) Insert(root.right, value);
            else
            {
                Node rightNode = new Node();
                rightNode.data = value;
                root.right = rightNode;
            }
        }
        else if(root.data > value)
        {
            if(root.left != null) Insert(root.left, value);
            else
            {
                Node leftNode = new Node();
                leftNode.data = value;
                root.left = leftNode;
            }
        }
    }
    return root;
}