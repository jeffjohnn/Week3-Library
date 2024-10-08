class Book
{
    string Title;
    string Author;
    string ISBN;


    // Example of a constrictor that allows us to 'construct' a new
    // Book object 
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    } 

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {

        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginner", "Bill Gates", "1234567");


        // Output the information to the console
        book.DisplayInfo();
    }
}