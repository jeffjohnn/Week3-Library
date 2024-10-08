using Library;

class Program
{
    static void Main(string[] args)
    {

        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginner", "Bill Gates", "1234567");


        // Output the information to the console
        book.DisplayInfo();
    }
}