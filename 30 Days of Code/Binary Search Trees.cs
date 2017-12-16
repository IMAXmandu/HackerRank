    static int getHeight(Node root)
    {
        if (root == null) return -1;

        int left = 0;
        int right = 0;
        left = getHeight(root.left);
        right = getHeight(root.right);

        return (left >= right) ? left + 1 : right + 1;
    }