namespace BookLibrary
{
    class Library
    {
        public string CollectionName;
        public List<Book> Books;
        public Library(string collectionName)
        {
            CollectionName = collectionName;
            Books = new List<Book>();
        }
        public void AddBook(Book Book)
        {
            Books.Add(Book);
            System.Console.WriteLine($"Книга - {Book.Title}, {Book.Author} добавлена в коллекцию {CollectionName}");
        }
        public void ShowAllBooks()
        {
            System.Console.WriteLine($"Книги коллекции - {CollectionName}");
            for (int i = 0; i < Books.Count; i++)
            {
                System.Console.Write($"{i + 1}. ");
                Books[i].ShowInfo();
            }
        }
        public void DeleteBook(Book Book)
        {
            Books.Remove(Book);
            System.Console.WriteLine($"Книга - {Book.Title}, {Book.Author} была удалена из коллекции {CollectionName} :(");
        }
        public void ShowBooksByGenre(string genre)
        {
            System.Console.WriteLine($"Книги жанра '{genre}' из коллекции '{CollectionName}':");
            bool found = false;

            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Genre == genre)
                {
                    System.Console.Write($"{i + 1}. ");
                    Books[i].ShowInfo();
                    found = true;
                }
            }

            if (!found)
            {
                System.Console.WriteLine("Книги указанного жанра не найдены.");
            }
        }

    }
}