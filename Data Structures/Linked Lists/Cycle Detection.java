boolean hasCycle(Node head)
{
    for(int i=0; i<100 && head != null; i++) head = head.next;
    
    if(head == null) return false;
    return true;
}
