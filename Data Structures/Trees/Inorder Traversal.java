void inOrder(Node root)
{
    if(root.left != null) inOrder(root.left);
    System.out.print(root.data + " ");
    if(root.right != null) inOrder(root.right);
}