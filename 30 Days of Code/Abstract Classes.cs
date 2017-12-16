class MyBook : Book
{
    private int price;
    public MyBook(String title, String author, int price) : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Author: {0}", author);
        Console.WriteLine("Price: {0}", price);
    }
}