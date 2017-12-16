	public static Node insert(Node head, int data)
    {
        Node temp = head;
        if(head == null)
        {
            temp = new Node(data);
            head = temp;
        }
        else
        {
            while (temp.next != null) temp = temp.next;
            temp.next = new Node(data);
        }
        return head;
    }