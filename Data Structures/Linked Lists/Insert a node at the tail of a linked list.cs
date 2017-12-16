public static Node Insert(Node head, int x)
{
    Node tmp = new Node();
    tmp.Data = x;
    tmp.Next = null;
    
    if(head == null) head = tmp;
    else
    {
        Node current = head;
        while(current.Next != null) {
            current = current.Next;
        }
        current.Next = tmp;
    }
    return head;
}
