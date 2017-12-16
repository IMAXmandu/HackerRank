Node SortedInsert(Node head,int data)
{
    if(head == null)
    {
        head = new Node();
        head.data = data;
        head.prev = null;
        head.next = null;
        return head;
    }
    else
    {
        Node cur = head;
        while(cur != null)
        {
            if(data > cur.data && ((cur.next != null && data < cur.next.data) || cur.next == null))
            {
                Node in = new Node();
                in.data = data;
                in.prev = cur;
                in.next = cur.next;
                
                if(cur.next != null) cur.next.prev = in;
                cur.next = in;
                
                return head;
            }
            cur = cur.next;
        }
    }
    
    Node in = new Node();
    in.data = data;
    in.prev = null;
    in.next = head;
    head.prev = in;
    return in;
}