public static Node Insert(Node head, int x)
{
    Node tmp = new Node();
    tmp.Data = x;
    
    if(head == null)
    {
        tmp.Next = null;
    }
    else
    {
        tmp.Next = head;
    }
    return tmp;
}
