int CompareLists(Node headA, Node headB)
{
    if(headA == null && headB == null) return 1;
    while(true)
    {
        if(headA.next == null && headB.next == null) break;
        else if(headA.next == null || headB.next == null) return 0;
        
        if(headA.data != headB.data) return 0;
        headA = headA.next;
        headB = headB.next;
    }
    
    if(headA.data != headB.data) return 0;
    return 1;
}