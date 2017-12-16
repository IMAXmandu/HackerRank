void Print(Node head) {
  if(head!=null){
        System.out.println(head.data);
        Print(head.next);
    }
}
