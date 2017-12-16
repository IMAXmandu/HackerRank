public static void ReversePrint(Node head)
{
    if(head == null) return;
    ReversePrint(head.Next);
    Console.WriteLine(head.Data);
}
