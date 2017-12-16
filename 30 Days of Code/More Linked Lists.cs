  public static Node removeDuplicates(Node head){
    Node node = new Node(head.data);
        int before = node.data;
        while(head.next != null)
        {
            if (before != head.next.data)
            {
                insert(node, head.next.data);
                before = head.next.data;
            }
            head = head.next;
        }
        return node;
  }