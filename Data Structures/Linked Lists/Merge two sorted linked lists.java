Node mergeLists(Node headA, Node headB)
{
    if(headA == null) return headB;
    if(headB.data < headA.data)
    {
        Node first = headB.next;
        headB.next = headA;
        headA = headB;
        headB = first;
    }
    
    while(headB != null)
    {
        boolean isInsert = false;
        Node back = null;
        Node current = headA;
        while(current != null)
        {
            if(headB.data < current.data)
            {
                Node temp = headB.next;
                back.next = headB;
                headB.next = current;
                headB = temp;
                isInsert = true;
                break;
            }
            back = current;
            current = current.next;
        }
        
        if(isInsert == false)
        {
            Node last = headB.next;
            back.next = headB;
            headB.next = current;
            headB = last;
        }
    }
    return headA;
}