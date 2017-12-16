void decode(String S ,Node root)
{
    Node cur = root;
    String result = "";
    
    for(int i = 0; i < S.length(); i++)
    {
        cur = (S.charAt(i) == '1')? cur.right : cur.left;
        if(cur.right == null && cur.left == null)
        {
            result += Character.toString(cur.data);
            cur = root;
        }
    }
    
    System.out.println(result);
}