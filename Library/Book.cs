namespace Library
{

    class Book
    {
        private string title;
        private string author;
        private string isbn;

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }


        // Constructor to add a new book 
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}