using L1T3;

Author author = new Author
{
    _authorText = "Petrov"
};

Content content = new Content
{
    _content = "This book about..."
};

Title title = new Title
{
    _title = "Winter"
};

Book book = new Book(author, content, title);

book.Show();