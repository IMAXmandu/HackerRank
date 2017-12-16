Node Reverse(Node head)
{
    if(head == null || head.next == null) return head;
    
    Node tmp = new Node();
    tmp.data = head.data;
    tmp.next = null;
    
    Node result = Reverse(head.next);
    
    Node current = result;
    while(current.next != null) current = current.next;
    current.next = tmp;
    
    return result;
}
