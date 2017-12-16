public static Node Delete(Node head, int position)
{
    Node before = null;
    Node after = head;
    
    if(position == 0)
    {
        head = head.Next;
    }
    else
    {
        for(int i=0; i<position; i++)
        {
            before = after;
            after = before.Next;
        }

        before.Next = after.Next;
        after = null;
    }
    return head;
}
