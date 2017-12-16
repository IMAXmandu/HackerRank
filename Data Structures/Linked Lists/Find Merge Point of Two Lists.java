int FindMergeNode(Node headA, Node headB)
{
    while(headA != null)
    {
        Node cur = headB;
        while(cur != null)
        {
            if(cur == headA && cur.next == headA.next) return cur.data;
            cur = cur.next;
        }
        headA = headA.next;
    }
    
    return 0;
}