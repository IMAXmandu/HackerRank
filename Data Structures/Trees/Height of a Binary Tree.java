static int height(Node root) 
{
    int leftDepth = -1;
    int rightDepth = -1;
    if(root.left != null) leftDepth = height(root.left);
    if(root.right != null) rightDepth = height(root.right);
    return (leftDepth > rightDepth)? leftDepth + 1 : rightDepth + 1;
}
