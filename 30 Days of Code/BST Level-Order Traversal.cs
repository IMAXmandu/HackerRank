    static void levelOrder(Node root)
    {
        Queue<Node> q = new Queue<Node>();

        q.Enqueue(root);
        while (q.Count != 0)
        {
            Node node = q.Dequeue();
            Console.Write(node.data + " ");
            if (node.left != null) q.Enqueue(node.left);
            if (node.right != null) q.Enqueue(node.right);
        }
    }

    static void order(Node node)
    {
        if (node == null) return;

        if (node.left != null) Console.Write(node.left.data + " ");
        if (node.right != null) Console.Write(node.right.data + " ");
        order(node.left);
        order(node.right);
    }