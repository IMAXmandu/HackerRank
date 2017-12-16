public static Node InsertNth(Node head, int data, int position)
{
    Node tmp = new Node();
    tmp.Data = data;
    tmp.Next = null;
    
    if(head == null) head = tmp;
    else if(position == 0)
    {
        tmp.Next = head;
        return tmp;
    }
    else
    {
        Node before = null;
        Node after = head;
        for(int i=0; i<position; i++)
        {
            before = after;
            after = before.Next;
        }
            
        before.Next = tmp;
        tmp.Next = after;
    }
    
    return head;
}
