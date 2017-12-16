Node Reverse(Node head)
{
    if (head == null) return null;
    Node result = new Node();
    result.data = head.data;
    head = head.next;
    while(head != null)
    {
        Node temp = new Node();
        temp.data = head.data;
        temp.next = result;
        result.prev = temp;
        result = temp;
        
        head = head.next;
    }
    return result;
}