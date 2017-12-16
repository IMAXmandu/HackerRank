Node RemoveDuplicates(Node head)
{
    Node trace = head;
    while(trace.next != null)
    {
        if(trace.data == trace.next.data)
        {
            trace.next = trace.next.next;
        }
        else
        {
            trace = trace.next;
        }
    }
    return head;
}
