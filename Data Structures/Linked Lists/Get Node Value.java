int GetNode(Node head,int n)
{
    int count = 0;
    Node trace = head;
    while(trace != null)
    {
        trace = trace.next;
        count++;
    }
    
    for(int i=0; i<count - n - 1; i++) head = head.next;
    return head.data;
}
