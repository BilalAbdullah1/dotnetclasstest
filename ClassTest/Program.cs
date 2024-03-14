using ClassTest;

internal class Program
{
    public static void Main(string[] args)
    {

        Rectangle rec = new Rectangle(5, 5);
        rec.GetArea();
        rec.GetPerimeter();

        Book book = new Book("Death Note", "Tsugumi Ohba", 2006);
        book.DisplayInfo();

    }

}